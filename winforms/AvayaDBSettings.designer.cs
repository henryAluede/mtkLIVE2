namespace DermalogMultiScannerDemo
{
    partial class AvayaDBSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvayaDBSettings));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_testConnection = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_serverSource = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_serverAddress = new MetroFramework.Controls.MetroTextBox();
            this.ch_useDirect = new System.Windows.Forms.CheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_userID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_pwd = new MetroFramework.Controls.MetroTextBox();
            this.btn_DBRefresh = new MetroFramework.Controls.MetroButton();
            this.btn_refreshServer = new MetroFramework.Controls.MetroButton();
            this.cb_initialcatalog = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_server = new System.Windows.Forms.Label();
            this.txt_connection = new System.Windows.Forms.TextBox();
            this.cb_datasource = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.camToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.btn_NIBBSAddr = new MetroFramework.Controls.MetroButton();
            this.btn_close = new MetroFramework.Controls.MetroButton();
            this.btn_connection = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.miscWithParamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cb_templateFormat = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lb_templateFormat = new MetroFramework.Controls.MetroLabel();
            this.txt_externalAPI = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btn_downloadSettings = new MetroFramework.Controls.MetroButton();
            this.pix_webSetting = new System.Windows.Forms.PictureBox();
            this.btn_getImageFolder = new MetroFramework.Controls.MetroButton();
            this.txt_imagefolder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btn_DBConnection = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Getsettings = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscWithParamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_webSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_testConnection);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.txt_serverSource);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txt_serverAddress);
            this.groupBox1.Controls.Add(this.ch_useDirect);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.txt_userID);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_pwd);
            this.groupBox1.Controls.Add(this.btn_DBRefresh);
            this.groupBox1.Controls.Add(this.btn_refreshServer);
            this.groupBox1.Controls.Add(this.cb_initialcatalog);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lb_server);
            this.groupBox1.Controls.Add(this.txt_connection);
            this.groupBox1.Controls.Add(this.cb_datasource);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 267);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Settings";
            // 
            // btn_testConnection
            // 
            this.btn_testConnection.Enabled = false;
            this.btn_testConnection.Location = new System.Drawing.Point(343, 230);
            this.btn_testConnection.Name = "btn_testConnection";
            this.btn_testConnection.Size = new System.Drawing.Size(109, 23);
            this.btn_testConnection.TabIndex = 64;
            this.btn_testConnection.Text = "Test Connection";
            this.btn_testConnection.UseSelectable = true;
            this.btn_testConnection.Click += new System.EventHandler(this.btn_testConnection_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(80, 230);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(70, 19);
            this.metroLabel11.TabIndex = 63;
            this.metroLabel11.Text = "DB Source";
            // 
            // txt_serverSource
            // 
            // 
            // 
            // 
            this.txt_serverSource.CustomButton.Image = null;
            this.txt_serverSource.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_serverSource.CustomButton.Name = "";
            this.txt_serverSource.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_serverSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_serverSource.CustomButton.TabIndex = 1;
            this.txt_serverSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_serverSource.CustomButton.UseSelectable = true;
            this.txt_serverSource.CustomButton.Visible = false;
            this.txt_serverSource.Enabled = false;
            this.txt_serverSource.Lines = new string[0];
            this.txt_serverSource.Location = new System.Drawing.Point(189, 230);
            this.txt_serverSource.MaxLength = 32767;
            this.txt_serverSource.Name = "txt_serverSource";
            this.txt_serverSource.PasswordChar = '\0';
            this.txt_serverSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_serverSource.SelectedText = "";
            this.txt_serverSource.SelectionLength = 0;
            this.txt_serverSource.SelectionStart = 0;
            this.txt_serverSource.ShortcutsEnabled = true;
            this.txt_serverSource.Size = new System.Drawing.Size(135, 23);
            this.txt_serverSource.TabIndex = 62;
            this.txt_serverSource.UseSelectable = true;
            this.txt_serverSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_serverSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(80, 200);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(98, 19);
            this.metroLabel10.TabIndex = 61;
            this.metroLabel10.Text = "Server Address";
            // 
            // txt_serverAddress
            // 
            // 
            // 
            // 
            this.txt_serverAddress.CustomButton.Image = null;
            this.txt_serverAddress.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_serverAddress.CustomButton.Name = "";
            this.txt_serverAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_serverAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_serverAddress.CustomButton.TabIndex = 1;
            this.txt_serverAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_serverAddress.CustomButton.UseSelectable = true;
            this.txt_serverAddress.CustomButton.Visible = false;
            this.txt_serverAddress.Enabled = false;
            this.txt_serverAddress.Lines = new string[0];
            this.txt_serverAddress.Location = new System.Drawing.Point(189, 200);
            this.txt_serverAddress.MaxLength = 32767;
            this.txt_serverAddress.Name = "txt_serverAddress";
            this.txt_serverAddress.PasswordChar = '\0';
            this.txt_serverAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_serverAddress.SelectedText = "";
            this.txt_serverAddress.SelectionLength = 0;
            this.txt_serverAddress.SelectionStart = 0;
            this.txt_serverAddress.ShortcutsEnabled = true;
            this.txt_serverAddress.Size = new System.Drawing.Size(135, 23);
            this.txt_serverAddress.TabIndex = 60;
            this.txt_serverAddress.UseSelectable = true;
            this.txt_serverAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_serverAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ch_useDirect
            // 
            this.ch_useDirect.AutoSize = true;
            this.ch_useDirect.Location = new System.Drawing.Point(343, 202);
            this.ch_useDirect.Name = "ch_useDirect";
            this.ch_useDirect.Size = new System.Drawing.Size(128, 17);
            this.ch_useDirect.TabIndex = 59;
            this.ch_useDirect.Text = "Direct Connection";
            this.ch_useDirect.UseVisualStyleBackColor = true;
            this.ch_useDirect.CheckedChanged += new System.EventHandler(this.ch_useDirect_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(80, 141);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(96, 19);
            this.metroLabel9.TabIndex = 58;
            this.metroLabel9.Text = "DB User Name";
            // 
            // txt_userID
            // 
            // 
            // 
            // 
            this.txt_userID.CustomButton.Image = null;
            this.txt_userID.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txt_userID.CustomButton.Name = "";
            this.txt_userID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_userID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userID.CustomButton.TabIndex = 1;
            this.txt_userID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userID.CustomButton.UseSelectable = true;
            this.txt_userID.CustomButton.Visible = false;
            this.txt_userID.Lines = new string[0];
            this.txt_userID.Location = new System.Drawing.Point(189, 141);
            this.txt_userID.MaxLength = 32767;
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.PasswordChar = '\0';
            this.txt_userID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userID.SelectedText = "";
            this.txt_userID.SelectionLength = 0;
            this.txt_userID.SelectionStart = 0;
            this.txt_userID.ShortcutsEnabled = true;
            this.txt_userID.Size = new System.Drawing.Size(101, 23);
            this.txt_userID.TabIndex = 0;
            this.txt_userID.UseSelectable = true;
            this.txt_userID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Server List";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 55;
            this.metroLabel4.Text = "Database Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(80, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 54;
            this.metroLabel3.Text = "DB Password";
            // 
            // txt_pwd
            // 
            // 
            // 
            // 
            this.txt_pwd.CustomButton.Image = null;
            this.txt_pwd.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txt_pwd.CustomButton.Name = "";
            this.txt_pwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pwd.CustomButton.TabIndex = 1;
            this.txt_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pwd.CustomButton.UseSelectable = true;
            this.txt_pwd.CustomButton.Visible = false;
            this.txt_pwd.Lines = new string[0];
            this.txt_pwd.Location = new System.Drawing.Point(189, 170);
            this.txt_pwd.MaxLength = 32767;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.SelectionLength = 0;
            this.txt_pwd.SelectionStart = 0;
            this.txt_pwd.ShortcutsEnabled = true;
            this.txt_pwd.Size = new System.Drawing.Size(101, 23);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.UseSelectable = true;
            this.txt_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_DBRefresh
            // 
            this.btn_DBRefresh.Location = new System.Drawing.Point(298, 141);
            this.btn_DBRefresh.Name = "btn_DBRefresh";
            this.btn_DBRefresh.Size = new System.Drawing.Size(87, 23);
            this.btn_DBRefresh.TabIndex = 27;
            this.btn_DBRefresh.Text = "Refresh DB";
            this.btn_DBRefresh.UseSelectable = true;
            this.btn_DBRefresh.Click += new System.EventHandler(this.btn_DBRefresh_Click);
            // 
            // btn_refreshServer
            // 
            this.btn_refreshServer.Location = new System.Drawing.Point(376, 19);
            this.btn_refreshServer.Name = "btn_refreshServer";
            this.btn_refreshServer.Size = new System.Drawing.Size(107, 23);
            this.btn_refreshServer.TabIndex = 26;
            this.btn_refreshServer.Text = "Refresh Server";
            this.btn_refreshServer.UseSelectable = true;
            this.btn_refreshServer.Click += new System.EventHandler(this.btn_refreshServer_Click);
            // 
            // cb_initialcatalog
            // 
            this.cb_initialcatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_initialcatalog.FormattingEnabled = true;
            this.cb_initialcatalog.Location = new System.Drawing.Point(189, 114);
            this.cb_initialcatalog.Name = "cb_initialcatalog";
            this.cb_initialcatalog.Size = new System.Drawing.Size(294, 21);
            this.cb_initialcatalog.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 19);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lb_server
            // 
            this.lb_server.AutoSize = true;
            this.lb_server.Location = new System.Drawing.Point(128, 11);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(0, 13);
            this.lb_server.TabIndex = 17;
            // 
            // txt_connection
            // 
            this.txt_connection.Location = new System.Drawing.Point(40, 71);
            this.txt_connection.Multiline = true;
            this.txt_connection.Name = "txt_connection";
            this.txt_connection.ReadOnly = true;
            this.txt_connection.Size = new System.Drawing.Size(443, 37);
            this.txt_connection.TabIndex = 16;
            // 
            // cb_datasource
            // 
            this.cb_datasource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_datasource.FormattingEnabled = true;
            this.cb_datasource.Location = new System.Drawing.Point(91, 19);
            this.cb_datasource.Name = "cb_datasource";
            this.cb_datasource.Size = new System.Drawing.Size(279, 21);
            this.cb_datasource.TabIndex = 15;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 337);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(154, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Default Template Format";
            // 
            // cb_branch
            // 
            this.cb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_branch.FormattingEnabled = true;
            this.cb_branch.Location = new System.Drawing.Point(612, 300);
            this.cb_branch.Name = "cb_branch";
            this.cb_branch.Size = new System.Drawing.Size(63, 21);
            this.cb_branch.TabIndex = 56;
            this.cb_branch.Visible = false;
            this.cb_branch.SelectedValueChanged += new System.EventHandler(this.Cb_branch_SelectedValueChanged);
            // 
            // camToggle1
            // 
            this.camToggle1.AutoSize = true;
            this.camToggle1.Location = new System.Drawing.Point(150, 522);
            this.camToggle1.Name = "camToggle1";
            this.camToggle1.Size = new System.Drawing.Size(80, 17);
            this.camToggle1.TabIndex = 48;
            this.camToggle1.Text = "Off";
            this.camToggle1.UseSelectable = true;
            this.camToggle1.Visible = false;
            this.camToggle1.CheckedChanged += new System.EventHandler(this.MetroToggle_DB_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 520);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Use External Camera";
            this.metroLabel1.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 385);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 19);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "CORE Web API Address";
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(176, 385);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(430, 23);
            this.txt_address.TabIndex = 51;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_NIBBSAddr
            // 
            this.btn_NIBBSAddr.Location = new System.Drawing.Point(476, 358);
            this.btn_NIBBSAddr.Name = "btn_NIBBSAddr";
            this.btn_NIBBSAddr.Size = new System.Drawing.Size(34, 19);
            this.btn_NIBBSAddr.TabIndex = 52;
            this.btn_NIBBSAddr.Text = "---";
            this.btn_NIBBSAddr.UseSelectable = true;
            this.btn_NIBBSAddr.Click += new System.EventHandler(this.btn_NIBBSAddr_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(705, 481);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(101, 30);
            this.btn_close.TabIndex = 53;
            this.btn_close.Text = "Close Form";
            this.btn_close.UseCustomBackColor = true;
            this.btn_close.UseCustomForeColor = true;
            this.btn_close.UseSelectable = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_connection
            // 
            this.btn_connection.BackColor = System.Drawing.Color.DimGray;
            this.btn_connection.ForeColor = System.Drawing.Color.White;
            this.btn_connection.Location = new System.Drawing.Point(569, 483);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(130, 28);
            this.btn_connection.TabIndex = 0;
            this.btn_connection.Text = "Save Configuration";
            this.btn_connection.UseCustomBackColor = true;
            this.btn_connection.UseCustomForeColor = true;
            this.btn_connection.UseSelectable = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers;
            this.pictureBox2.Location = new System.Drawing.Point(503, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // miscWithParamBindingSource
            // 
            this.miscWithParamBindingSource.DataMember = "MiscWithParam";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(681, 300);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // cb_templateFormat
            // 
            this.cb_templateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_templateFormat.FormattingEnabled = true;
            this.cb_templateFormat.Location = new System.Drawing.Point(176, 358);
            this.cb_templateFormat.Name = "cb_templateFormat";
            this.cb_templateFormat.Size = new System.Drawing.Size(294, 21);
            this.cb_templateFormat.TabIndex = 56;
            this.cb_templateFormat.SelectedValueChanged += new System.EventHandler(this.cb_templateFormat_SelectedValueChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(49, 360);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 19);
            this.metroLabel7.TabIndex = 57;
            this.metroLabel7.Text = "Template Format";
            // 
            // lb_templateFormat
            // 
            this.lb_templateFormat.AutoSize = true;
            this.lb_templateFormat.Location = new System.Drawing.Point(175, 336);
            this.lb_templateFormat.Name = "lb_templateFormat";
            this.lb_templateFormat.Size = new System.Drawing.Size(41, 19);
            this.lb_templateFormat.TabIndex = 57;
            this.lb_templateFormat.Text = "None";
            // 
            // txt_externalAPI
            // 
            // 
            // 
            // 
            this.txt_externalAPI.CustomButton.Image = null;
            this.txt_externalAPI.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.txt_externalAPI.CustomButton.Name = "";
            this.txt_externalAPI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_externalAPI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_externalAPI.CustomButton.TabIndex = 1;
            this.txt_externalAPI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_externalAPI.CustomButton.UseSelectable = true;
            this.txt_externalAPI.CustomButton.Visible = false;
            this.txt_externalAPI.Lines = new string[0];
            this.txt_externalAPI.Location = new System.Drawing.Point(176, 414);
            this.txt_externalAPI.MaxLength = 32767;
            this.txt_externalAPI.Name = "txt_externalAPI";
            this.txt_externalAPI.PasswordChar = '\0';
            this.txt_externalAPI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_externalAPI.SelectedText = "";
            this.txt_externalAPI.SelectionLength = 0;
            this.txt_externalAPI.SelectionStart = 0;
            this.txt_externalAPI.ShortcutsEnabled = true;
            this.txt_externalAPI.Size = new System.Drawing.Size(430, 23);
            this.txt_externalAPI.TabIndex = 74;
            this.txt_externalAPI.UseSelectable = true;
            this.txt_externalAPI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_externalAPI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 414);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(130, 19);
            this.metroLabel8.TabIndex = 73;
            this.metroLabel8.Text = "External API Address";
            // 
            // btn_downloadSettings
            // 
            this.btn_downloadSettings.BackColor = System.Drawing.Color.DimGray;
            this.btn_downloadSettings.Enabled = false;
            this.btn_downloadSettings.ForeColor = System.Drawing.Color.White;
            this.btn_downloadSettings.Location = new System.Drawing.Point(15, 489);
            this.btn_downloadSettings.Name = "btn_downloadSettings";
            this.btn_downloadSettings.Size = new System.Drawing.Size(127, 28);
            this.btn_downloadSettings.TabIndex = 2;
            this.btn_downloadSettings.Text = "Get App Configuration";
            this.btn_downloadSettings.UseCustomBackColor = true;
            this.btn_downloadSettings.UseCustomForeColor = true;
            this.btn_downloadSettings.UseSelectable = true;
            this.btn_downloadSettings.Visible = false;
            this.btn_downloadSettings.Click += new System.EventHandler(this.btn_downloadSettings_Click);
            // 
            // pix_webSetting
            // 
            this.pix_webSetting.Image = ((System.Drawing.Image)(resources.GetObject("pix_webSetting.Image")));
            this.pix_webSetting.Location = new System.Drawing.Point(428, 520);
            this.pix_webSetting.Name = "pix_webSetting";
            this.pix_webSetting.Size = new System.Drawing.Size(212, 19);
            this.pix_webSetting.TabIndex = 75;
            this.pix_webSetting.TabStop = false;
            this.pix_webSetting.Visible = false;
            // 
            // btn_getImageFolder
            // 
            this.btn_getImageFolder.Location = new System.Drawing.Point(612, 443);
            this.btn_getImageFolder.Name = "btn_getImageFolder";
            this.btn_getImageFolder.Size = new System.Drawing.Size(34, 19);
            this.btn_getImageFolder.TabIndex = 78;
            this.btn_getImageFolder.Text = "---";
            this.btn_getImageFolder.UseSelectable = true;
            this.btn_getImageFolder.Click += new System.EventHandler(this.btn_getImageFolder_Click);
            // 
            // txt_imagefolder
            // 
            // 
            // 
            // 
            this.txt_imagefolder.CustomButton.Image = null;
            this.txt_imagefolder.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.txt_imagefolder.CustomButton.Name = "";
            this.txt_imagefolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_imagefolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_imagefolder.CustomButton.TabIndex = 1;
            this.txt_imagefolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_imagefolder.CustomButton.UseSelectable = true;
            this.txt_imagefolder.CustomButton.Visible = false;
            this.txt_imagefolder.Lines = new string[0];
            this.txt_imagefolder.Location = new System.Drawing.Point(176, 443);
            this.txt_imagefolder.MaxLength = 32767;
            this.txt_imagefolder.Name = "txt_imagefolder";
            this.txt_imagefolder.PasswordChar = '\0';
            this.txt_imagefolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_imagefolder.SelectedText = "";
            this.txt_imagefolder.SelectionLength = 0;
            this.txt_imagefolder.SelectionStart = 0;
            this.txt_imagefolder.ShortcutsEnabled = true;
            this.txt_imagefolder.Size = new System.Drawing.Size(430, 23);
            this.txt_imagefolder.TabIndex = 77;
            this.txt_imagefolder.UseSelectable = true;
            this.txt_imagefolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_imagefolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(70, 443);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(88, 19);
            this.metroLabel12.TabIndex = 76;
            this.metroLabel12.Text = "Image Folder";
            // 
            // btn_DBConnection
            // 
            this.btn_DBConnection.BackColor = System.Drawing.Color.DimGray;
            this.btn_DBConnection.ForeColor = System.Drawing.Color.White;
            this.btn_DBConnection.Location = new System.Drawing.Point(428, 483);
            this.btn_DBConnection.Name = "btn_DBConnection";
            this.btn_DBConnection.Size = new System.Drawing.Size(135, 28);
            this.btn_DBConnection.TabIndex = 79;
            this.btn_DBConnection.Text = "Save DB Connection";
            this.btn_DBConnection.UseCustomBackColor = true;
            this.btn_DBConnection.UseCustomForeColor = true;
            this.btn_DBConnection.UseSelectable = true;
            this.btn_DBConnection.Click += new System.EventHandler(this.btn_DBConnection_Click);
            // 
            // btn_Getsettings
            // 
            this.btn_Getsettings.BackColor = System.Drawing.Color.Teal;
            this.btn_Getsettings.ForeColor = System.Drawing.Color.White;
            this.btn_Getsettings.Location = new System.Drawing.Point(264, 483);
            this.btn_Getsettings.Name = "btn_Getsettings";
            this.btn_Getsettings.Size = new System.Drawing.Size(150, 28);
            this.btn_Getsettings.TabIndex = 83;
            this.btn_Getsettings.Text = "Get App Configuration";
            this.btn_Getsettings.UseCustomBackColor = true;
            this.btn_Getsettings.UseCustomForeColor = true;
            this.btn_Getsettings.UseSelectable = true;
            this.btn_Getsettings.Click += new System.EventHandler(this.btn_Getsettings_Click);
            // 
            // AvayaDBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 550);
            this.Controls.Add(this.btn_Getsettings);
            this.Controls.Add(this.btn_DBConnection);
            this.Controls.Add(this.btn_getImageFolder);
            this.Controls.Add(this.txt_imagefolder);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.pix_webSetting);
            this.Controls.Add(this.txt_externalAPI);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lb_templateFormat);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_NIBBSAddr);
            this.Controls.Add(this.cb_templateFormat);
            this.Controls.Add(this.cb_branch);
            this.Controls.Add(this.btn_downloadSettings);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.camToggle1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "AvayaDBSettings";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Configure Application Connection Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AvayaDBSettings_FormClosing);
            this.Load += new System.EventHandler(this.AvayaDBSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscWithParamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_webSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.ComboBox cb_datasource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cb_initialcatalog;
        private System.Windows.Forms.TextBox txt_connection;
        private System.Windows.Forms.BindingSource miscWithParamBindingSource;
        private MetroFramework.Controls.MetroToggle camToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroButton btn_NIBBSAddr;
        private MetroFramework.Controls.MetroButton btn_close;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_pwd;
        private MetroFramework.Controls.MetroButton btn_DBRefresh;
        private MetroFramework.Controls.MetroButton btn_refreshServer;
        private MetroFramework.Controls.MetroButton btn_connection;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cb_branch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cb_templateFormat;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lb_templateFormat;
        private MetroFramework.Controls.MetroTextBox txt_externalAPI;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btn_downloadSettings;
        private System.Windows.Forms.PictureBox pix_webSetting;
        private MetroFramework.Controls.MetroButton btn_testConnection;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_serverSource;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_serverAddress;
        private System.Windows.Forms.CheckBox ch_useDirect;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_userID;
        private MetroFramework.Controls.MetroButton btn_getImageFolder;
        private MetroFramework.Controls.MetroTextBox txt_imagefolder;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btn_DBConnection;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private MetroFramework.Controls.MetroButton btn_Getsettings;
    }
}