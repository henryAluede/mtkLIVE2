namespace DermalogMultiScannerDemo.winforms
{
    partial class Form_data
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_data));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_confirmationCode = new MetroFramework.Controls.MetroLabel();
            this.lb_verifiedStatus = new MetroFramework.Controls.MetroLabel();
            this.lb_status = new MetroFramework.Controls.MetroLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_createDT = new MetroFramework.Controls.MetroLabel();
            this.lb_accountType = new MetroFramework.Controls.MetroLabel();
            this.lb_profession = new MetroFramework.Controls.MetroLabel();
            this.lb_phone = new MetroFramework.Controls.MetroLabel();
            this.lb_gender = new MetroFramework.Controls.MetroLabel();
            this.lb_DOB = new MetroFramework.Controls.MetroLabel();
            this.lb_email = new MetroFramework.Controls.MetroLabel();
            this.lb_state = new MetroFramework.Controls.MetroLabel();
            this.lb_country = new MetroFramework.Controls.MetroLabel();
            this.lb_lastname = new MetroFramework.Controls.MetroLabel();
            this.lb_username = new MetroFramework.Controls.MetroLabel();
            this.lb_firstname = new MetroFramework.Controls.MetroLabel();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pixBarcode = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pix_client = new System.Windows.Forms.PictureBox();
            this.btnCLose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pix_login = new System.Windows.Forms.PictureBox();
            this.btn_getData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pix_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCards1);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(20, 60);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(466, 516);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lb_confirmationCode);
            this.bunifuCards1.Controls.Add(this.lb_verifiedStatus);
            this.bunifuCards1.Controls.Add(this.lb_status);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.lb_createDT);
            this.bunifuCards1.Controls.Add(this.lb_accountType);
            this.bunifuCards1.Controls.Add(this.lb_profession);
            this.bunifuCards1.Controls.Add(this.lb_phone);
            this.bunifuCards1.Controls.Add(this.lb_gender);
            this.bunifuCards1.Controls.Add(this.lb_DOB);
            this.bunifuCards1.Controls.Add(this.lb_email);
            this.bunifuCards1.Controls.Add(this.lb_state);
            this.bunifuCards1.Controls.Add(this.lb_country);
            this.bunifuCards1.Controls.Add(this.lb_lastname);
            this.bunifuCards1.Controls.Add(this.lb_username);
            this.bunifuCards1.Controls.Add(this.lb_firstname);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel21);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel20);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel13);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel17);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel18);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel19);
            this.bunifuCards1.Controls.Add(this.pixBarcode);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition1.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(462, 512);
            this.bunifuCards1.TabIndex = 36;
            // 
            // lb_confirmationCode
            // 
            this.lb_confirmationCode.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_confirmationCode, BunifuAnimatorNS.DecorationType.None);
            this.lb_confirmationCode.Location = new System.Drawing.Point(116, 480);
            this.lb_confirmationCode.Name = "lb_confirmationCode";
            this.lb_confirmationCode.Size = new System.Drawing.Size(81, 19);
            this.lb_confirmationCode.TabIndex = 62;
            this.lb_confirmationCode.Text = "metroLabel1";
            // 
            // lb_verifiedStatus
            // 
            this.lb_verifiedStatus.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_verifiedStatus, BunifuAnimatorNS.DecorationType.None);
            this.lb_verifiedStatus.Location = new System.Drawing.Point(116, 408);
            this.lb_verifiedStatus.Name = "lb_verifiedStatus";
            this.lb_verifiedStatus.Size = new System.Drawing.Size(81, 19);
            this.lb_verifiedStatus.TabIndex = 61;
            this.lb_verifiedStatus.Text = "metroLabel1";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_status, BunifuAnimatorNS.DecorationType.None);
            this.lb_status.Location = new System.Drawing.Point(116, 379);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(81, 19);
            this.lb_status.TabIndex = 60;
            this.lb_status.Text = "metroLabel1";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(22, 414);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(76, 13);
            this.bunifuCustomLabel8.TabIndex = 59;
            this.bunifuCustomLabel8.Text = "Verified_status";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(22, 385);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel9.TabIndex = 58;
            this.bunifuCustomLabel9.Text = "Status";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 37);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "User Name";
            // 
            // lb_createDT
            // 
            this.lb_createDT.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_createDT, BunifuAnimatorNS.DecorationType.None);
            this.lb_createDT.Location = new System.Drawing.Point(116, 350);
            this.lb_createDT.Name = "lb_createDT";
            this.lb_createDT.Size = new System.Drawing.Size(81, 19);
            this.lb_createDT.TabIndex = 57;
            this.lb_createDT.Text = "metroLabel1";
            // 
            // lb_accountType
            // 
            this.lb_accountType.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_accountType, BunifuAnimatorNS.DecorationType.None);
            this.lb_accountType.Location = new System.Drawing.Point(116, 292);
            this.lb_accountType.Name = "lb_accountType";
            this.lb_accountType.Size = new System.Drawing.Size(81, 19);
            this.lb_accountType.TabIndex = 55;
            this.lb_accountType.Text = "metroLabel1";
            // 
            // lb_profession
            // 
            this.lb_profession.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_profession, BunifuAnimatorNS.DecorationType.None);
            this.lb_profession.Location = new System.Drawing.Point(116, 321);
            this.lb_profession.Name = "lb_profession";
            this.lb_profession.Size = new System.Drawing.Size(81, 19);
            this.lb_profession.TabIndex = 56;
            this.lb_profession.Text = "metroLabel1";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_phone, BunifuAnimatorNS.DecorationType.None);
            this.lb_phone.Location = new System.Drawing.Point(116, 263);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(81, 19);
            this.lb_phone.TabIndex = 54;
            this.lb_phone.Text = "metroLabel1";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_gender, BunifuAnimatorNS.DecorationType.None);
            this.lb_gender.Location = new System.Drawing.Point(116, 205);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(81, 19);
            this.lb_gender.TabIndex = 52;
            this.lb_gender.Text = "metroLabel1";
            // 
            // lb_DOB
            // 
            this.lb_DOB.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_DOB, BunifuAnimatorNS.DecorationType.None);
            this.lb_DOB.Location = new System.Drawing.Point(116, 234);
            this.lb_DOB.Name = "lb_DOB";
            this.lb_DOB.Size = new System.Drawing.Size(81, 19);
            this.lb_DOB.TabIndex = 53;
            this.lb_DOB.Text = "metroLabel1";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_email, BunifuAnimatorNS.DecorationType.None);
            this.lb_email.Location = new System.Drawing.Point(116, 176);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(81, 19);
            this.lb_email.TabIndex = 51;
            this.lb_email.Text = "metroLabel1";
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_state, BunifuAnimatorNS.DecorationType.None);
            this.lb_state.Location = new System.Drawing.Point(116, 118);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(81, 19);
            this.lb_state.TabIndex = 49;
            this.lb_state.Text = "metroLabel1";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_country, BunifuAnimatorNS.DecorationType.None);
            this.lb_country.Location = new System.Drawing.Point(116, 147);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(81, 19);
            this.lb_country.TabIndex = 50;
            this.lb_country.Text = "metroLabel1";
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_lastname, BunifuAnimatorNS.DecorationType.None);
            this.lb_lastname.Location = new System.Drawing.Point(116, 89);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(81, 19);
            this.lb_lastname.TabIndex = 48;
            this.lb_lastname.Text = "metroLabel1";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_username, BunifuAnimatorNS.DecorationType.None);
            this.lb_username.Location = new System.Drawing.Point(116, 31);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(81, 19);
            this.lb_username.TabIndex = 47;
            this.lb_username.Text = "metroLabel1";
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_firstname, BunifuAnimatorNS.DecorationType.None);
            this.lb_firstname.Location = new System.Drawing.Point(116, 60);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(81, 19);
            this.lb_firstname.TabIndex = 47;
            this.lb_firstname.Text = "metroLabel1";
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(22, 356);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(61, 13);
            this.bunifuCustomLabel21.TabIndex = 44;
            this.bunifuCustomLabel21.Text = "Created On";
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel20, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(22, 327);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel20.TabIndex = 42;
            this.bunifuCustomLabel20.Text = "Profession";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(22, 240);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(68, 13);
            this.bunifuCustomLabel13.TabIndex = 0;
            this.bunifuCustomLabel13.Text = "Date Of Birth";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(22, 211);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel7.TabIndex = 0;
            this.bunifuCustomLabel7.Text = "Gender";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(22, 182);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(32, 13);
            this.bunifuCustomLabel6.TabIndex = 0;
            this.bunifuCustomLabel6.Text = "Email";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 153);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "Nationality";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 95);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(58, 13);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Last Name";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(22, 124);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(32, 13);
            this.bunifuCustomLabel17.TabIndex = 36;
            this.bunifuCustomLabel17.Text = "State";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(22, 66);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "First Name";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(22, 298);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(74, 13);
            this.bunifuCustomLabel18.TabIndex = 37;
            this.bunifuCustomLabel18.Text = "Account Type";
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(22, 269);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel19.TabIndex = 38;
            this.bunifuCustomLabel19.Text = "Phone";
            // 
            // pixBarcode
            // 
            this.pixBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.pixBarcode, BunifuAnimatorNS.DecorationType.None);
            this.pixBarcode.Location = new System.Drawing.Point(121, 441);
            this.pixBarcode.Name = "pixBarcode";
            this.pixBarcode.Size = new System.Drawing.Size(261, 35);
            this.pixBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixBarcode.TabIndex = 35;
            this.pixBarcode.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 448);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Confirmation Code";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.Pix_client;
            // 
            // Pix_client
            // 
            this.Pix_client.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuTransition1.SetDecoration(this.Pix_client, BunifuAnimatorNS.DecorationType.None);
            this.Pix_client.Location = new System.Drawing.Point(503, 60);
            this.Pix_client.Name = "Pix_client";
            this.Pix_client.Size = new System.Drawing.Size(268, 301);
            this.Pix_client.TabIndex = 1;
            this.Pix_client.TabStop = false;
            // 
            // btnCLose
            // 
            this.btnCLose.Active = false;
            this.btnCLose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCLose.BackColor = System.Drawing.Color.Maroon;
            this.btnCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCLose.BorderRadius = 0;
            this.btnCLose.ButtonText = "Close Window";
            this.btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCLose, BunifuAnimatorNS.DecorationType.None);
            this.btnCLose.DisabledColor = System.Drawing.Color.Gray;
            this.btnCLose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCLose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCLose.Iconimage")));
            this.btnCLose.Iconimage_right = null;
            this.btnCLose.Iconimage_right_Selected = null;
            this.btnCLose.Iconimage_Selected = null;
            this.btnCLose.IconMarginLeft = 0;
            this.btnCLose.IconMarginRight = 0;
            this.btnCLose.IconRightVisible = true;
            this.btnCLose.IconRightZoom = 0D;
            this.btnCLose.IconVisible = true;
            this.btnCLose.IconZoom = 90D;
            this.btnCLose.IsTab = false;
            this.btnCLose.Location = new System.Drawing.Point(766, 549);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Normalcolor = System.Drawing.Color.Maroon;
            this.btnCLose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCLose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCLose.selected = false;
            this.btnCLose.Size = new System.Drawing.Size(148, 36);
            this.btnCLose.TabIndex = 2;
            this.btnCLose.Text = "Close Window";
            this.btnCLose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLose.Textcolor = System.Drawing.Color.White;
            this.btnCLose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btn_save
            // 
            this.btn_save.Active = false;
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "Save Client Data";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_save, BunifuAnimatorNS.DecorationType.None);
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(753, 508);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(161, 36);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save Client Data";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pix_login
            // 
            this.bunifuTransition1.SetDecoration(this.pix_login, BunifuAnimatorNS.DecorationType.None);
            this.pix_login.Image = ((System.Drawing.Image)(resources.GetObject("pix_login.Image")));
            this.pix_login.Location = new System.Drawing.Point(730, 385);
            this.pix_login.Name = "pix_login";
            this.pix_login.Size = new System.Drawing.Size(184, 19);
            this.pix_login.TabIndex = 38;
            this.pix_login.TabStop = false;
            this.pix_login.Visible = false;
            // 
            // btn_getData
            // 
            this.btn_getData.Active = false;
            this.btn_getData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_getData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_getData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_getData.BorderRadius = 0;
            this.btn_getData.ButtonText = "Generate VCard";
            this.btn_getData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_getData, BunifuAnimatorNS.DecorationType.None);
            this.btn_getData.DisabledColor = System.Drawing.Color.Gray;
            this.btn_getData.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_getData.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_getData.Iconimage")));
            this.btn_getData.Iconimage_right = null;
            this.btn_getData.Iconimage_right_Selected = null;
            this.btn_getData.Iconimage_Selected = null;
            this.btn_getData.IconMarginLeft = 0;
            this.btn_getData.IconMarginRight = 0;
            this.btn_getData.IconRightVisible = true;
            this.btn_getData.IconRightZoom = 0D;
            this.btn_getData.IconVisible = true;
            this.btn_getData.IconZoom = 90D;
            this.btn_getData.IsTab = false;
            this.btn_getData.Location = new System.Drawing.Point(730, 466);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_getData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_getData.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_getData.selected = false;
            this.btn_getData.Size = new System.Drawing.Size(184, 36);
            this.btn_getData.TabIndex = 2;
            this.btn_getData.Text = "Generate VCard";
            this.btn_getData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_getData.Textcolor = System.Drawing.Color.White;
            this.btn_getData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getData.Visible = false;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(503, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Form_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(921, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pix_login);
            this.Controls.Add(this.btn_getData);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.Pix_client);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_data";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Personal Data";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_data_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pix_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox Pix_client;
        private Bunifu.Framework.UI.BunifuFlatButton btnCLose;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private System.Windows.Forms.PictureBox pix_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_getData;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private System.Windows.Forms.PictureBox pixBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private MetroFramework.Controls.MetroLabel lb_lastname;
        private MetroFramework.Controls.MetroLabel lb_firstname;
        private MetroFramework.Controls.MetroLabel lb_username;
        private MetroFramework.Controls.MetroLabel lb_confirmationCode;
        private MetroFramework.Controls.MetroLabel lb_verifiedStatus;
        private MetroFramework.Controls.MetroLabel lb_status;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private MetroFramework.Controls.MetroLabel lb_createDT;
        private MetroFramework.Controls.MetroLabel lb_accountType;
        private MetroFramework.Controls.MetroLabel lb_profession;
        private MetroFramework.Controls.MetroLabel lb_phone;
        private MetroFramework.Controls.MetroLabel lb_gender;
        private MetroFramework.Controls.MetroLabel lb_DOB;
        private MetroFramework.Controls.MetroLabel lb_email;
        private MetroFramework.Controls.MetroLabel lb_state;
        private MetroFramework.Controls.MetroLabel lb_country;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}