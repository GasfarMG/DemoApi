using System;
using System.Collections.Generic;
using DemoApi.Common;
using Document = DemoApi.TranscryptApi.TranscryptApiService.Document;
using Organization = DemoApi.Common.Organization;

namespace DemoApi.Service
{
	public interface IService
	{
		/// <summary>
		/// Авторизация по логину и паролю
		/// </summary>
		/// <param name="name">Логин</param>
		/// <param name="password">Пароль</param>
		/// <returns></returns>
		Guid LoginByPassword(string name, string password);

		/// <summary>
		/// Авторизация по сертификату
		/// </summary>
		/// <param name="certificate">Сертификат</param>
		/// <returns></returns>
		Guid LoginByCertificate(byte[] certificate);

		/// <summary>
		/// Получение списка всех организаций
		/// </summary>
		/// <param name="token">Токен</param>
		/// <returns></returns>
		List<Organization> GetAllOrganization(Guid token);

		/// <summary>
		/// Выбор активной организации
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="docflowMemberId">Id выбранной организации</param>
		/// <returns></returns>
		bool SetActiveOrganization(Guid tokenGuid, string docflowMemberId);

		/// <summary>
		/// Получение списка документов по фильтру
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="filter">Фильтр</param>
		/// <returns></returns>
		List<Common.Document> GetDocumentsGroup(Guid tokenGuid, Document.Filter filter);

		/// <summary>
		/// Получить документ
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="documentId">Id документа</param>
		/// <param name="type">Тип документа</param>
		/// <returns></returns>
		FileDocument GetDocumentContent(Guid tokenGuid, Guid documentId, DownloadType type);

		/// <summary>
		/// Отправка запроса на обмен документами
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="requestReceiverName">Получатель запроса</param>
		/// <param name="description">Комментарий к запросу</param>
		/// <returns></returns>
		bool SendExchangeRequest(Guid tokenGuid, TranscryptApi.TranscryptApiService.Organization.Filter requestReceiverName, string description);

		/// <summary>
		/// Получить список контактов указанной организации
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="tabId">Тип запроса - отправленные запросы или полученные</param>
		/// <returns></returns>
		List<Contact> GetContactList(Guid tokenGuid, ContactsTabs tabId);

		/// <summary>
		/// Принять запрос на взаимодействие
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="contactId">Id контакта, отправившего запроса</param>
		/// <returns></returns>
		bool AcceptExchangeRequest(Guid tokenGuid, string contactId);

		/// <summary>
		/// Отправить группу документов
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <param name="file">Документ для отправки</param>
		/// <param name="receiverName">Id получателя</param>
		/// <param name="fileName">Имя документа</param>
		/// <returns></returns>
		bool SendDocument(Guid tokenGuid, byte[] file, string receiverName, string fileName);

		/// <summary>
		/// Отправка автоматического ответа
		/// </summary>
		/// <param name="tokenGuid">Токен</param>
		/// <returns></returns>
		Result ResponseDocuments(Guid tokenGuid);
	}
}
