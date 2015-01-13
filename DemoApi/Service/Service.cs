using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DemoApi.Common;
using DemoApi.TranscryptApi;
using DemoApi.TranscryptApi.TranscryptApiService;
using TaxNet.CAPI;
using Document = DemoApi.TranscryptApi.TranscryptApiService.Document;
using Organization = DemoApi.Common.Organization;

namespace DemoApi.Service
{
	public class Service : IService
	{
		private readonly ITranscryptApi _api = new TranscryptApi.TranscryptApi();

		#region Авторизация 

		/// <summary>
		/// Авторизация по логину и паролю
		/// </summary>
		/// <param name="name">Логин</param>
		/// <param name="password">Пароль</param>
		/// <returns></returns>
		public Guid LoginByPassword(string name, string password)
		{
			var result = _api.LoginToPassword(name, password);
			return result.IsSuccess ? result.Result : Guid.Empty;
		}

		/// <summary>
		/// Авторизация по сертификату
		/// </summary>
		/// <param name="certificate">Сертификат</param>
		/// <returns></returns>
		public Guid LoginByCertificate(byte[] certificate)
		{
			byte[] signedRandom;
			var cert = new X509Certificate2();
			cert.Import(certificate);
			var capi = new CryptoAPI();
			var secret = _api.GetRandomForLogin();

			try
			{
				capi.P7_SignMessage(Encoding.Unicode.GetBytes(secret.Result), cert.Thumbprint, true, false,
					out signedRandom);
				var result = _api.LoginToCert(signedRandom);
				return result.IsSuccess ? result.Result : Guid.Empty;
			}
			catch (Exception)
			{
				return Guid.Empty;
			}
		}

		#endregion

		#region Выбор организации

		/// <summary>
		/// Получение списка всех организаций
		/// </summary>
		/// <param name="token">Токен</param>
		/// <returns></returns>
		public List<Organization> GetAllOrganization(Guid token)
		{
			var result = _api.GetAllOrganizations(token);
			if (!result.IsSuccess) return null;
			return result.Result.Select(orgs => new Organization
			{
				FullName = orgs.FullName,
				DocflowMemberId = orgs.DocflowMemberId,
				State = orgs.State,
			}).ToList();
		}

		/// <summary>
		/// Выбор активной организации
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="docflowMemberId">Id выбранной организации</param>
		/// <returns></returns>
		public bool SetActiveOrganization(Guid tokenGuid, string docflowMemberId)
		{
			return _api.SetActiveOrganization(tokenGuid, docflowMemberId).IsSuccess;
		}

		#endregion

		#region Получение фильтрованного списка документов

		/// <summary>
		/// Получение списка документов по фильтру
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="filter">Фильтр</param>
		/// <returns></returns>
		public List<Common.Document> GetDocumentsGroup(Guid tokenGuid, Document.Filter filter)
		{
			var docsList = new List<Common.Document>();
			var result = _api.GetDocumentsGroups(tokenGuid, filter);
			foreach (var documentsGroup in result.Result)
			{
				foreach (var documents in documentsGroup.Documents)
				{
					var document = new Common.Document
					{
						CreateDate = documents.CreateDateTime,
						UpdateTime = documents.UpdateDateTime,
						Title = documents.Title,
					};
					if (filter.ReceiverDocflowMemberId != null)
					{
						document.AgentName = documents.Sender.FullName;
						document.Status = StateToString(documents.SenderState);
					}
					else if (filter.SenderDocflowMemberId != null)
					{
						document.AgentName = documents.Receiver.FullName;
						document.Status = StateToString(documents.ReceiverState);
					}
					document.DocumentId = documents.Id;
					docsList.Add(document);
				}
			}
			return docsList;
		}

		#endregion

		#region Получение контента документа

		/// <summary>
		/// Получить документ
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="documentId">Id документа</param>
		/// <param name="type">Тип документа</param>
		/// <returns></returns>
		public FileDocument GetDocumentContent(Guid tokenGuid, Guid documentId, DownloadType type)
		{
			var document = _api.GetDocument(tokenGuid, documentId);
			if (!document.IsSuccess || document.Result == null)
				return null;

			var permFile = _api.GetPrimaryFile(tokenGuid, document.Result.Id);
			if (!permFile.IsSuccess || permFile.Result == null)
				return null;

			var content = _api.GetContent(tokenGuid, permFile.Result.Id);
			if (!content.IsSuccess || content.Result == null)
				return null;

			var fileName = permFile.Result.Filename;

			var fileDocument = new FileDocument
			{
				FileContent = content.Result,
				FileName = fileName,
			};

			return fileDocument;
		}

		#endregion

		#region Адресная книга

		/// <summary>
		/// Отправка запроса на обмен документами
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="requestReceiverName">Получатель запроса</param>
		/// <param name="description">Комментарий к запросу</param>
		/// <returns></returns>
		public bool SendExchangeRequest(Guid tokenGuid, TranscryptApi.TranscryptApiService.Organization.Filter requestReceiverName, string description)
		{
			var requestReceiverId = _api.FindOrganizationsToAdd(tokenGuid, requestReceiverName);
			var firstOrDefault = requestReceiverId.Result.FirstOrDefault();
			if (firstOrDefault == null) return false;
			return _api.SendExchangeRequest(tokenGuid, firstOrDefault.DocflowMemberId, description).Result ==
			       TranscryptContact.StateCode.Sent;
		}

		/// <summary>
		/// Получить список контактов указанной организации
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="tabId">Тип запроса - отправленные запросы или полученные</param>
		/// <returns></returns>
		public List<Contact> GetContactList(Guid tokenGuid, ContactsTabs tabId)
		{
			var state = getState(tabId);
			var filter = new TranscryptContact.Filter
            {
                State = state,
            };
			var result = _api.GetContactList(tokenGuid, filter);
			return result.Result.Select(contact => new Contact { ContactId = contact.Organization.DocflowMemberId, 
				FullName = contact.Organization.FullName}).ToList();
		}

		/// <summary>
		/// Принять запрос на взаимодействие
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="contactId">Id контакта, отправившего запроса</param>
		/// <returns></returns>
		public bool AcceptExchangeRequest(Guid tokenGuid, string contactId)
		{
			var result = _api.AcceptExchangeRequest(tokenGuid, contactId);
			return result.Result == TranscryptContact.StateCode.Active;
		}

		/// <summary>
		/// Отвергуть/удалить запрос на обмен документами
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="contactId">Id контакта, с которым установлена связь</param>
		/// <returns></returns>
		public bool RejectExchangeRequest(Guid tokenGuid, string contactId)
		{
			var result = _api.RejectExchangeRequest(tokenGuid, contactId);
			return result.Result == TranscryptContact.StateCode.Deleted;
		}

		#region Вспомогательные методы для адресной книги

		private static string StateToString(DocumentState documentState)
		{
			if (documentState.HasFlag(DocumentState.NeedResign))
				return "Требуется подпись";
			if (documentState.HasFlag(DocumentState.NeedClarification))
				return "Требуется уточнение";
			if (documentState.HasFlag(DocumentState.Completed))
				return "Завершен";
			if (documentState.HasFlag(DocumentState.Sent))
				return "Отправлен";
			return string.Empty;
		}

		#endregion

		private TranscryptContact.StateCode getState(ContactsTabs id)
		{
			switch (id)
			{
				case ContactsTabs.ReceiveRequestTb:
					return TranscryptContact.StateCode.Received;
				case ContactsTabs.SentRequestTb:
					return TranscryptContact.StateCode.Sent;
				default:
					return TranscryptContact.StateCode.Active;
			}
		}

		#endregion

		#region Отправка документов

		/// <summary>
		/// Отправить группу документов
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="file">Документ для отправки</param>
		/// <param name="receiverName">Id получателя</param>
		/// <param name="fileName">Имя документа</param>
		/// <returns></returns>
		public bool SendDocument(Guid tokenGuid, byte[] file, string receiverName, string fileName)
		{
			var orDefault = _api.GetContactList(tokenGuid, new TranscryptContact.Filter
			{
				SearchString = receiverName,
				State = TranscryptContact.StateCode.Active
			}).Result.FirstOrDefault();
			if (orDefault == null) return false;
			var receiverId = orDefault.Organization.DocflowMemberId;
			var res = _api.GetCertificates(tokenGuid, true);
			var firstOrDefault = res.Result.FirstOrDefault();
			if (firstOrDefault != null)
			{
				var thumbprint = firstOrDefault.Hash;
				var capi = new CryptoAPI();
				byte[] signature;
				capi.P7_SignMessage(file, thumbprint, true, true, out signature);
				var documentsForSend = new List<DocumentForSend>
				{
					new DocumentForSend
					{
						DocflowTypeCode = 4,
						FileContent = file,
						FileName = fileName,
						Signatures = new[] {signature},
					}
				};
				var result = _api.SendDocuments(tokenGuid, documentsForSend.ToArray(), receiverId);
				return result.IsSuccess;
			}
			return false;
		}
		#endregion

		#region Отправка ответов

		/// <summary>
		/// Отправка автоматического ответа
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <returns></returns>
		public Result ResponseDocuments(Guid tokenGuid)
		{
			var result = _api.GetDocumentsIdForResponce(tokenGuid);
			if (!result.IsSuccess) 
				return new Result
				{
					IsSuccess = false,
					Message = "Не удалось получить id документов для формирования ответных сообщений!",
				};
			if (result.Result.Count() == 0)
				return new Result
				{
					IsSuccess = true,
					Message = "Нет документов, для которых необходимо сформировать автоматический ответ!",
				};
			foreach (var id in result.Result)
			{
				if (id == Guid.Empty)
					return new Result
					{
						IsSuccess = false,
						Message = "Ошибка при формировании автоматических ответов - пустой id!",
					};

				var docId = id;
				var filesForSign = new List<FileForSign>();
				var needAllowResp = _api.GetAllowNotice(tokenGuid, docId);
				if (!needAllowResp.IsSuccess)
					return new Result
					{
						IsSuccess = false,
						Message = "Не удалось получить название транзакции по коду!",
					};
				foreach (var noticeResponce in needAllowResp.Result.Select(transCode => _api.GenerateReceptionNotice(tokenGuid, docId, transCode)))
				{
					if (!noticeResponce.IsSuccess)
						return new Result
						{
							IsSuccess = false,
							Message = "Ошибка при создании извещения о получении документа!",
						};
					var notice = noticeResponce.Result;

					filesForSign.Add(new FileForSign
					{
						Name = notice.FileName,
						Content = Convert.ToBase64String(notice.FileContent),
						TransactionCode = notice.TransactionCode,
						FileCode = notice.FileCode,
						Signature = Convert.ToBase64String(GetSignature(tokenGuid, notice.FileContent)),
					});
				}
				if (!SendResponse(tokenGuid, docId, filesForSign))
					return new Result
					{
						IsSuccess = false,
						Message = "Ошибка при отправке ответа!",
					};
			}
			return new Result
			{
				IsSuccess = true,
				Message = "Автоматическая отправка ответов успешно завершена!",
			};
		}

		#region Вспомогательные методы для формирования автоматических ответов

		private bool SendResponse(Guid tokenGuid, Guid id, IEnumerable<FileForSign> filesForSigns)
		{
			if (id == Guid.Empty) return false;

			var responses = filesForSigns.Select(signFile => new ResponseForSend
			{
				FileContent = Convert.FromBase64String(signFile.Content),
				FileName = signFile.Name,
				Signatures = new[] { Convert.FromBase64String(signFile.Signature) },
				TransactionCode = signFile.TransactionCode,
				FileCode = signFile.FileCode
			}).ToList();

			var docId = id;

			return responses.Select(response => _api.SendResponse(tokenGuid, response, docId)).All(sendResult => sendResult.IsSuccess);
		}

		private string GetCertificateThumbPrint(Guid tokenGuid)
		{
			var certificate = _api.GetCertificates(tokenGuid, true);
			var firstOrDefault = certificate.Result.FirstOrDefault();
			return firstOrDefault != null ? firstOrDefault.Hash : null;
		}

		private byte[] GetSignature(Guid tokenGuid, byte[] contentForSign)
		{
			var capi = new CryptoAPI();
			byte[] signature;

			capi.P7_SignMessage(contentForSign, GetCertificateThumbPrint(tokenGuid), true, true, out signature);

			return signature;
		}

		#endregion

		#endregion
	}
}