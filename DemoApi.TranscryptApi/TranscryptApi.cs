using System;
using System.ServiceModel.Channels;
using DemoApi.TranscryptApi.TranscryptApiService;

namespace DemoApi.TranscryptApi
{
	public class TranscryptApi : ITranscryptApi
	{
		public OperationResultOfguid LoginToPassword(string login, string password)
		{
			OperationResultOfguid r;
			using (var a = new TranscryptApiAuthClient())
			{
				r = a.LoginToPassword(login, password);
			}
			return r;
		}

		public OperationResultOfguid LoginToCert(byte[] signedRandom)
		{
			OperationResultOfguid r;
			using (var a = new TranscryptApiAuthClient())
			{
				r = a.LoginToCert(signedRandom);
			}
			return r;
		}

		public OperationResultOfArrayOfOrganizationYNsim8dq GetAllOrganizations(Guid token)
		{
			OperationResultOfArrayOfOrganizationYNsim8dq r;
			using (var profile = new TranscryptApiProfileClient())
			{
				r = profile.GetAllOrganizations(token);
			}
			return r;
		}

		public OperationResultOfboolean SetActiveOrganization(Guid token, string docflowMemberId)
		{
			OperationResultOfboolean r;
			using (var profile = new TranscryptApiProfileClient())
			{
				r = profile.SetActiveOrganization(token, docflowMemberId);
			}
			return r;
		}

		public OperationResultOfstring GetRandomForLogin()
		{
			OperationResultOfstring r;
			using (var auth = new TranscryptApiAuthClient())
			{
				r = auth.GetRandomForLogin();
			}
			return r;
		}

		public PagedOperationResultOfArrayOfDocumentsGroupYNsim8dq GetDocumentsGroups(Guid token, Document.Filter filter)
		{
			PagedOperationResultOfArrayOfDocumentsGroupYNsim8dq r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetDocumentsGroups(token, filter);
			}
			return r;
		}

		public OperationResultOfDocumentYNsim8dq GetDocument(Guid token, Guid documentId)
		{
			OperationResultOfDocumentYNsim8dq r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetDocument(token, documentId);
			}
			return r;
		}

		public OperationResultOfTransactionFileYNsim8dq GetPrimaryFile(Guid token, Guid documentId)
		{
			OperationResultOfTransactionFileYNsim8dq r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetPrimaryFile(token, documentId);
			}
			return r;
		}

		public OperationResultOfbase64Binary GetContent(Guid token, Guid fileId)
		{
			OperationResultOfbase64Binary r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetContent(token, fileId);
			}
			return r;
		}

		public OperationResultOfArrayOfTransactionYNsim8dq GetTransactions(Guid token, Guid documentId)
		{
			OperationResultOfArrayOfTransactionYNsim8dq r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetTransactions(token, documentId);
			}
			return r;
		}

		public OperationResultOfTranscryptContactStateCodeYNsim8dq SendExchangeRequest(Guid token, string requestReceiverId,
			string description)
		{
			OperationResultOfTranscryptContactStateCodeYNsim8dq r;
			using (var ab = new TranscryptApiAddressBookClient())
			{
				r = ab.SendExchangeRequest(token, requestReceiverId, description);
			}
			return r;
		}

		public OperationResultOfArrayOfOrganizationYNsim8dq FindOrganizationsToAdd(Guid token, string searchStr)
		{
			OperationResultOfArrayOfOrganizationYNsim8dq r;
			using (var profile = new TranscryptApiProfileClient())
			{
				r = profile.FindOrganizationsToAdd(token, searchStr);
			}
			return r;
		}

		public OperationResultOfArrayOfTranscryptContactYNsim8dq GetContactList(Guid token, TranscryptContact.Filter filter)
		{
			OperationResultOfArrayOfTranscryptContactYNsim8dq r;
			using (var ab = new TranscryptApiAddressBookClient())
			{
				r = ab.GetContactList(token, filter);
			}
			return r;
		}

		public OperationResultOfTranscryptContactStateCodeYNsim8dq AcceptExchangeRequest(Guid token, string contactId)
		{
			OperationResultOfTranscryptContactStateCodeYNsim8dq r;
			using (var ab = new TranscryptApiAddressBookClient())
			{
				r = ab.AcceptExchangeRequest(token, contactId);
			}
			return r;
		}

		public OperationResultOfTranscryptContactStateCodeYNsim8dq RejectExchangeRequest(Guid token, string contactId)
		{
			OperationResultOfTranscryptContactStateCodeYNsim8dq r;
			using (var ab = new TranscryptApiAddressBookClient())
			{
				r = ab.RejectExchangeRequest(token, contactId);
			}
			return r;
		}

		public OperationResultOfguid SendDocuments(Guid token, DocumentForSend[] documents, string receiverId)
		{
			OperationResultOfguid r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.SendDocuments(token, documents, receiverId);
			}
			return r;
		}

		public OperationResultOfArrayOfCertificateInfoYNsim8dq GetCertificates(Guid token, bool activeOnly)
		{
			OperationResultOfArrayOfCertificateInfoYNsim8dq r;
			using (var profile = new TranscryptApiProfileClient())
			{
				r = profile.GetCertificates(token, activeOnly);
			}
			return r;
		}

		public OperationResultOfguid SendResponse(Guid token, ResponseForSend response, Guid documentId)
		{
			OperationResultOfguid r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.SendResponse(token, response, documentId);
			}
			return r;
		}

		public OperationResultOfArrayOfTranscryptContactYNsim8dq FindContacts(Guid token, TranscryptContact.Filter filter)
		{
			OperationResultOfArrayOfTranscryptContactYNsim8dq r;
			using (var profile = new TranscryptApiAddressBookClient())
			{
				r = profile.GetContactList(token, filter);
			}
			return r;
		}

		public OperationResultOfArrayOfguiduHEDJ7Dj GetDocumentsIdForResponce(Guid token)
		{
			OperationResultOfArrayOfguiduHEDJ7Dj r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetDocumentsIdForResponce(token);
			}
			return r;
		}

		public OperationResultOfArrayOfintuHEDJ7Dj GetAllowNotice(Guid token, Guid documentId)
		{
			OperationResultOfArrayOfintuHEDJ7Dj r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GetAllowNotice(token, documentId);
			}
			return r;
		}

		public OperationResultOfResponseForSendYNsim8dq GenerateReceptionNotice(Guid token, Guid documentId, int transactionType)
		{
			OperationResultOfResponseForSendYNsim8dq r;
			using (var transport = new TranscryptApiTransportClient())
			{
				r = transport.GenerateReceptionNotice(token, documentId, transactionType);
			}
			return r;
		}

		public OperationResultOfEmployeeYNsim8dq GetOrganizationEmployee(Guid token, Guid employeeId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfguid LoginToPasswordWithIntegrator(string login, string password, byte[] signedByIntegrator)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfguid LoginToCertWithIntegrator(byte[] signedByUser, byte[] signedByIntegrator)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean Logout(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfCertificateInfoYNsim8dq GetSessionCertificate(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean RegisterByCertificate(byte[] signedSecret)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean RegisterByCertificateAndKpp(byte[] sign, string kpp)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfEmployeeYNsim8dq GetEmployee(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean SaveEmployee(Guid token, Employee employee)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean CheckEmployeeHasCertificates(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean ChangePassword(Guid token, string oldPassword, string newPassword)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean CheckPassword(Guid token, string password)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfstring GetUserLogin(Guid token, Guid userId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfMyOrganizationYNsim8dq GetMyOrganization(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean SaveMyOrganization(Guid token, byte[] signedAlterOrganizationRequest)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfstring GetAlterOrganizationRequestPrintForm(Guid token, int signedAlterOrganizationRequestId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfSignedAlterOrganizationRequestYNsim8dq GetAlterOrganizationRequests(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfCertificateInfoYNsim8dq GetOrganiztionCertificates(Guid token, Guid organizationId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfOrganizationYNsim8dq GetOrganization(Guid token, string docflowMemberId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfbase64Binary GenerateAlterOrganizationRequest(Guid token, MyOrganization newDetails)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfstring GetAlterOrganizationRequestPreviewPrintForm(Guid token, MyOrganization newDetails)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfEmployeeYNsim8dq GetOrganizationEmployees(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean SaveOrganizationEmployee(Guid token, Employee employee)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean DeleteOrganizationEmployee(Guid token, Guid employeeId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfguid CreateOrganizationEmployee(Guid token, Employee employee)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfDepartmentYNsim8dq GetOrganizationDepartments(Guid token)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfDepartmentYNsim8dq GetOrganizationDepartment(Guid token, Guid departmentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean SaveOrganizationDepartment(Guid token, Department department)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfguid CreateOrganizationDepartment(Guid token, Department department)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean DeleteOrganizationDepartment(Guid token, Guid departmentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfstring GetTransactionName(Guid token, int transactionCode)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfResponseForSendYNsim8dq GenerateCorrectionNotice(Guid token, Guid documentId, string description)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfResponseForSendYNsim8dq GenerateAcceptanceNotice(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean CanCreateReceiveResult(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfstring GetRejectReason(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfbase64Binary PrepareForSend(Guid token, byte[] content, string receiverId, string fileName,
			DocflowDictionaryDocflowType docflowType)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfbase64Binary PrepareForSend(Guid token, byte[] content, string receiverId, string fileName)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean CheckChangesInDocuments(Guid token, DateTime lastUpdateDateTime, Document.Filter filter)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfDocumentYNsim8dq GetPrimaryFileListForInvoice(Guid token, byte[] content)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfInvoiceInfoYNsim8dq GetPrimaryDocumentInfoList(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfInvoiceInfoYNsim8dq GetCorrectionInfoList(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfArrayOfInvoiceInfoYNsim8dq GetRevisionInfoList(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfInvoiceInfoYNsim8dq GetInvoiceInfo(Guid token, Guid documentId)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfInvoiceInfoYNsim8dq GetInvoiceInfoByContent(Guid token, byte[] content)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfDocflowMemberIdRequestYNsim8dq GetDocflowMemberIdRequest(Guid token, Guid id)
		{
			throw new NotImplementedException();
		}

		public OperationResultOfboolean ChangeDocumentDepartment(Guid token, Guid documentId, Guid departmentId)
		{
			throw new NotImplementedException();
		}
	}
}
