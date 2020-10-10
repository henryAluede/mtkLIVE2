namespace DermalogMultiScannerDemo
{
    partial class userAdmin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAdmin2));
            this.btn_regiter = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_PWD = new MetroFramework.Controls.MetroTextBox();
            this.cbo_userName = new MetroFramework.Controls.MetroTextBox();
            this.BWWorker_Login = new System.ComponentModel.BackgroundWorker();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_changePwd = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_token = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pix_login = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_pwd1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_Pwd2 = new MetroFramework.Controls.MetroTextBox();
            this.gb_changepassword = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gb_changepassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regiter
            // 
            this.btn_regiter.BackColor = System.Drawing.SystemColors.Window;
            this.btn_regiter.Enabled = false;
            this.btn_regiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_regiter.Location = new System.Drawing.Point(210, 135);
            this.btn_regiter.Name = "btn_regiter";
            this.btn_regiter.Size = new System.Drawing.Size(89, 28);
            this.btn_regiter.TabIndex = 3;
            this.btn_regiter.Text = "Sign Up";
            this.btn_regiter.UseVisualStyleBackColor = false;
            this.btn_regiter.Click += new System.EventHandler(this.btn_regiter_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel2.Location = new System.Drawing.Point(16, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "User Password";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel1.Location = new System.Drawing.Point(53, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Login ID";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_PWD
            // 
            this.txt_PWD.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_PWD.CustomButton.Image = null;
            this.txt_PWD.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txt_PWD.CustomButton.Name = "";
            this.txt_PWD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PWD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PWD.CustomButton.TabIndex = 1;
            this.txt_PWD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PWD.CustomButton.UseSelectable = true;
            this.txt_PWD.CustomButton.Visible = false;
            this.txt_PWD.ForeColor = System.Drawing.Color.Black;
            this.txt_PWD.Lines = new string[0];
            this.txt_PWD.Location = new System.Drawing.Point(116, 106);
            this.txt_PWD.MaxLength = 32767;
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.PasswordChar = '*';
            this.txt_PWD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PWD.SelectedText = "";
            this.txt_PWD.SelectionLength = 0;
            this.txt_PWD.SelectionStart = 0;
            this.txt_PWD.ShortcutsEnabled = true;
            this.txt_PWD.Size = new System.Drawing.Size(224, 23);
            this.txt_PWD.TabIndex = 1;
            this.txt_PWD.UseCustomBackColor = true;
            this.txt_PWD.UseCustomForeColor = true;
            this.txt_PWD.UseSelectable = true;
            this.txt_PWD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PWD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbo_userName
            // 
            this.cbo_userName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbo_userName.CustomButton.Image = null;
            this.cbo_userName.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.cbo_userName.CustomButton.Name = "";
            this.cbo_userName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cbo_userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_userName.CustomButton.TabIndex = 1;
            this.cbo_userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbo_userName.CustomButton.UseSelectable = true;
            this.cbo_userName.CustomButton.Visible = false;
            this.cbo_userName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.cbo_userName.ForeColor = System.Drawing.Color.Black;
            this.cbo_userName.Lines = new string[0];
            this.cbo_userName.Location = new System.Drawing.Point(116, 77);
            this.cbo_userName.MaxLength = 32767;
            this.cbo_userName.Name = "cbo_userName";
            this.cbo_userName.PasswordChar = '\0';
            this.cbo_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cbo_userName.SelectedText = "";
            this.cbo_userName.SelectionLength = 0;
            this.cbo_userName.SelectionStart = 0;
            this.cbo_userName.ShortcutsEnabled = true;
            this.cbo_userName.Size = new System.Drawing.Size(224, 23);
            this.cbo_userName.TabIndex = 0;
            this.cbo_userName.UseCustomBackColor = true;
            this.cbo_userName.UseCustomForeColor = true;
            this.cbo_userName.UseSelectable = true;
            this.cbo_userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbo_userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cbo_userName.Enter += new System.EventHandler(this.cbo_userName_Enter);
            this.cbo_userName.Leave += new System.EventHandler(this.cbo_userName_Leave);
            // 
            // BWWorker_Login
            // 
            this.BWWorker_Login.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWWorker_Login_DoWork);
            this.BWWorker_Login.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWWorker_Login_RunWorkerCompleted);
            // 
            // btn_connection
            // 
            this.btn_connection.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connection.ForeColor = System.Drawing.Color.White;
            this.btn_connection.Location = new System.Drawing.Point(368, 355);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(143, 28);
            this.btn_connection.TabIndex = 5;
            this.btn_connection.Text = "Setup Connection";
            this.btn_connection.UseVisualStyleBackColor = false;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(115, 135);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(88, 28);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login ";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(517, 355);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(135, 28);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close Application";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_changePwd
            // 
            this.btn_changePwd.BackColor = System.Drawing.SystemColors.Window;
            this.btn_changePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_changePwd.Location = new System.Drawing.Point(5, 355);
            this.btn_changePwd.Name = "btn_changePwd";
            this.btn_changePwd.Size = new System.Drawing.Size(135, 28);
            this.btn_changePwd.TabIndex = 6;
            this.btn_changePwd.Text = "Change Password";
            this.btn_changePwd.UseVisualStyleBackColor = false;
            this.btn_changePwd.Click += new System.EventHandler(this.Btn_changePwd_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Window;
            this.btn_reset.Enabled = false;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btn_reset.Location = new System.Drawing.Point(146, 355);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(135, 28);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset Password";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // txt_token
            // 
            this.txt_token.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_token.CustomButton.Image = null;
            this.txt_token.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txt_token.CustomButton.Name = "";
            this.txt_token.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_token.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_token.CustomButton.TabIndex = 1;
            this.txt_token.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_token.CustomButton.UseSelectable = true;
            this.txt_token.CustomButton.Visible = false;
            this.txt_token.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_token.ForeColor = System.Drawing.Color.Black;
            this.txt_token.Lines = new string[0];
            this.txt_token.Location = new System.Drawing.Point(115, 194);
            this.txt_token.MaxLength = 32767;
            this.txt_token.Name = "txt_token";
            this.txt_token.PasswordChar = '\0';
            this.txt_token.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_token.SelectedText = "";
            this.txt_token.SelectionLength = 0;
            this.txt_token.SelectionStart = 0;
            this.txt_token.ShortcutsEnabled = true;
            this.txt_token.Size = new System.Drawing.Size(183, 23);
            this.txt_token.TabIndex = 4;
            this.txt_token.UseCustomBackColor = true;
            this.txt_token.UseCustomForeColor = true;
            this.txt_token.UseSelectable = true;
            this.txt_token.Visible = false;
            this.txt_token.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_token.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel3.Location = new System.Drawing.Point(68, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Token";
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pix_login
            // 
            this.pix_login.Image = ((System.Drawing.Image)(resources.GetObject("pix_login.Image")));
            this.pix_login.Location = new System.Drawing.Point(115, 169);
            this.pix_login.Name = "pix_login";
            this.pix_login.Size = new System.Drawing.Size(184, 19);
            this.pix_login.TabIndex = 37;
            this.pix_login.TabStop = false;
            this.pix_login.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 182);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(115, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(213, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // txt_pwd1
            // 
            this.txt_pwd1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pwd1.CustomButton.Image = null;
            this.txt_pwd1.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txt_pwd1.CustomButton.Name = "";
            this.txt_pwd1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pwd1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pwd1.CustomButton.TabIndex = 1;
            this.txt_pwd1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pwd1.CustomButton.UseSelectable = true;
            this.txt_pwd1.CustomButton.Visible = false;
            this.txt_pwd1.ForeColor = System.Drawing.Color.Black;
            this.txt_pwd1.Lines = new string[0];
            this.txt_pwd1.Location = new System.Drawing.Point(123, 19);
            this.txt_pwd1.MaxLength = 32767;
            this.txt_pwd1.Name = "txt_pwd1";
            this.txt_pwd1.PasswordChar = '*';
            this.txt_pwd1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pwd1.SelectedText = "";
            this.txt_pwd1.SelectionLength = 0;
            this.txt_pwd1.SelectionStart = 0;
            this.txt_pwd1.ShortcutsEnabled = true;
            this.txt_pwd1.Size = new System.Drawing.Size(224, 23);
            this.txt_pwd1.TabIndex = 48;
            this.txt_pwd1.UseCustomBackColor = true;
            this.txt_pwd1.UseCustomForeColor = true;
            this.txt_pwd1.UseSelectable = true;
            this.txt_pwd1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pwd1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel4.Location = new System.Drawing.Point(24, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "New Password";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel5.Location = new System.Drawing.Point(11, 48);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 51;
            this.metroLabel5.Text = "Retype Password";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txt_Pwd2
            // 
            this.txt_Pwd2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Pwd2.CustomButton.Image = null;
            this.txt_Pwd2.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txt_Pwd2.CustomButton.Name = "";
            this.txt_Pwd2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Pwd2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pwd2.CustomButton.TabIndex = 1;
            this.txt_Pwd2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pwd2.CustomButton.UseSelectable = true;
            this.txt_Pwd2.CustomButton.Visible = false;
            this.txt_Pwd2.ForeColor = System.Drawing.Color.Black;
            this.txt_Pwd2.Lines = new string[0];
            this.txt_Pwd2.Location = new System.Drawing.Point(123, 48);
            this.txt_Pwd2.MaxLength = 32767;
            this.txt_Pwd2.Name = "txt_Pwd2";
            this.txt_Pwd2.PasswordChar = '*';
            this.txt_Pwd2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pwd2.SelectedText = "";
            this.txt_Pwd2.SelectionLength = 0;
            this.txt_Pwd2.SelectionStart = 0;
            this.txt_Pwd2.ShortcutsEnabled = true;
            this.txt_Pwd2.Size = new System.Drawing.Size(224, 23);
            this.txt_Pwd2.TabIndex = 50;
            this.txt_Pwd2.UseCustomBackColor = true;
            this.txt_Pwd2.UseCustomForeColor = true;
            this.txt_Pwd2.UseSelectable = true;
            this.txt_Pwd2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pwd2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gb_changepassword
            // 
            this.gb_changepassword.Controls.Add(this.txt_pwd1);
            this.gb_changepassword.Controls.Add(this.metroLabel5);
            this.gb_changepassword.Controls.Add(this.metroLabel4);
            this.gb_changepassword.Controls.Add(this.txt_Pwd2);
            this.gb_changepassword.Location = new System.Drawing.Point(5, 265);
            this.gb_changepassword.Name = "gb_changepassword";
            this.gb_changepassword.Size = new System.Drawing.Size(359, 84);
            this.gb_changepassword.TabIndex = 52;
            this.gb_changepassword.TabStop = false;
            this.gb_changepassword.Visible = false;
            // 
            // userAdmin2
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DermalogMultiScannerDemo.Properties.Resources.f2;
            this.BackImage = global::DermalogMultiScannerDemo.Properties.Resources.f2;
            this.ClientSize = new System.Drawing.Size(661, 392);
            this.Controls.Add(this.gb_changepassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_changePwd);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_regiter);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.txt_PWD);
            this.Controls.Add(this.cbo_userName);
            this.Controls.Add(this.pix_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "userAdmin2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "InfoMetriQ Biometric Verification System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAdmin2_FormClosing);
            this.Load += new System.EventHandler(this.userAdmin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gb_changepassword.ResumeLayout(false);
            this.gb_changepassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_regiter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_PWD;
        private MetroFramework.Controls.MetroTextBox cbo_userName;
        private System.Windows.Forms.PictureBox pix_login;
        private System.ComponentModel.BackgroundWorker BWWorker_Login;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_changePwd;
        private System.Windows.Forms.Button btn_reset;
        private MetroFramework.Controls.MetroTextBox txt_token;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox gb_changepassword;
        private MetroFramework.Controls.MetroTextBox txt_pwd1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_Pwd2;
    }
}