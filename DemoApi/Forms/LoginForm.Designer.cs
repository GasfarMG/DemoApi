using System.Drawing;
using System.Security.AccessControl;

namespace DemoApi
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginByPassNameLbl = new System.Windows.Forms.Label();
			this.loginByPassNameTxtBx = new System.Windows.Forms.TextBox();
			this.loginByPassPasswordLbl = new System.Windows.Forms.Label();
			this.loginByPassPasswordTxtBx = new System.Windows.Forms.TextBox();
			this.loginTbCtrl = new System.Windows.Forms.TabControl();
			this.loginByPassTb = new System.Windows.Forms.TabPage();
			this.loginByPassEnterBtn = new System.Windows.Forms.Button();
			this.loginByCertificateTb = new System.Windows.Forms.TabPage();
			this.loginByCertificateEnterBtn = new System.Windows.Forms.Button();
			this.loginByCertificateLbl = new System.Windows.Forms.Label();
			this.loginByCertificateSelectTxtBx = new System.Windows.Forms.TextBox();
			this.loginByCertificateSelectBtn = new System.Windows.Forms.Button();
			this.loginPanel = new System.Windows.Forms.Panel();
			this.activeOrganizationPnl = new System.Windows.Forms.Panel();
			this.selectActiveOrganizationCmbBx = new System.Windows.Forms.ComboBox();
			this.selectActiveOrganizationLbl = new System.Windows.Forms.Label();
			this.reportsTbCtrl = new System.Windows.Forms.TabControl();
			this.documentsTb = new System.Windows.Forms.TabPage();
			this.getDocumentContentBtn = new System.Windows.Forms.Button();
			this.filterBtn = new System.Windows.Forms.Button();
			this.updateDateFilterDtTmPckr = new System.Windows.Forms.DateTimePicker();
			this.createDateFilterDtTmPckr = new System.Windows.Forms.DateTimePicker();
			this.statusFilterCmbBx = new System.Windows.Forms.ComboBox();
			this.agentNameFilterTxtBx = new System.Windows.Forms.TextBox();
			this.outBoxBtn = new System.Windows.Forms.Button();
			this.inBoxBtn = new System.Windows.Forms.Button();
			this.reportsDtGrdVw = new System.Windows.Forms.DataGridView();
			this.addressBookTb = new System.Windows.Forms.TabPage();
			this.addressBookTbCtrl = new System.Windows.Forms.TabControl();
			this.sendRequestTb = new System.Windows.Forms.TabPage();
			this.sentRequestBtn = new System.Windows.Forms.Button();
			this.commentRequestTxtBx = new System.Windows.Forms.TextBox();
			this.commentRequestLbl = new System.Windows.Forms.Label();
			this.nameInnRequestLbl = new System.Windows.Forms.Label();
			this.nameInnRequestTxtBx = new System.Windows.Forms.TextBox();
			this.receiveRequestTb = new System.Windows.Forms.TabPage();
			this.rejectRequestBtn = new System.Windows.Forms.Button();
			this.acceptRequestBtn = new System.Windows.Forms.Button();
			this.receiveRequestLstBx = new System.Windows.Forms.ListBox();
			this.sentRequestTb = new System.Windows.Forms.TabPage();
			this.sentRequestLstBx = new System.Windows.Forms.ListBox();
			this.docSendTb = new System.Windows.Forms.TabPage();
			this.docSendBtn = new System.Windows.Forms.Button();
			this.docUploadLbl = new System.Windows.Forms.Label();
			this.docUploadTxtBx = new System.Windows.Forms.TextBox();
			this.docReceiverTxtBx = new System.Windows.Forms.TextBox();
			this.docUploadBtn = new System.Windows.Forms.Button();
			this.docReceiverLbl = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.receiveDocumentsForResponseTxtBx = new System.Windows.Forms.TextBox();
			this.receiveDocumentsForResponseBtn = new System.Windows.Forms.Button();
			this.loginTbCtrl.SuspendLayout();
			this.loginByPassTb.SuspendLayout();
			this.loginByCertificateTb.SuspendLayout();
			this.loginPanel.SuspendLayout();
			this.activeOrganizationPnl.SuspendLayout();
			this.reportsTbCtrl.SuspendLayout();
			this.documentsTb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reportsDtGrdVw)).BeginInit();
			this.addressBookTb.SuspendLayout();
			this.addressBookTbCtrl.SuspendLayout();
			this.sendRequestTb.SuspendLayout();
			this.receiveRequestTb.SuspendLayout();
			this.sentRequestTb.SuspendLayout();
			this.docSendTb.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginByPassNameLbl
			// 
			this.loginByPassNameLbl.AutoSize = true;
			this.loginByPassNameLbl.Location = new System.Drawing.Point(165, 46);
			this.loginByPassNameLbl.Name = "loginByPassNameLbl";
			this.loginByPassNameLbl.Size = new System.Drawing.Size(38, 13);
			this.loginByPassNameLbl.TabIndex = 0;
			this.loginByPassNameLbl.Text = "Логин";
			// 
			// loginByPassNameTxtBx
			// 
			this.loginByPassNameTxtBx.Location = new System.Drawing.Point(74, 62);
			this.loginByPassNameTxtBx.Name = "loginByPassNameTxtBx";
			this.loginByPassNameTxtBx.Size = new System.Drawing.Size(216, 20);
			this.loginByPassNameTxtBx.TabIndex = 1;
			// 
			// loginByPassPasswordLbl
			// 
			this.loginByPassPasswordLbl.AutoSize = true;
			this.loginByPassPasswordLbl.Location = new System.Drawing.Point(158, 85);
			this.loginByPassPasswordLbl.Name = "loginByPassPasswordLbl";
			this.loginByPassPasswordLbl.Size = new System.Drawing.Size(45, 13);
			this.loginByPassPasswordLbl.TabIndex = 2;
			this.loginByPassPasswordLbl.Text = "Пароль";
			// 
			// loginByPassPasswordTxtBx
			// 
			this.loginByPassPasswordTxtBx.Location = new System.Drawing.Point(74, 101);
			this.loginByPassPasswordTxtBx.Name = "loginByPassPasswordTxtBx";
			this.loginByPassPasswordTxtBx.PasswordChar = '*';
			this.loginByPassPasswordTxtBx.Size = new System.Drawing.Size(216, 20);
			this.loginByPassPasswordTxtBx.TabIndex = 3;
			// 
			// loginTbCtrl
			// 
			this.loginTbCtrl.Controls.Add(this.loginByPassTb);
			this.loginTbCtrl.Controls.Add(this.loginByCertificateTb);
			this.loginTbCtrl.Location = new System.Drawing.Point(61, 19);
			this.loginTbCtrl.Name = "loginTbCtrl";
			this.loginTbCtrl.SelectedIndex = 0;
			this.loginTbCtrl.Size = new System.Drawing.Size(371, 281);
			this.loginTbCtrl.TabIndex = 4;
			// 
			// loginByPassTb
			// 
			this.loginByPassTb.Controls.Add(this.loginByPassEnterBtn);
			this.loginByPassTb.Controls.Add(this.loginByPassPasswordLbl);
			this.loginByPassTb.Controls.Add(this.loginByPassPasswordTxtBx);
			this.loginByPassTb.Controls.Add(this.loginByPassNameLbl);
			this.loginByPassTb.Controls.Add(this.loginByPassNameTxtBx);
			this.loginByPassTb.Location = new System.Drawing.Point(4, 22);
			this.loginByPassTb.Name = "loginByPassTb";
			this.loginByPassTb.Padding = new System.Windows.Forms.Padding(3);
			this.loginByPassTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.loginByPassTb.Size = new System.Drawing.Size(363, 255);
			this.loginByPassTb.TabIndex = 0;
			this.loginByPassTb.Text = "По логину и паролю";
			this.loginByPassTb.UseVisualStyleBackColor = true;
			// 
			// loginByPassEnterBtn
			// 
			this.loginByPassEnterBtn.Location = new System.Drawing.Point(143, 127);
			this.loginByPassEnterBtn.Name = "loginByPassEnterBtn";
			this.loginByPassEnterBtn.Size = new System.Drawing.Size(75, 23);
			this.loginByPassEnterBtn.TabIndex = 4;
			this.loginByPassEnterBtn.Text = "Войти";
			this.loginByPassEnterBtn.UseVisualStyleBackColor = true;
			this.loginByPassEnterBtn.Click += new System.EventHandler(this.loginByPassEnterBtn_Click);
			// 
			// loginByCertificateTb
			// 
			this.loginByCertificateTb.Controls.Add(this.loginByCertificateEnterBtn);
			this.loginByCertificateTb.Controls.Add(this.loginByCertificateLbl);
			this.loginByCertificateTb.Controls.Add(this.loginByCertificateSelectTxtBx);
			this.loginByCertificateTb.Controls.Add(this.loginByCertificateSelectBtn);
			this.loginByCertificateTb.Location = new System.Drawing.Point(4, 22);
			this.loginByCertificateTb.Name = "loginByCertificateTb";
			this.loginByCertificateTb.Padding = new System.Windows.Forms.Padding(3);
			this.loginByCertificateTb.Size = new System.Drawing.Size(363, 255);
			this.loginByCertificateTb.TabIndex = 1;
			this.loginByCertificateTb.Text = "По сертификату";
			this.loginByCertificateTb.UseVisualStyleBackColor = true;
			// 
			// loginByCertificateEnterBtn
			// 
			this.loginByCertificateEnterBtn.Location = new System.Drawing.Point(6, 88);
			this.loginByCertificateEnterBtn.Name = "loginByCertificateEnterBtn";
			this.loginByCertificateEnterBtn.Size = new System.Drawing.Size(75, 23);
			this.loginByCertificateEnterBtn.TabIndex = 3;
			this.loginByCertificateEnterBtn.Text = "Войти";
			this.loginByCertificateEnterBtn.UseVisualStyleBackColor = true;
			this.loginByCertificateEnterBtn.Click += new System.EventHandler(this.loginByCertificateEnterBtn_Click);
			// 
			// loginByCertificateLbl
			// 
			this.loginByCertificateLbl.AutoSize = true;
			this.loginByCertificateLbl.Location = new System.Drawing.Point(6, 46);
			this.loginByCertificateLbl.Name = "loginByCertificateLbl";
			this.loginByCertificateLbl.Size = new System.Drawing.Size(120, 13);
			this.loginByCertificateLbl.TabIndex = 2;
			this.loginByCertificateLbl.Text = "Выберите сертификат";
			// 
			// loginByCertificateSelectTxtBx
			// 
			this.loginByCertificateSelectTxtBx.Location = new System.Drawing.Point(6, 62);
			this.loginByCertificateSelectTxtBx.Name = "loginByCertificateSelectTxtBx";
			this.loginByCertificateSelectTxtBx.Size = new System.Drawing.Size(316, 20);
			this.loginByCertificateSelectTxtBx.TabIndex = 1;
			// 
			// loginByCertificateSelectBtn
			// 
			this.loginByCertificateSelectBtn.Location = new System.Drawing.Point(328, 59);
			this.loginByCertificateSelectBtn.Name = "loginByCertificateSelectBtn";
			this.loginByCertificateSelectBtn.Size = new System.Drawing.Size(25, 23);
			this.loginByCertificateSelectBtn.TabIndex = 0;
			this.loginByCertificateSelectBtn.Text = "...";
			this.loginByCertificateSelectBtn.UseVisualStyleBackColor = true;
			this.loginByCertificateSelectBtn.Click += new System.EventHandler(this.loginByCertificateSelectBtn_Click);
			// 
			// loginPanel
			// 
			this.loginPanel.AutoSize = true;
			this.loginPanel.Controls.Add(this.loginTbCtrl);
			this.loginPanel.Location = new System.Drawing.Point(12, 9);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(500, 303);
			this.loginPanel.TabIndex = 5;
			// 
			// activeOrganizationPnl
			// 
			this.activeOrganizationPnl.Controls.Add(this.selectActiveOrganizationCmbBx);
			this.activeOrganizationPnl.Controls.Add(this.selectActiveOrganizationLbl);
			this.activeOrganizationPnl.Location = new System.Drawing.Point(12, 9);
			this.activeOrganizationPnl.Name = "activeOrganizationPnl";
			this.activeOrganizationPnl.Size = new System.Drawing.Size(500, 283);
			this.activeOrganizationPnl.TabIndex = 6;
			this.activeOrganizationPnl.Visible = false;
			// 
			// selectActiveOrganizationCmbBx
			// 
			this.selectActiveOrganizationCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectActiveOrganizationCmbBx.FormattingEnabled = true;
			this.selectActiveOrganizationCmbBx.Location = new System.Drawing.Point(89, 157);
			this.selectActiveOrganizationCmbBx.Name = "selectActiveOrganizationCmbBx";
			this.selectActiveOrganizationCmbBx.Size = new System.Drawing.Size(249, 21);
			this.selectActiveOrganizationCmbBx.TabIndex = 2;
			this.selectActiveOrganizationCmbBx.SelectionChangeCommitted += new System.EventHandler(this.selectActiveOrganizationCmbBx_SelectionChangeCommitted);
			// 
			// selectActiveOrganizationLbl
			// 
			this.selectActiveOrganizationLbl.AutoSize = true;
			this.selectActiveOrganizationLbl.Location = new System.Drawing.Point(123, 51);
			this.selectActiveOrganizationLbl.Name = "selectActiveOrganizationLbl";
			this.selectActiveOrganizationLbl.Size = new System.Drawing.Size(181, 13);
			this.selectActiveOrganizationLbl.TabIndex = 0;
			this.selectActiveOrganizationLbl.Text = "Выберите активную организацию.";
			// 
			// reportsTbCtrl
			// 
			this.reportsTbCtrl.Controls.Add(this.documentsTb);
			this.reportsTbCtrl.Controls.Add(this.addressBookTb);
			this.reportsTbCtrl.Controls.Add(this.docSendTb);
			this.reportsTbCtrl.Controls.Add(this.tabPage1);
			this.reportsTbCtrl.Location = new System.Drawing.Point(12, 9);
			this.reportsTbCtrl.Name = "reportsTbCtrl";
			this.reportsTbCtrl.SelectedIndex = 0;
			this.reportsTbCtrl.Size = new System.Drawing.Size(500, 312);
			this.reportsTbCtrl.TabIndex = 7;
			this.reportsTbCtrl.Visible = false;
			this.reportsTbCtrl.VisibleChanged += new System.EventHandler(this.reportsTbCtrl_VisibilityChanged);
			// 
			// documentsTb
			// 
			this.documentsTb.Controls.Add(this.getDocumentContentBtn);
			this.documentsTb.Controls.Add(this.filterBtn);
			this.documentsTb.Controls.Add(this.updateDateFilterDtTmPckr);
			this.documentsTb.Controls.Add(this.createDateFilterDtTmPckr);
			this.documentsTb.Controls.Add(this.statusFilterCmbBx);
			this.documentsTb.Controls.Add(this.agentNameFilterTxtBx);
			this.documentsTb.Controls.Add(this.outBoxBtn);
			this.documentsTb.Controls.Add(this.inBoxBtn);
			this.documentsTb.Controls.Add(this.reportsDtGrdVw);
			this.documentsTb.Location = new System.Drawing.Point(4, 22);
			this.documentsTb.Name = "documentsTb";
			this.documentsTb.Padding = new System.Windows.Forms.Padding(3);
			this.documentsTb.Size = new System.Drawing.Size(492, 286);
			this.documentsTb.TabIndex = 0;
			this.documentsTb.Text = "Работа с документами";
			this.documentsTb.UseVisualStyleBackColor = true;
			// 
			// getDocumentContentBtn
			// 
			this.getDocumentContentBtn.Location = new System.Drawing.Point(6, 67);
			this.getDocumentContentBtn.Name = "getDocumentContentBtn";
			this.getDocumentContentBtn.Size = new System.Drawing.Size(137, 23);
			this.getDocumentContentBtn.TabIndex = 10;
			this.getDocumentContentBtn.Text = "Просмотр документа";
			this.getDocumentContentBtn.UseVisualStyleBackColor = true;
			this.getDocumentContentBtn.Click += new System.EventHandler(this.getDocumentContentBtn_Click);
			// 
			// filterBtn
			// 
			this.filterBtn.Location = new System.Drawing.Point(377, 65);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Size = new System.Drawing.Size(109, 23);
			this.filterBtn.TabIndex = 9;
			this.filterBtn.Text = "Применить";
			this.filterBtn.UseVisualStyleBackColor = true;
			this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
			// 
			// updateDateFilterDtTmPckr
			// 
			this.updateDateFilterDtTmPckr.Location = new System.Drawing.Point(364, 42);
			this.updateDateFilterDtTmPckr.Name = "updateDateFilterDtTmPckr";
			this.updateDateFilterDtTmPckr.Size = new System.Drawing.Size(122, 20);
			this.updateDateFilterDtTmPckr.TabIndex = 8;
			// 
			// createDateFilterDtTmPckr
			// 
			this.createDateFilterDtTmPckr.Location = new System.Drawing.Point(239, 42);
			this.createDateFilterDtTmPckr.Name = "createDateFilterDtTmPckr";
			this.createDateFilterDtTmPckr.Size = new System.Drawing.Size(118, 20);
			this.createDateFilterDtTmPckr.TabIndex = 7;
			// 
			// statusFilterCmbBx
			// 
			this.statusFilterCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.statusFilterCmbBx.FormattingEnabled = true;
			this.statusFilterCmbBx.Location = new System.Drawing.Point(112, 41);
			this.statusFilterCmbBx.Name = "statusFilterCmbBx";
			this.statusFilterCmbBx.Size = new System.Drawing.Size(121, 21);
			this.statusFilterCmbBx.TabIndex = 6;
			// 
			// agentNameFilterTxtBx
			// 
			this.agentNameFilterTxtBx.Location = new System.Drawing.Point(6, 41);
			this.agentNameFilterTxtBx.Name = "agentNameFilterTxtBx";
			this.agentNameFilterTxtBx.Size = new System.Drawing.Size(100, 20);
			this.agentNameFilterTxtBx.TabIndex = 5;
			// 
			// outBoxBtn
			// 
			this.outBoxBtn.Location = new System.Drawing.Point(84, 8);
			this.outBoxBtn.Name = "outBoxBtn";
			this.outBoxBtn.Size = new System.Drawing.Size(75, 23);
			this.outBoxBtn.TabIndex = 4;
			this.outBoxBtn.Text = "Исходящие";
			this.outBoxBtn.UseVisualStyleBackColor = true;
			this.outBoxBtn.Click += new System.EventHandler(this.outBoxBtn_Click);
			// 
			// inBoxBtn
			// 
			this.inBoxBtn.Location = new System.Drawing.Point(6, 8);
			this.inBoxBtn.Name = "inBoxBtn";
			this.inBoxBtn.Size = new System.Drawing.Size(75, 23);
			this.inBoxBtn.TabIndex = 3;
			this.inBoxBtn.Text = "Входящие";
			this.inBoxBtn.UseVisualStyleBackColor = true;
			this.inBoxBtn.Click += new System.EventHandler(this.inBoxBtn_Click);
			// 
			// reportsDtGrdVw
			// 
			this.reportsDtGrdVw.AllowUserToAddRows = false;
			this.reportsDtGrdVw.AllowUserToDeleteRows = false;
			this.reportsDtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.reportsDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.reportsDtGrdVw.Location = new System.Drawing.Point(6, 92);
			this.reportsDtGrdVw.MultiSelect = false;
			this.reportsDtGrdVw.Name = "reportsDtGrdVw";
			this.reportsDtGrdVw.ReadOnly = true;
			this.reportsDtGrdVw.RowHeadersVisible = false;
			this.reportsDtGrdVw.Size = new System.Drawing.Size(480, 188);
			this.reportsDtGrdVw.TabIndex = 2;
			// 
			// addressBookTb
			// 
			this.addressBookTb.Controls.Add(this.addressBookTbCtrl);
			this.addressBookTb.Location = new System.Drawing.Point(4, 22);
			this.addressBookTb.Name = "addressBookTb";
			this.addressBookTb.Padding = new System.Windows.Forms.Padding(3);
			this.addressBookTb.Size = new System.Drawing.Size(492, 286);
			this.addressBookTb.TabIndex = 1;
			this.addressBookTb.Text = "Адресная книга";
			this.addressBookTb.UseVisualStyleBackColor = true;
			// 
			// addressBookTbCtrl
			// 
			this.addressBookTbCtrl.Controls.Add(this.sendRequestTb);
			this.addressBookTbCtrl.Controls.Add(this.receiveRequestTb);
			this.addressBookTbCtrl.Controls.Add(this.sentRequestTb);
			this.addressBookTbCtrl.Location = new System.Drawing.Point(15, 37);
			this.addressBookTbCtrl.Name = "addressBookTbCtrl";
			this.addressBookTbCtrl.SelectedIndex = 0;
			this.addressBookTbCtrl.Size = new System.Drawing.Size(460, 243);
			this.addressBookTbCtrl.TabIndex = 2;
			this.addressBookTbCtrl.SelectedIndexChanged += new System.EventHandler(this.addressBookTbCtrl_TabIndexChanged);
			this.addressBookTbCtrl.TabIndexChanged += new System.EventHandler(this.addressBookTbCtrl_TabIndexChanged);
			// 
			// sendRequestTb
			// 
			this.sendRequestTb.Controls.Add(this.sentRequestBtn);
			this.sendRequestTb.Controls.Add(this.commentRequestTxtBx);
			this.sendRequestTb.Controls.Add(this.commentRequestLbl);
			this.sendRequestTb.Controls.Add(this.nameInnRequestLbl);
			this.sendRequestTb.Controls.Add(this.nameInnRequestTxtBx);
			this.sendRequestTb.Location = new System.Drawing.Point(4, 22);
			this.sendRequestTb.Name = "sendRequestTb";
			this.sendRequestTb.Padding = new System.Windows.Forms.Padding(3);
			this.sendRequestTb.Size = new System.Drawing.Size(452, 217);
			this.sendRequestTb.TabIndex = 0;
			this.sendRequestTb.Text = "Отправка";
			this.sendRequestTb.UseVisualStyleBackColor = true;
			// 
			// sentRequestBtn
			// 
			this.sentRequestBtn.Location = new System.Drawing.Point(158, 127);
			this.sentRequestBtn.Name = "sentRequestBtn";
			this.sentRequestBtn.Size = new System.Drawing.Size(122, 23);
			this.sentRequestBtn.TabIndex = 4;
			this.sentRequestBtn.Text = "Отправить запрос";
			this.sentRequestBtn.UseVisualStyleBackColor = true;
			this.sentRequestBtn.Click += new System.EventHandler(this.sentRequestBtn_Click);
			// 
			// commentRequestTxtBx
			// 
			this.commentRequestTxtBx.Location = new System.Drawing.Point(238, 83);
			this.commentRequestTxtBx.Name = "commentRequestTxtBx";
			this.commentRequestTxtBx.Size = new System.Drawing.Size(208, 20);
			this.commentRequestTxtBx.TabIndex = 3;
			// 
			// commentRequestLbl
			// 
			this.commentRequestLbl.AutoSize = true;
			this.commentRequestLbl.Location = new System.Drawing.Point(155, 83);
			this.commentRequestLbl.Name = "commentRequestLbl";
			this.commentRequestLbl.Size = new System.Drawing.Size(77, 13);
			this.commentRequestLbl.TabIndex = 2;
			this.commentRequestLbl.Text = "Комментарий";
			// 
			// nameInnRequestLbl
			// 
			this.nameInnRequestLbl.AutoSize = true;
			this.nameInnRequestLbl.Location = new System.Drawing.Point(16, 39);
			this.nameInnRequestLbl.Name = "nameInnRequestLbl";
			this.nameInnRequestLbl.Size = new System.Drawing.Size(216, 13);
			this.nameInnRequestLbl.TabIndex = 1;
			this.nameInnRequestLbl.Text = "Введите название организации или ИНН";
			// 
			// nameInnRequestTxtBx
			// 
			this.nameInnRequestTxtBx.Location = new System.Drawing.Point(238, 36);
			this.nameInnRequestTxtBx.Name = "nameInnRequestTxtBx";
			this.nameInnRequestTxtBx.Size = new System.Drawing.Size(208, 20);
			this.nameInnRequestTxtBx.TabIndex = 0;
			// 
			// receiveRequestTb
			// 
			this.receiveRequestTb.Controls.Add(this.rejectRequestBtn);
			this.receiveRequestTb.Controls.Add(this.acceptRequestBtn);
			this.receiveRequestTb.Controls.Add(this.receiveRequestLstBx);
			this.receiveRequestTb.Location = new System.Drawing.Point(4, 22);
			this.receiveRequestTb.Name = "receiveRequestTb";
			this.receiveRequestTb.Padding = new System.Windows.Forms.Padding(3);
			this.receiveRequestTb.Size = new System.Drawing.Size(452, 217);
			this.receiveRequestTb.TabIndex = 1;
			this.receiveRequestTb.Text = "Прием";
			this.receiveRequestTb.UseVisualStyleBackColor = true;
			// 
			// rejectRequestBtn
			// 
			this.rejectRequestBtn.Location = new System.Drawing.Point(110, 188);
			this.rejectRequestBtn.Name = "rejectRequestBtn";
			this.rejectRequestBtn.Size = new System.Drawing.Size(93, 23);
			this.rejectRequestBtn.TabIndex = 2;
			this.rejectRequestBtn.Text = "Отклонить запрос";
			this.rejectRequestBtn.UseVisualStyleBackColor = true;
			this.rejectRequestBtn.Click += new System.EventHandler(this.rejectRequestBtn_Click);
			// 
			// acceptRequestBtn
			// 
			this.acceptRequestBtn.Location = new System.Drawing.Point(6, 188);
			this.acceptRequestBtn.Name = "acceptRequestBtn";
			this.acceptRequestBtn.Size = new System.Drawing.Size(98, 23);
			this.acceptRequestBtn.TabIndex = 1;
			this.acceptRequestBtn.Text = "Принять запрос";
			this.acceptRequestBtn.UseVisualStyleBackColor = true;
			this.acceptRequestBtn.Click += new System.EventHandler(this.acceptRequestBtn_Click);
			// 
			// receiveRequestLstBx
			// 
			this.receiveRequestLstBx.FormattingEnabled = true;
			this.receiveRequestLstBx.Location = new System.Drawing.Point(6, 6);
			this.receiveRequestLstBx.Name = "receiveRequestLstBx";
			this.receiveRequestLstBx.Size = new System.Drawing.Size(440, 173);
			this.receiveRequestLstBx.TabIndex = 0;
			// 
			// sentRequestTb
			// 
			this.sentRequestTb.Controls.Add(this.sentRequestLstBx);
			this.sentRequestTb.Location = new System.Drawing.Point(4, 22);
			this.sentRequestTb.Name = "sentRequestTb";
			this.sentRequestTb.Padding = new System.Windows.Forms.Padding(3);
			this.sentRequestTb.Size = new System.Drawing.Size(452, 217);
			this.sentRequestTb.TabIndex = 2;
			this.sentRequestTb.Text = "Отправленные";
			this.sentRequestTb.UseVisualStyleBackColor = true;
			// 
			// sentRequestLstBx
			// 
			this.sentRequestLstBx.FormattingEnabled = true;
			this.sentRequestLstBx.Location = new System.Drawing.Point(6, 6);
			this.sentRequestLstBx.Name = "sentRequestLstBx";
			this.sentRequestLstBx.Size = new System.Drawing.Size(440, 199);
			this.sentRequestLstBx.TabIndex = 0;
			// 
			// docSendTb
			// 
			this.docSendTb.Controls.Add(this.docSendBtn);
			this.docSendTb.Controls.Add(this.docUploadLbl);
			this.docSendTb.Controls.Add(this.docUploadTxtBx);
			this.docSendTb.Controls.Add(this.docReceiverTxtBx);
			this.docSendTb.Controls.Add(this.docUploadBtn);
			this.docSendTb.Controls.Add(this.docReceiverLbl);
			this.docSendTb.Location = new System.Drawing.Point(4, 22);
			this.docSendTb.Name = "docSendTb";
			this.docSendTb.Padding = new System.Windows.Forms.Padding(3);
			this.docSendTb.Size = new System.Drawing.Size(492, 286);
			this.docSendTb.TabIndex = 2;
			this.docSendTb.Text = "Отправка документов";
			this.docSendTb.UseVisualStyleBackColor = true;
			// 
			// docSendBtn
			// 
			this.docSendBtn.Location = new System.Drawing.Point(194, 132);
			this.docSendBtn.Name = "docSendBtn";
			this.docSendBtn.Size = new System.Drawing.Size(75, 23);
			this.docSendBtn.TabIndex = 5;
			this.docSendBtn.Text = "Отправить";
			this.docSendBtn.UseVisualStyleBackColor = true;
			this.docSendBtn.Click += new System.EventHandler(this.docSendBtn_Click);
			// 
			// docUploadLbl
			// 
			this.docUploadLbl.AutoSize = true;
			this.docUploadLbl.Location = new System.Drawing.Point(30, 90);
			this.docUploadLbl.Name = "docUploadLbl";
			this.docUploadLbl.Size = new System.Drawing.Size(58, 13);
			this.docUploadLbl.TabIndex = 4;
			this.docUploadLbl.Text = "Документ";
			// 
			// docUploadTxtBx
			// 
			this.docUploadTxtBx.Location = new System.Drawing.Point(194, 88);
			this.docUploadTxtBx.Name = "docUploadTxtBx";
			this.docUploadTxtBx.Size = new System.Drawing.Size(250, 20);
			this.docUploadTxtBx.TabIndex = 3;
			// 
			// docReceiverTxtBx
			// 
			this.docReceiverTxtBx.Location = new System.Drawing.Point(194, 59);
			this.docReceiverTxtBx.Name = "docReceiverTxtBx";
			this.docReceiverTxtBx.Size = new System.Drawing.Size(280, 20);
			this.docReceiverTxtBx.TabIndex = 2;
			// 
			// docUploadBtn
			// 
			this.docUploadBtn.Location = new System.Drawing.Point(450, 85);
			this.docUploadBtn.Name = "docUploadBtn";
			this.docUploadBtn.Size = new System.Drawing.Size(24, 23);
			this.docUploadBtn.TabIndex = 1;
			this.docUploadBtn.Text = "...";
			this.docUploadBtn.UseVisualStyleBackColor = true;
			this.docUploadBtn.Click += new System.EventHandler(this.docUploadBtn_Click);
			// 
			// docReceiverLbl
			// 
			this.docReceiverLbl.AutoSize = true;
			this.docReceiverLbl.Location = new System.Drawing.Point(30, 59);
			this.docReceiverLbl.Name = "docReceiverLbl";
			this.docReceiverLbl.Size = new System.Drawing.Size(66, 13);
			this.docReceiverLbl.TabIndex = 0;
			this.docReceiverLbl.Text = "Получатель";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.receiveDocumentsForResponseBtn);
			this.tabPage1.Controls.Add(this.receiveDocumentsForResponseTxtBx);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(492, 286);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Отправка ответов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// receiveDocumentsForResponseTxtBx
			// 
			this.receiveDocumentsForResponseTxtBx.Location = new System.Drawing.Point(6, 6);
			this.receiveDocumentsForResponseTxtBx.Multiline = true;
			this.receiveDocumentsForResponseTxtBx.Name = "receiveDocumentsForResponseTxtBx";
			this.receiveDocumentsForResponseTxtBx.Size = new System.Drawing.Size(480, 234);
			this.receiveDocumentsForResponseTxtBx.TabIndex = 0;
			// 
			// receiveDocumentsForResponseBtn
			// 
			this.receiveDocumentsForResponseBtn.Location = new System.Drawing.Point(6, 246);
			this.receiveDocumentsForResponseBtn.Name = "receiveDocumentsForResponseBtn";
			this.receiveDocumentsForResponseBtn.Size = new System.Drawing.Size(75, 23);
			this.receiveDocumentsForResponseBtn.TabIndex = 1;
			this.receiveDocumentsForResponseBtn.Text = "Получить уведомления";
			this.receiveDocumentsForResponseBtn.UseVisualStyleBackColor = true;
			this.receiveDocumentsForResponseBtn.Click += new System.EventHandler(this.receiveDocumentsForResponseBtn_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(933, 642);
			this.Controls.Add(this.reportsTbCtrl);
			this.Controls.Add(this.activeOrganizationPnl);
			this.Controls.Add(this.loginPanel);
			this.Name = "LoginForm";
			this.Text = "Демонстрационный пример работы с Transcrypt API";
			this.loginTbCtrl.ResumeLayout(false);
			this.loginByPassTb.ResumeLayout(false);
			this.loginByPassTb.PerformLayout();
			this.loginByCertificateTb.ResumeLayout(false);
			this.loginByCertificateTb.PerformLayout();
			this.loginPanel.ResumeLayout(false);
			this.activeOrganizationPnl.ResumeLayout(false);
			this.activeOrganizationPnl.PerformLayout();
			this.reportsTbCtrl.ResumeLayout(false);
			this.documentsTb.ResumeLayout(false);
			this.documentsTb.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.reportsDtGrdVw)).EndInit();
			this.addressBookTb.ResumeLayout(false);
			this.addressBookTbCtrl.ResumeLayout(false);
			this.sendRequestTb.ResumeLayout(false);
			this.sendRequestTb.PerformLayout();
			this.receiveRequestTb.ResumeLayout(false);
			this.sentRequestTb.ResumeLayout(false);
			this.docSendTb.ResumeLayout(false);
			this.docSendTb.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label loginByPassNameLbl;
		private System.Windows.Forms.TextBox loginByPassNameTxtBx;
		private System.Windows.Forms.Label loginByPassPasswordLbl;
		private System.Windows.Forms.TextBox loginByPassPasswordTxtBx;
		private System.Windows.Forms.TabControl loginTbCtrl;
		private System.Windows.Forms.TabPage loginByPassTb;
		private System.Windows.Forms.Button loginByPassEnterBtn;
		private System.Windows.Forms.TabPage loginByCertificateTb;
		private System.Windows.Forms.Button loginByCertificateEnterBtn;
		private System.Windows.Forms.Label loginByCertificateLbl;
		private System.Windows.Forms.TextBox loginByCertificateSelectTxtBx;
		private System.Windows.Forms.Button loginByCertificateSelectBtn;
		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Panel activeOrganizationPnl;
		private System.Windows.Forms.ComboBox selectActiveOrganizationCmbBx;
		private System.Windows.Forms.Label selectActiveOrganizationLbl;
		private System.Windows.Forms.TabControl reportsTbCtrl;
		private System.Windows.Forms.TabPage documentsTb;
		private System.Windows.Forms.TabPage addressBookTb;
		private System.Windows.Forms.TabPage docSendTb;
		private System.Windows.Forms.DataGridView reportsDtGrdVw;
		private System.Windows.Forms.Button outBoxBtn;
		private System.Windows.Forms.Button inBoxBtn;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.DateTimePicker updateDateFilterDtTmPckr;
		private System.Windows.Forms.DateTimePicker createDateFilterDtTmPckr;
		private System.Windows.Forms.ComboBox statusFilterCmbBx;
		private System.Windows.Forms.TextBox agentNameFilterTxtBx;
		private System.Windows.Forms.Button getDocumentContentBtn;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.TabControl addressBookTbCtrl;
		private System.Windows.Forms.TabPage sendRequestTb;
		private System.Windows.Forms.Button sentRequestBtn;
		private System.Windows.Forms.TextBox commentRequestTxtBx;
		private System.Windows.Forms.Label commentRequestLbl;
		private System.Windows.Forms.Label nameInnRequestLbl;
		private System.Windows.Forms.TextBox nameInnRequestTxtBx;
		private System.Windows.Forms.TabPage receiveRequestTb;
		private System.Windows.Forms.ListBox receiveRequestLstBx;
		private System.Windows.Forms.TabPage sentRequestTb;
		private System.Windows.Forms.ListBox sentRequestLstBx;
		private System.Windows.Forms.Button rejectRequestBtn;
		private System.Windows.Forms.Button acceptRequestBtn;
		private System.Windows.Forms.Button docSendBtn;
		private System.Windows.Forms.Label docUploadLbl;
		private System.Windows.Forms.TextBox docUploadTxtBx;
		private System.Windows.Forms.TextBox docReceiverTxtBx;
		private System.Windows.Forms.Button docUploadBtn;
		private System.Windows.Forms.Label docReceiverLbl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button receiveDocumentsForResponseBtn;
		private System.Windows.Forms.TextBox receiveDocumentsForResponseTxtBx;
	}
}

