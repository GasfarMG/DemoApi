using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DemoApi.Common;
using DemoApi.Service;
using DemoApi.TranscryptApi.TranscryptApiService;
using Document = DemoApi.TranscryptApi.TranscryptApiService.Document;
using Organization = DemoApi.Common.Organization;

namespace DemoApi
{
	public partial class LoginForm : Form
	{
		private readonly IService _service = new Service.Service();
		private Guid _tokenGuid;
		private string _docflowMemberId;
		private Document.Filter _filter = new Document.Filter();

		public LoginForm()
		{
			InitializeComponent();
		}

		#region Авторизация
		private void loginByPassEnterBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(loginByPassNameLbl.Text) || string.IsNullOrEmpty(loginByPassPasswordTxtBx.Text))
			{
				Bases.ShowError("Заполните все поля!");
				return;
			}
			try
			{
				var result = _service.LoginByPassword(loginByPassNameTxtBx.Text, loginByPassPasswordTxtBx.Text);
				if (result != Guid.Empty)
				{
					FillOrganizationList(result);
				}
				else
				{
					Bases.ShowError("Не удалось авторизоваться по данным логину и паролю");
				}
			}
			catch (Exception exception)
			{
				Bases.ShowError("Ошибка при авторизации - " + exception.Message);
				throw;
			}
		}

		private void loginByCertificateSelectBtn_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog { Filter = @"Certificate|*.cer|All files|*.*" };
			var dr = ofd.ShowDialog(this);
			if (dr != DialogResult.OK)
				return;

			loginByCertificateSelectTxtBx.Text = ofd.FileName;
		}

		private void loginByCertificateEnterBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(loginByCertificateSelectTxtBx.Text))
				loginByCertificateSelectBtn_Click(sender, e);
			if (string.IsNullOrEmpty(loginByCertificateSelectTxtBx.Text))
			{
				Bases.ShowError("Выберите сертификат для авторизации");
				return;
			}
			byte[] cert;
			try
			{
				cert = File.ReadAllBytes(loginByCertificateSelectTxtBx.Text);
			}
			catch (Exception exception)
			{
				Bases.ShowError(@"При загрузке файла сертификата произошла ошибка. " + exception.Message);
				return;
			}
			var result = _service.LoginByCertificate(cert);
			if (result != Guid.Empty)
			{
				FillOrganizationList(result);
			}
			else
			{
				Bases.ShowError(@"При авторизации по сертификату произошла ошибка.");
			}
		}

		private void FillOrganizationList(Guid result)
		{
			_tokenGuid = result;
			var organizationList = _service.GetAllOrganization(_tokenGuid);
			loginPanel.Hide();
			loginPanel.Enabled = false;
			activeOrganizationPnl.Visible = true;
			selectActiveOrganizationCmbBx.Items.Clear();
			selectActiveOrganizationCmbBx.DataSource = organizationList;
			selectActiveOrganizationCmbBx.DisplayMember = "FullName";
		}
		#endregion

		#region Выбор организации
		private void selectActiveOrganizationCmbBx_SelectionChangeCommitted(object sender, EventArgs e)
		{
			var selectedActiveOrganization = selectActiveOrganizationCmbBx.SelectedItem as Organization;
			if (selectedActiveOrganization != null)
			{
				_docflowMemberId = selectedActiveOrganization.DocflowMemberId;
				if (!_service.SetActiveOrganization(_tokenGuid, _docflowMemberId))
					Bases.ShowError("Не удалось изменить активную организацию");
				else
				{
					Bases.ShowInfo("Текущая активная организация - " + selectedActiveOrganization.FullName);
					activeOrganizationPnl.Hide();
					activeOrganizationPnl.Enabled = false;
					reportsTbCtrl.Visible = true;
				}
			}
		}
		#endregion

		#region Документы

		private void reportsTbCtrl_VisibilityChanged(object sender, EventArgs e)
		{
			statusFilterCmbBx.DataSource = Enum.GetValues(typeof(DocumentState));
			inBoxBtn_Click(sender, e);
		}

		private void outBoxBtn_Click(object sender, EventArgs e)
		{
			_filter = new Document.Filter()
			{
				SenderDocflowMemberId = _docflowMemberId,
			};
			reportsDtGrdVw.DataSource = _service.GetDocumentsGroup(_tokenGuid, _filter);
			var dataGridViewColumn = reportsDtGrdVw.Columns["DocumentId"];
			if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
		}

		private void inBoxBtn_Click(object sender, EventArgs e)
		{
			_filter = new Document.Filter
			{
				ReceiverDocflowMemberId = _docflowMemberId,
			};
			reportsDtGrdVw.DataSource = _service.GetDocumentsGroup(_tokenGuid, _filter);
			var dataGridViewColumn = reportsDtGrdVw.Columns["DocumentId"];
			if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
		}

		private void filterBtn_Click(object sender, EventArgs e)
		{
			DocumentState filterDocumentState;
			Enum.TryParse(statusFilterCmbBx.SelectedValue.ToString(), out filterDocumentState);
			_filter.SenderState = filterDocumentState;
			_filter.ReceiverState = filterDocumentState;
			_filter.StartTime = createDateFilterDtTmPckr.Value;
			_filter.EndTime = updateDateFilterDtTmPckr.Value;
			if (_filter.ReceiverDocflowMemberId != null)
				_filter.Sender = agentNameFilterTxtBx.Text;
			if (_filter.SenderDocflowMemberId != null)
				_filter.Receiver = agentNameFilterTxtBx.Text;
			reportsDtGrdVw.DataSource = _service.GetDocumentsGroup(_tokenGuid, _filter);
			var dataGridViewColumn = reportsDtGrdVw.Columns["DocumentId"];
			if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
		}

		private void getDocumentContentBtn_Click(object sender, EventArgs e)
		{
			if (reportsDtGrdVw.CurrentRow == null) return;
			var documentId = (Guid)reportsDtGrdVw.CurrentRow.Cells["DocumentId"].Value;
			var resultFile = _service.GetDocumentContent(_tokenGuid, documentId, DownloadType.Documents);
			saveFileDialog.Filter = @"All files (*.*)|*.*";
			saveFileDialog.FileName = resultFile.FileName;
			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
			File.WriteAllBytes(saveFileDialog.FileName, resultFile.FileContent);
		}

		#endregion

		#region Адресная книга

		private void sentRequestBtn_Click(object sender, EventArgs e)
		{
			var result = _service.SendExchangeRequest(_tokenGuid, new TranscryptApi.TranscryptApiService.Organization.Filter { SearchString = nameInnRequestTxtBx.Text }, commentRequestTxtBx.Text);
			if (result)
				Bases.ShowInfo("Запрос успешно отправлен.");
			else 
				Bases.ShowError("Ошибка при отправке запроса.");
		}

		private void addressBookTbCtrl_TabIndexChanged(object sender, EventArgs e)
		{
			List<Contact> result;
			switch (addressBookTbCtrl.SelectedTab.Name)
			{
				case "receiveRequestTb":
					result = _service.GetContactList(_tokenGuid, ContactsTabs.ReceiveRequestTb);
					if (result.Count > 0)
					{
						receiveRequestLstBx.DataSource = result;
						receiveRequestLstBx.DisplayMember = "FullName";
					}
					else
					{
						receiveRequestLstBx.Items.Clear();
						receiveRequestLstBx.Items.Add("Список пуст!");
					}
					break;
				case "sentRequestTb":
					result = _service.GetContactList(_tokenGuid, ContactsTabs.SentRequestTb);
					if (result.Count > 0)
					{
						sentRequestLstBx.DataSource = result;
						sentRequestLstBx.DisplayMember = "FullName";
					}
					else
					{
						sentRequestLstBx.Items.Clear();
						sentRequestLstBx.Items.Add("Список пуст!");
					}
					break;
			}
		}

		private void acceptRequestBtn_Click(object sender, EventArgs e)
		{
			var contact = receiveRequestLstBx.SelectedItem as Contact;
			if (contact == null) return;
			var result = _service.AcceptExchangeRequest(_tokenGuid, _docflowMemberId);

			if (result)
				Bases.ShowInfo("Успешно добавлен контрагент!");
			else
				Bases.ShowError("При принятии запроса произошла ошибка!");
		}

		private void rejectRequestBtn_Click(object sender, EventArgs e)
		{
			var contact = sentRequestLstBx.SelectedItem as Contact;
			if (contact == null) return;
			var result = _service.AcceptExchangeRequest(_tokenGuid, _docflowMemberId);

			if (result)
				Bases.ShowInfo("Успешно отклонен контрагент!");
			else
				Bases.ShowError("При отклонении запроса произошла ошибка!");
		}

		#endregion

		#region Отправка документов

		private void docUploadBtn_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog { Filter = @"All files|*.*" };
			var dr = ofd.ShowDialog(this);
			if (dr != DialogResult.OK)
				return;

			docUploadTxtBx.Text = ofd.FileName;
		}

		private void docSendBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(docUploadTxtBx.Text))
				docUploadBtn_Click(sender, e);
			if (string.IsNullOrEmpty(docUploadTxtBx.Text))
			{
				Bases.ShowError(@"Не выбран сертификат для проверки");
				return;
			}
			byte[] file;
			try
			{
				file = File.ReadAllBytes(docUploadTxtBx.Text);
			}
			catch (Exception)
			{
				Bases.ShowError(@"При загрузке файла произошла ошибка. ");
				return;
			}
			var result = _service.SendDocument(_tokenGuid, file, docReceiverTxtBx.Text, docUploadTxtBx.Text);
			if (result)
				Bases.ShowInfo("Документы отправлены успешно.");
			else
			{
				Bases.ShowError("Ошибка при отправке докумнтов.");
			}
		}

		#endregion

		#region Отправка ответов

		private void receiveDocumentsForResponseBtn_Click(object sender, EventArgs e)
		{
			receiveDocumentsForResponseTxtBx.Text = @"Надо подождать... еще не готово!" + Environment.NewLine;
			var result = _service.ResponseDocuments(_tokenGuid);
			receiveDocumentsForResponseTxtBx.Text += result.Message + Environment.NewLine;
		}

		#endregion
	}
}
