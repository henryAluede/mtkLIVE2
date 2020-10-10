namespace DermalogMultiScannerDemo
{
    partial class VerifyWindow
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
                 //this.Dispose(disposing);
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyWindow));
            this.xamlLabelUsername = new System.Windows.Forms.Label();
            this.stackPanelFingerprints = new System.Windows.Forms.FlowLayoutPanel();
            this.xamlLabelMessage = new System.Windows.Forms.Label();
            this.fPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageOnScannerDetect = new System.Windows.Forms.PictureBox();
            this.chk_left = new System.Windows.Forms.CheckBox();
            this.chk_right = new System.Windows.Forms.CheckBox();
            this.chk_thumb = new System.Windows.Forms.CheckBox();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.fp_thumb = new System.Windows.Forms.FlowLayoutPanel();
            this.fp_right = new System.Windows.Forms.FlowLayoutPanel();
            this.fp_left = new System.Windows.Forms.FlowLayoutPanel();
            this.tPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pic_Webcam = new System.Windows.Forms.PictureBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pix_login = new System.Windows.Forms.PictureBox();
            this.btn_newEnroll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCapture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_updatePIC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.xamlButtonEnroll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bn_identify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BGWorker_LeftSearch = new System.ComponentModel.BackgroundWorker();
            this.lb_match = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.xamlImageOnScannerImage = new System.Windows.Forms.PictureBox();
            this.CircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pixBarcode = new System.Windows.Forms.PictureBox();
            this.btn_thump = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_right = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_left = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_log = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lb_loginuser = new System.Windows.Forms.Label();
            this.btn_capturefoto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_clientName = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.txt_selectedUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BGWorker_rightSearch = new System.ComponentModel.BackgroundWorker();
            this.BGWorker_thumbSearch = new System.ComponentModel.BackgroundWorker();
            this.fPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnScannerDetect)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xamlLabelUsername
            // 
            this.xamlLabelUsername.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.xamlLabelUsername, BunifuAnimatorNS.DecorationType.None);
            this.xamlLabelUsername.Location = new System.Drawing.Point(314, 80);
            this.xamlLabelUsername.Name = "xamlLabelUsername";
            this.xamlLabelUsername.Size = new System.Drawing.Size(35, 13);
            this.xamlLabelUsername.TabIndex = 1;
            this.xamlLabelUsername.Text = "label1";
            this.xamlLabelUsername.Visible = false;
            // 
            // stackPanelFingerprints
            // 
            this.bunifuTransition1.SetDecoration(this.stackPanelFingerprints, BunifuAnimatorNS.DecorationType.None);
            this.stackPanelFingerprints.Location = new System.Drawing.Point(1069, 280);
            this.stackPanelFingerprints.Name = "stackPanelFingerprints";
            this.stackPanelFingerprints.Size = new System.Drawing.Size(68, 24);
            this.stackPanelFingerprints.TabIndex = 3;
            this.stackPanelFingerprints.Visible = false;
            // 
            // xamlLabelMessage
            // 
            this.xamlLabelMessage.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.xamlLabelMessage, BunifuAnimatorNS.DecorationType.None);
            this.xamlLabelMessage.Location = new System.Drawing.Point(314, 60);
            this.xamlLabelMessage.Name = "xamlLabelMessage";
            this.xamlLabelMessage.Size = new System.Drawing.Size(35, 13);
            this.xamlLabelMessage.TabIndex = 4;
            this.xamlLabelMessage.Text = "label1";
            this.xamlLabelMessage.Visible = false;
            // 
            // fPanel1
            // 
            this.fPanel1.Controls.Add(this.imageOnScannerDetect);
            this.bunifuTransition1.SetDecoration(this.fPanel1, BunifuAnimatorNS.DecorationType.None);
            this.fPanel1.Location = new System.Drawing.Point(1069, 310);
            this.fPanel1.Name = "fPanel1";
            this.fPanel1.Size = new System.Drawing.Size(76, 35);
            this.fPanel1.TabIndex = 15;
            this.fPanel1.Visible = false;
            // 
            // imageOnScannerDetect
            // 
            this.bunifuTransition1.SetDecoration(this.imageOnScannerDetect, BunifuAnimatorNS.DecorationType.None);
            this.imageOnScannerDetect.Location = new System.Drawing.Point(3, 3);
            this.imageOnScannerDetect.Name = "imageOnScannerDetect";
            this.imageOnScannerDetect.Size = new System.Drawing.Size(43, 44);
            this.imageOnScannerDetect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageOnScannerDetect.TabIndex = 3;
            this.imageOnScannerDetect.TabStop = false;
            this.imageOnScannerDetect.Visible = false;
            // 
            // chk_left
            // 
            this.chk_left.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.chk_left, BunifuAnimatorNS.DecorationType.None);
            this.chk_left.Location = new System.Drawing.Point(1038, 570);
            this.chk_left.Name = "chk_left";
            this.chk_left.Size = new System.Drawing.Size(15, 14);
            this.chk_left.TabIndex = 21;
            this.chk_left.UseVisualStyleBackColor = true;
            this.chk_left.CheckedChanged += new System.EventHandler(this.chk_left_CheckedChanged);
            // 
            // chk_right
            // 
            this.chk_right.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.chk_right, BunifuAnimatorNS.DecorationType.None);
            this.chk_right.Location = new System.Drawing.Point(260, 451);
            this.chk_right.Name = "chk_right";
            this.chk_right.Size = new System.Drawing.Size(15, 14);
            this.chk_right.TabIndex = 21;
            this.chk_right.UseVisualStyleBackColor = true;
            this.chk_right.Visible = false;
            this.chk_right.CheckedChanged += new System.EventHandler(this.chk_right_CheckedChanged);
            // 
            // chk_thumb
            // 
            this.chk_thumb.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.chk_thumb, BunifuAnimatorNS.DecorationType.None);
            this.chk_thumb.Location = new System.Drawing.Point(260, 490);
            this.chk_thumb.Name = "chk_thumb";
            this.chk_thumb.Size = new System.Drawing.Size(15, 14);
            this.chk_thumb.TabIndex = 21;
            this.chk_thumb.UseVisualStyleBackColor = true;
            this.chk_thumb.Visible = false;
            this.chk_thumb.CheckedChanged += new System.EventHandler(this.chk_thumb_CheckedChanged);
            // 
            // lst_msg
            // 
            this.bunifuTransition1.SetDecoration(this.lst_msg, BunifuAnimatorNS.DecorationType.None);
            this.lst_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.HorizontalScrollbar = true;
            this.lst_msg.Location = new System.Drawing.Point(0, 0);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.ScrollAlwaysVisible = true;
            this.lst_msg.Size = new System.Drawing.Size(393, 139);
            this.lst_msg.TabIndex = 0;
            // 
            // fp_thumb
            // 
            this.bunifuTransition1.SetDecoration(this.fp_thumb, BunifuAnimatorNS.DecorationType.None);
            this.fp_thumb.Location = new System.Drawing.Point(14, 307);
            this.fp_thumb.Name = "fp_thumb";
            this.fp_thumb.Size = new System.Drawing.Size(267, 132);
            this.fp_thumb.TabIndex = 15;
            // 
            // fp_right
            // 
            this.bunifuTransition1.SetDecoration(this.fp_right, BunifuAnimatorNS.DecorationType.None);
            this.fp_right.Location = new System.Drawing.Point(14, 160);
            this.fp_right.Name = "fp_right";
            this.fp_right.Size = new System.Drawing.Size(478, 132);
            this.fp_right.TabIndex = 15;
            // 
            // fp_left
            // 
            this.fp_left.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.fp_left, BunifuAnimatorNS.DecorationType.None);
            this.fp_left.Location = new System.Drawing.Point(14, 17);
            this.fp_left.Name = "fp_left";
            this.fp_left.Size = new System.Drawing.Size(478, 129);
            this.fp_left.TabIndex = 15;
            // 
            // tPanel1
            // 
            this.tPanel1.ColumnCount = 1;
            this.tPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bunifuTransition1.SetDecoration(this.tPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tPanel1.Location = new System.Drawing.Point(1143, 256);
            this.tPanel1.Name = "tPanel1";
            this.tPanel1.RowCount = 2;
            this.tPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPanel1.Size = new System.Drawing.Size(95, 89);
            this.tPanel1.TabIndex = 26;
            this.tPanel1.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 426);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(69, 13);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Select Finger";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.pic_Webcam);
            this.bunifuTransition1.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(823, 93);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(237, 225);
            this.bunifuCards1.TabIndex = 30;
            // 
            // pic_Webcam
            // 
            this.bunifuTransition1.SetDecoration(this.pic_Webcam, BunifuAnimatorNS.DecorationType.None);
            this.pic_Webcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Webcam.Location = new System.Drawing.Point(0, 0);
            this.pic_Webcam.Name = "pic_Webcam";
            this.pic_Webcam.Size = new System.Drawing.Size(237, 225);
            this.pic_Webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Webcam.TabIndex = 23;
            this.pic_Webcam.TabStop = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.pix_login);
            this.bunifuCards2.Controls.Add(this.fp_left);
            this.bunifuCards2.Controls.Add(this.fp_right);
            this.bunifuCards2.Controls.Add(this.fp_thumb);
            this.bunifuCards2.Controls.Add(this.btn_newEnroll);
            this.bunifuCards2.Controls.Add(this.btnCapture);
            this.bunifuCards2.Controls.Add(this.btn_updatePIC);
            this.bunifuTransition1.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(303, 96);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(505, 452);
            this.bunifuCards2.TabIndex = 33;
            // 
            // pix_login
            // 
            this.bunifuTransition1.SetDecoration(this.pix_login, BunifuAnimatorNS.DecorationType.None);
            this.pix_login.Image = ((System.Drawing.Image)(resources.GetObject("pix_login.Image")));
            this.pix_login.Location = new System.Drawing.Point(308, 424);
            this.pix_login.Name = "pix_login";
            this.pix_login.Size = new System.Drawing.Size(184, 19);
            this.pix_login.TabIndex = 38;
            this.pix_login.TabStop = false;
            this.pix_login.Visible = false;
            // 
            // btn_newEnroll
            // 
            this.btn_newEnroll.Active = false;
            this.btn_newEnroll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_newEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_newEnroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newEnroll.BorderRadius = 0;
            this.btn_newEnroll.ButtonText = "Add New Enrollment";
            this.btn_newEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_newEnroll, BunifuAnimatorNS.DecorationType.None);
            this.btn_newEnroll.DisabledColor = System.Drawing.Color.Gray;
            this.btn_newEnroll.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_newEnroll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_newEnroll.Iconimage")));
            this.btn_newEnroll.Iconimage_right = null;
            this.btn_newEnroll.Iconimage_right_Selected = null;
            this.btn_newEnroll.Iconimage_Selected = null;
            this.btn_newEnroll.IconMarginLeft = 0;
            this.btn_newEnroll.IconMarginRight = 0;
            this.btn_newEnroll.IconRightVisible = true;
            this.btn_newEnroll.IconRightZoom = 0D;
            this.btn_newEnroll.IconVisible = true;
            this.btn_newEnroll.IconZoom = 90D;
            this.btn_newEnroll.IsTab = false;
            this.btn_newEnroll.Location = new System.Drawing.Point(314, 346);
            this.btn_newEnroll.Name = "btn_newEnroll";
            this.btn_newEnroll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_newEnroll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_newEnroll.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_newEnroll.selected = false;
            this.btn_newEnroll.Size = new System.Drawing.Size(178, 33);
            this.btn_newEnroll.TabIndex = 28;
            this.btn_newEnroll.Text = "Add New Enrollment";
            this.btn_newEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newEnroll.Textcolor = System.Drawing.Color.White;
            this.btn_newEnroll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newEnroll.Visible = false;
            this.btn_newEnroll.Click += new System.EventHandler(this.btn_newEnroll_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Active = false;
            this.btnCapture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.BorderRadius = 0;
            this.btnCapture.ButtonText = "Start Webcam Capture";
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCapture, BunifuAnimatorNS.DecorationType.None);
            this.btnCapture.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapture.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCapture.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCapture.Iconimage")));
            this.btnCapture.Iconimage_right = null;
            this.btnCapture.Iconimage_right_Selected = null;
            this.btnCapture.Iconimage_Selected = null;
            this.btnCapture.IconMarginLeft = 0;
            this.btnCapture.IconMarginRight = 0;
            this.btnCapture.IconRightVisible = true;
            this.btnCapture.IconRightZoom = 0D;
            this.btnCapture.IconVisible = true;
            this.btnCapture.IconZoom = 90D;
            this.btnCapture.IsTab = false;
            this.btnCapture.Location = new System.Drawing.Point(300, 385);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCapture.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapture.selected = false;
            this.btnCapture.Size = new System.Drawing.Size(192, 33);
            this.btnCapture.TabIndex = 28;
            this.btnCapture.Text = "Start Webcam Capture";
            this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Textcolor = System.Drawing.Color.White;
            this.btnCapture.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Visible = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btn_updatePIC
            // 
            this.btn_updatePIC.Active = false;
            this.btn_updatePIC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_updatePIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_updatePIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_updatePIC.BorderRadius = 0;
            this.btn_updatePIC.ButtonText = "Update Picture";
            this.btn_updatePIC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_updatePIC, BunifuAnimatorNS.DecorationType.None);
            this.btn_updatePIC.DisabledColor = System.Drawing.Color.Gray;
            this.btn_updatePIC.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_updatePIC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_updatePIC.Iconimage")));
            this.btn_updatePIC.Iconimage_right = null;
            this.btn_updatePIC.Iconimage_right_Selected = null;
            this.btn_updatePIC.Iconimage_Selected = null;
            this.btn_updatePIC.IconMarginLeft = 0;
            this.btn_updatePIC.IconMarginRight = 0;
            this.btn_updatePIC.IconRightVisible = true;
            this.btn_updatePIC.IconRightZoom = 0D;
            this.btn_updatePIC.IconVisible = true;
            this.btn_updatePIC.IconZoom = 90D;
            this.btn_updatePIC.IsTab = false;
            this.btn_updatePIC.Location = new System.Drawing.Point(320, 312);
            this.btn_updatePIC.Name = "btn_updatePIC";
            this.btn_updatePIC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_updatePIC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_updatePIC.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_updatePIC.selected = false;
            this.btn_updatePIC.Size = new System.Drawing.Size(172, 33);
            this.btn_updatePIC.TabIndex = 28;
            this.btn_updatePIC.Text = "Update Picture";
            this.btn_updatePIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatePIC.Textcolor = System.Drawing.Color.White;
            this.btn_updatePIC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePIC.Visible = false;
            this.btn_updatePIC.Click += new System.EventHandler(this.btn_updatePIC_Click);
            // 
            // xamlButtonEnroll
            // 
            this.xamlButtonEnroll.Active = false;
            this.xamlButtonEnroll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonEnroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xamlButtonEnroll.BorderRadius = 0;
            this.xamlButtonEnroll.ButtonText = "Save Enrollment";
            this.xamlButtonEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.xamlButtonEnroll, BunifuAnimatorNS.DecorationType.None);
            this.xamlButtonEnroll.DisabledColor = System.Drawing.Color.Gray;
            this.xamlButtonEnroll.Enabled = false;
            this.xamlButtonEnroll.Iconcolor = System.Drawing.Color.Transparent;
            this.xamlButtonEnroll.Iconimage = ((System.Drawing.Image)(resources.GetObject("xamlButtonEnroll.Iconimage")));
            this.xamlButtonEnroll.Iconimage_right = null;
            this.xamlButtonEnroll.Iconimage_right_Selected = null;
            this.xamlButtonEnroll.Iconimage_Selected = null;
            this.xamlButtonEnroll.IconMarginLeft = 0;
            this.xamlButtonEnroll.IconMarginRight = 0;
            this.xamlButtonEnroll.IconRightVisible = true;
            this.xamlButtonEnroll.IconRightZoom = 0D;
            this.xamlButtonEnroll.IconVisible = true;
            this.xamlButtonEnroll.IconZoom = 90D;
            this.xamlButtonEnroll.IsTab = false;
            this.xamlButtonEnroll.Location = new System.Drawing.Point(459, 560);
            this.xamlButtonEnroll.Name = "xamlButtonEnroll";
            this.xamlButtonEnroll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonEnroll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xamlButtonEnroll.OnHoverTextColor = System.Drawing.Color.White;
            this.xamlButtonEnroll.selected = false;
            this.xamlButtonEnroll.Size = new System.Drawing.Size(61, 33);
            this.xamlButtonEnroll.TabIndex = 28;
            this.xamlButtonEnroll.Text = "Save Enrollment";
            this.xamlButtonEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xamlButtonEnroll.Textcolor = System.Drawing.Color.White;
            this.xamlButtonEnroll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xamlButtonEnroll.Visible = false;
            this.xamlButtonEnroll.Click += new System.EventHandler(this.xamlButtonEnroll_Click);
            // 
            // bn_identify
            // 
            this.bn_identify.Active = false;
            this.bn_identify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bn_identify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bn_identify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bn_identify.BorderRadius = 0;
            this.bn_identify.ButtonText = "Identify Fingerprint";
            this.bn_identify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bn_identify, BunifuAnimatorNS.DecorationType.None);
            this.bn_identify.DisabledColor = System.Drawing.Color.Gray;
            this.bn_identify.Iconcolor = System.Drawing.Color.Transparent;
            this.bn_identify.Iconimage = ((System.Drawing.Image)(resources.GetObject("bn_identify.Iconimage")));
            this.bn_identify.Iconimage_right = null;
            this.bn_identify.Iconimage_right_Selected = null;
            this.bn_identify.Iconimage_Selected = null;
            this.bn_identify.IconMarginLeft = 0;
            this.bn_identify.IconMarginRight = 0;
            this.bn_identify.IconRightVisible = true;
            this.bn_identify.IconRightZoom = 0D;
            this.bn_identify.IconVisible = true;
            this.bn_identify.IconZoom = 90D;
            this.bn_identify.IsTab = false;
            this.bn_identify.Location = new System.Drawing.Point(395, 560);
            this.bn_identify.Name = "bn_identify";
            this.bn_identify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bn_identify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bn_identify.OnHoverTextColor = System.Drawing.Color.White;
            this.bn_identify.selected = false;
            this.bn_identify.Size = new System.Drawing.Size(58, 33);
            this.bn_identify.TabIndex = 28;
            this.bn_identify.Text = "Identify Fingerprint";
            this.bn_identify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bn_identify.Textcolor = System.Drawing.Color.White;
            this.bn_identify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_identify.Visible = false;
            this.bn_identify.Click += new System.EventHandler(this.bn_identify_Click);
            // 
            // BGWorker_LeftSearch
            // 
            this.BGWorker_LeftSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_LeftSearch_DoWork);
            // 
            // lb_match
            // 
            this.lb_match.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_match, BunifuAnimatorNS.DecorationType.None);
            this.lb_match.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match.Location = new System.Drawing.Point(1066, 256);
            this.lb_match.Name = "lb_match";
            this.lb_match.Size = new System.Drawing.Size(171, 17);
            this.lb_match.TabIndex = 35;
            this.lb_match.Text = "Best User verified 0%)";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.xamlImageOnScannerImage);
            this.bunifuTransition1.SetDecoration(this.bunifuCards3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(17, 131);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(280, 292);
            this.bunifuCards3.TabIndex = 37;
            // 
            // xamlImageOnScannerImage
            // 
            this.xamlImageOnScannerImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.xamlImageOnScannerImage, BunifuAnimatorNS.DecorationType.None);
            this.xamlImageOnScannerImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xamlImageOnScannerImage.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
            this.xamlImageOnScannerImage.Location = new System.Drawing.Point(0, 0);
            this.xamlImageOnScannerImage.Name = "xamlImageOnScannerImage";
            this.xamlImageOnScannerImage.Size = new System.Drawing.Size(280, 292);
            this.xamlImageOnScannerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xamlImageOnScannerImage.TabIndex = 20;
            this.xamlImageOnScannerImage.TabStop = false;
            // 
            // CircleProgressbar1
            // 
            this.CircleProgressbar1.animated = false;
            this.CircleProgressbar1.animationIterval = 5;
            this.CircleProgressbar1.animationSpeed = 300;
            this.CircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.CircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressbar1.BackgroundImage")));
            this.bunifuTransition1.SetDecoration(this.CircleProgressbar1, BunifuAnimatorNS.DecorationType.None);
            this.CircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.CircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.CircleProgressbar1.LabelVisible = true;
            this.CircleProgressbar1.LineProgressThickness = 8;
            this.CircleProgressbar1.LineThickness = 5;
            this.CircleProgressbar1.Location = new System.Drawing.Point(1057, 83);
            this.CircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CircleProgressbar1.MaxValue = 100;
            this.CircleProgressbar1.Name = "CircleProgressbar1";
            this.CircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.CircleProgressbar1.Size = new System.Drawing.Size(164, 164);
            this.CircleProgressbar1.TabIndex = 36;
            this.CircleProgressbar1.Value = 0;
            // 
            // pixBarcode
            // 
            this.pixBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.pixBarcode, BunifuAnimatorNS.DecorationType.None);
            this.pixBarcode.Location = new System.Drawing.Point(14, 520);
            this.pixBarcode.Name = "pixBarcode";
            this.pixBarcode.Size = new System.Drawing.Size(280, 47);
            this.pixBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixBarcode.TabIndex = 34;
            this.pixBarcode.TabStop = false;
            // 
            // btn_thump
            // 
            this.btn_thump.Active = false;
            this.btn_thump.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_thump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_thump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thump.BorderRadius = 0;
            this.btn_thump.ButtonText = "Place both thumbs on Device";
            this.btn_thump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_thump, BunifuAnimatorNS.DecorationType.None);
            this.btn_thump.DisabledColor = System.Drawing.Color.Gray;
            this.btn_thump.Enabled = false;
            this.btn_thump.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_thump.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_thump.Iconimage")));
            this.btn_thump.Iconimage_right = null;
            this.btn_thump.Iconimage_right_Selected = null;
            this.btn_thump.Iconimage_Selected = null;
            this.btn_thump.IconMarginLeft = 0;
            this.btn_thump.IconMarginRight = 0;
            this.btn_thump.IconRightVisible = true;
            this.btn_thump.IconRightZoom = 0D;
            this.btn_thump.IconVisible = true;
            this.btn_thump.IconZoom = 90D;
            this.btn_thump.IsTab = false;
            this.btn_thump.Location = new System.Drawing.Point(14, 481);
            this.btn_thump.Name = "btn_thump";
            this.btn_thump.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_thump.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_thump.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_thump.selected = false;
            this.btn_thump.Size = new System.Drawing.Size(240, 33);
            this.btn_thump.TabIndex = 28;
            this.btn_thump.Text = "Place both thumbs on Device";
            this.btn_thump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thump.Textcolor = System.Drawing.Color.White;
            this.btn_thump.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thump.Visible = false;
            this.btn_thump.Click += new System.EventHandler(this.btn_thump_Click);
            // 
            // btn_right
            // 
            this.btn_right.Active = false;
            this.btn_right.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_right.BackColor = System.Drawing.Color.Navy;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_right.BorderRadius = 0;
            this.btn_right.ButtonText = "Place Right Fingers on Device";
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_right, BunifuAnimatorNS.DecorationType.None);
            this.btn_right.DisabledColor = System.Drawing.Color.Gray;
            this.btn_right.Enabled = false;
            this.btn_right.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_right.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_right.Iconimage")));
            this.btn_right.Iconimage_right = null;
            this.btn_right.Iconimage_right_Selected = null;
            this.btn_right.Iconimage_Selected = null;
            this.btn_right.IconMarginLeft = 0;
            this.btn_right.IconMarginRight = 0;
            this.btn_right.IconRightVisible = true;
            this.btn_right.IconRightZoom = 0D;
            this.btn_right.IconVisible = true;
            this.btn_right.IconZoom = 90D;
            this.btn_right.IsTab = false;
            this.btn_right.Location = new System.Drawing.Point(14, 442);
            this.btn_right.Name = "btn_right";
            this.btn_right.Normalcolor = System.Drawing.Color.Navy;
            this.btn_right.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_right.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_right.selected = false;
            this.btn_right.Size = new System.Drawing.Size(240, 33);
            this.btn_right.TabIndex = 28;
            this.btn_right.Text = "Place Right Fingers on Device";
            this.btn_right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_right.Textcolor = System.Drawing.Color.White;
            this.btn_right.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Visible = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Active = false;
            this.btn_left.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_left.BorderRadius = 0;
            this.btn_left.ButtonText = "Place Any Fingers on Device";
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_left, BunifuAnimatorNS.DecorationType.None);
            this.btn_left.DisabledColor = System.Drawing.Color.Gray;
            this.btn_left.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_left.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_left.Iconimage")));
            this.btn_left.Iconimage_right = null;
            this.btn_left.Iconimage_right_Selected = null;
            this.btn_left.Iconimage_Selected = null;
            this.btn_left.IconMarginLeft = 0;
            this.btn_left.IconMarginRight = 0;
            this.btn_left.IconRightVisible = true;
            this.btn_left.IconRightZoom = 0D;
            this.btn_left.IconVisible = true;
            this.btn_left.IconZoom = 90D;
            this.btn_left.IsTab = false;
            this.btn_left.Location = new System.Drawing.Point(792, 560);
            this.btn_left.Name = "btn_left";
            this.btn_left.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_left.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_left.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_left.selected = false;
            this.btn_left.Size = new System.Drawing.Size(240, 33);
            this.btn_left.TabIndex = 28;
            this.btn_left.Text = "Place Any Fingers on Device";
            this.btn_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_left.Textcolor = System.Drawing.Color.White;
            this.btn_left.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_close
            // 
            this.btn_close.Active = false;
            this.btn_close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderRadius = 0;
            this.btn_close.ButtonText = "Close Window";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.btn_close.DisabledColor = System.Drawing.Color.Gray;
            this.btn_close.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_close.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_close.Iconimage")));
            this.btn_close.Iconimage_right = null;
            this.btn_close.Iconimage_right_Selected = null;
            this.btn_close.Iconimage_Selected = null;
            this.btn_close.IconMarginLeft = 0;
            this.btn_close.IconMarginRight = 0;
            this.btn_close.IconRightVisible = true;
            this.btn_close.IconRightZoom = 0D;
            this.btn_close.IconVisible = true;
            this.btn_close.IconZoom = 90D;
            this.btn_close.IsTab = false;
            this.btn_close.Location = new System.Drawing.Point(1087, 560);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(151, 33);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "Close Window";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_log
            // 
            this.btn_log.Active = false;
            this.btn_log.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_log.BorderRadius = 0;
            this.btn_log.ButtonText = "Save Log to File";
            this.btn_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_log, BunifuAnimatorNS.DecorationType.None);
            this.btn_log.DisabledColor = System.Drawing.Color.Gray;
            this.btn_log.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_log.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_log.Iconimage")));
            this.btn_log.Iconimage_right = null;
            this.btn_log.Iconimage_right_Selected = null;
            this.btn_log.Iconimage_Selected = null;
            this.btn_log.IconMarginLeft = 0;
            this.btn_log.IconMarginRight = 0;
            this.btn_log.IconRightVisible = true;
            this.btn_log.IconRightZoom = 0D;
            this.btn_log.IconVisible = true;
            this.btn_log.IconZoom = 90D;
            this.btn_log.IsTab = false;
            this.btn_log.Location = new System.Drawing.Point(326, 560);
            this.btn_log.Name = "btn_log";
            this.btn_log.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_log.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_log.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_log.selected = false;
            this.btn_log.Size = new System.Drawing.Size(63, 33);
            this.btn_log.TabIndex = 28;
            this.btn_log.Text = "Save Log to File";
            this.btn_log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log.Textcolor = System.Drawing.Color.White;
            this.btn_log.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Visible = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_show
            // 
            this.btn_show.Active = false;
            this.btn_show.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show.BorderRadius = 0;
            this.btn_show.ButtonText = "Show Peronal Data";
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_show, BunifuAnimatorNS.DecorationType.None);
            this.btn_show.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show.Enabled = false;
            this.btn_show.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_show.Iconimage")));
            this.btn_show.Iconimage_right = null;
            this.btn_show.Iconimage_right_Selected = null;
            this.btn_show.Iconimage_Selected = null;
            this.btn_show.IconMarginLeft = 0;
            this.btn_show.IconMarginRight = 0;
            this.btn_show.IconRightVisible = true;
            this.btn_show.IconRightZoom = 0D;
            this.btn_show.IconVisible = true;
            this.btn_show.IconZoom = 90D;
            this.btn_show.IsTab = false;
            this.btn_show.Location = new System.Drawing.Point(526, 560);
            this.btn_show.Name = "btn_show";
            this.btn_show.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_show.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show.selected = false;
            this.btn_show.Size = new System.Drawing.Size(60, 33);
            this.btn_show.TabIndex = 28;
            this.btn_show.Text = "Show Peronal Data";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.Textcolor = System.Drawing.Color.White;
            this.btn_show.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Visible = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.bunifuTransition1.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabControl1.Location = new System.Drawing.Point(823, 363);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(405, 185);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage1.Controls.Add(this.lst_msg);
            this.bunifuTransition1.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(397, 143);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Activity Log";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txt_remark);
            this.bunifuTransition1.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(397, 143);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Remark";
            // 
            // txt_remark
            // 
            this.bunifuTransition1.SetDecoration(this.txt_remark, BunifuAnimatorNS.DecorationType.None);
            this.txt_remark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_remark.Location = new System.Drawing.Point(0, 0);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(397, 143);
            this.txt_remark.TabIndex = 0;
            // 
            // lb_loginuser
            // 
            this.lb_loginuser.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_loginuser, BunifuAnimatorNS.DecorationType.None);
            this.lb_loginuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginuser.Location = new System.Drawing.Point(1035, 60);
            this.lb_loginuser.Name = "lb_loginuser";
            this.lb_loginuser.Size = new System.Drawing.Size(43, 16);
            this.lb_loginuser.TabIndex = 4;
            this.lb_loginuser.Text = "Guest";
            // 
            // btn_capturefoto
            // 
            this.btn_capturefoto.Active = false;
            this.btn_capturefoto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_capturefoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_capturefoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_capturefoto.BorderRadius = 0;
            this.btn_capturefoto.ButtonText = "Refresh WebCam Capture";
            this.btn_capturefoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_capturefoto, BunifuAnimatorNS.DecorationType.None);
            this.btn_capturefoto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_capturefoto.Enabled = false;
            this.btn_capturefoto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_capturefoto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_capturefoto.Iconimage")));
            this.btn_capturefoto.Iconimage_right = null;
            this.btn_capturefoto.Iconimage_right_Selected = null;
            this.btn_capturefoto.Iconimage_Selected = null;
            this.btn_capturefoto.IconMarginLeft = 0;
            this.btn_capturefoto.IconMarginRight = 0;
            this.btn_capturefoto.IconRightVisible = true;
            this.btn_capturefoto.IconRightZoom = 0D;
            this.btn_capturefoto.IconVisible = true;
            this.btn_capturefoto.IconZoom = 90D;
            this.btn_capturefoto.IsTab = false;
            this.btn_capturefoto.Location = new System.Drawing.Point(823, 324);
            this.btn_capturefoto.Name = "btn_capturefoto";
            this.btn_capturefoto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_capturefoto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_capturefoto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_capturefoto.selected = false;
            this.btn_capturefoto.Size = new System.Drawing.Size(223, 33);
            this.btn_capturefoto.TabIndex = 28;
            this.btn_capturefoto.Text = "Refresh WebCam Capture";
            this.btn_capturefoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capturefoto.Textcolor = System.Drawing.Color.White;
            this.btn_capturefoto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capturefoto.Visible = false;
            this.btn_capturefoto.Click += new System.EventHandler(this.btn_capturefoto_Click);
            // 
            // lb_clientName
            // 
            this.lb_clientName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_clientName, BunifuAnimatorNS.DecorationType.None);
            this.lb_clientName.Location = new System.Drawing.Point(11, 570);
            this.lb_clientName.Name = "lb_clientName";
            this.lb_clientName.Size = new System.Drawing.Size(81, 19);
            this.lb_clientName.TabIndex = 38;
            this.lb_clientName.Text = "metroLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(668, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 39;
            this.label1.Text = "Version:";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbVersion, BunifuAnimatorNS.DecorationType.None);
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVersion.Location = new System.Drawing.Point(816, 14);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(140, 39);
            this.lbVersion.TabIndex = 40;
            this.lbVersion.Text = "Version";
            // 
            // txt_selectedUser
            // 
            this.txt_selectedUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_selectedUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_selectedUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_selectedUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_selectedUser, BunifuAnimatorNS.DecorationType.None);
            this.txt_selectedUser.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txt_selectedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_selectedUser.HintForeColor = System.Drawing.Color.Empty;
            this.txt_selectedUser.HintText = "Enter Client Name or Internet IDNo";
            this.txt_selectedUser.isPassword = false;
            this.txt_selectedUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_selectedUser.LineIdleColor = System.Drawing.Color.Maroon;
            this.txt_selectedUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_selectedUser.LineThickness = 3;
            this.txt_selectedUser.Location = new System.Drawing.Point(17, 91);
            this.txt_selectedUser.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectedUser.MaxLength = 32767;
            this.txt_selectedUser.Name = "txt_selectedUser";
            this.txt_selectedUser.Size = new System.Drawing.Size(237, 33);
            this.txt_selectedUser.TabIndex = 41;
            this.txt_selectedUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BGWorker_rightSearch
            // 
            this.BGWorker_rightSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_rightSearch_DoWork);
            // 
            // BGWorker_thumbSearch
            // 
            this.BGWorker_thumbSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_thumbSearch_DoWork);
            // 
            // VerifyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 601);
            this.Controls.Add(this.txt_selectedUser);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_clientName);
            this.Controls.Add(this.btn_capturefoto);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lb_match);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.CircleProgressbar1);
            this.Controls.Add(this.pixBarcode);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.xamlButtonEnroll);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bn_identify);
            this.Controls.Add(this.btn_thump);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.tPanel1);
            this.Controls.Add(this.chk_thumb);
            this.Controls.Add(this.chk_right);
            this.Controls.Add(this.chk_left);
            this.Controls.Add(this.fPanel1);
            this.Controls.Add(this.lb_loginuser);
            this.Controls.Add(this.xamlLabelMessage);
            this.Controls.Add(this.stackPanelFingerprints);
            this.Controls.Add(this.xamlLabelUsername);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerifyWindow";
            this.Resizable = false;
            this.Text = "InfoMetriQ Verification Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnrollmentWindow_new_FormClosing);
            this.Load += new System.EventHandler(this.Window_Loaded);
            this.fPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageOnScannerDetect)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pix_login)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label xamlLabelUsername;
        private System.Windows.Forms.FlowLayoutPanel stackPanelFingerprints;
        private System.Windows.Forms.Label xamlLabelMessage;
        private System.Windows.Forms.FlowLayoutPanel fPanel1;
        private System.Windows.Forms.PictureBox xamlImageOnScannerImage;
        private System.Windows.Forms.CheckBox chk_left;
        private System.Windows.Forms.CheckBox chk_right;
        private System.Windows.Forms.CheckBox chk_thumb;
        private System.Windows.Forms.ListBox lst_msg;
        private System.Windows.Forms.PictureBox pic_Webcam;
        private System.Windows.Forms.FlowLayoutPanel fp_thumb;
        private System.Windows.Forms.FlowLayoutPanel fp_right;
        private System.Windows.Forms.FlowLayoutPanel fp_left;
        private System.Windows.Forms.PictureBox imageOnScannerDetect;
        private System.Windows.Forms.TableLayoutPanel tPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCapture;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show;
        private Bunifu.Framework.UI.BunifuFlatButton btn_left;
        private Bunifu.Framework.UI.BunifuFlatButton btn_right;
        private Bunifu.Framework.UI.BunifuFlatButton btn_thump;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton xamlButtonEnroll;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.ComponentModel.BackgroundWorker BGWorker_LeftSearch;
        private System.Windows.Forms.PictureBox pixBarcode;
        private Bunifu.Framework.UI.BunifuFlatButton bn_identify;
        private Bunifu.Framework.UI.BunifuFlatButton btn_newEnroll;
        private Bunifu.Framework.UI.BunifuFlatButton btn_log;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressbar1;
        private System.Windows.Forms.Label lb_match;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_updatePIC;
        private System.ComponentModel.BackgroundWorker BGWorker_rightSearch;
        private System.ComponentModel.BackgroundWorker BGWorker_thumbSearch;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label lb_loginuser;
        private Bunifu.Framework.UI.BunifuFlatButton btn_capturefoto;
        private System.Windows.Forms.PictureBox pix_login;
        private MetroFramework.Controls.MetroLabel lb_clientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_selectedUser;
    }
}