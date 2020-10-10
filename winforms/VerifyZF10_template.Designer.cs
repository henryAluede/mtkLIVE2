﻿namespace DermalogMultiScannerDemo
{
    partial class VerifyZF10_template
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
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyZF10_template));
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStorage = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.xamlLabelMessage = new MetroFramework.Controls.MetroLabel();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.fPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_selectedUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picBusy = new System.Windows.Forms.PictureBox();
            this.pic_Webcam = new System.Windows.Forms.PictureBox();
            this.xamlImageOnScannerDetect = new System.Windows.Forms.PictureBox();
            this.xamlImageOnScannerImage = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.CircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pixBarcode = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_startScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_format = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_userDetails = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_showlarge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerDetect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerImage)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = -180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.bunifuTransition1.SetDecoration(this.aGauge1, BunifuAnimatorNS.DecorationType.None);
            aGaugeRange1.Color = System.Drawing.Color.Lime;
            aGaugeRange1.EndValue = 60F;
            aGaugeRange1.InnerRadius = 1;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 2;
            aGaugeRange1.StartValue = 100F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange1);
            this.aGauge1.Location = new System.Drawing.Point(3, 324);
            this.aGauge1.MaxValue = 100F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Blue;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 90;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 128);
            this.aGauge1.TabIndex = 10;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Best User verified 0%)";
            // 
            // lbStorage
            // 
            this.lbStorage.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbStorage, BunifuAnimatorNS.DecorationType.None);
            this.lbStorage.Location = new System.Drawing.Point(251, 496);
            this.lbStorage.Name = "lbStorage";
            this.lbStorage.Size = new System.Drawing.Size(88, 19);
            this.lbStorage.TabIndex = 13;
            this.lbStorage.Text = "metroLabel12";
            this.lbStorage.Visible = false;
            // 
            // xamlLabelMessage
            // 
            this.xamlLabelMessage.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.xamlLabelMessage, BunifuAnimatorNS.DecorationType.None);
            this.xamlLabelMessage.Location = new System.Drawing.Point(242, 515);
            this.xamlLabelMessage.Name = "xamlLabelMessage";
            this.xamlLabelMessage.Size = new System.Drawing.Size(88, 19);
            this.xamlLabelMessage.TabIndex = 13;
            this.xamlLabelMessage.Text = "metroLabel13";
            this.xamlLabelMessage.Visible = false;
            // 
            // lst_msg
            // 
            this.bunifuTransition1.SetDecoration(this.lst_msg, BunifuAnimatorNS.DecorationType.None);
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.HorizontalScrollbar = true;
            this.lst_msg.Location = new System.Drawing.Point(216, 324);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.ScrollAlwaysVisible = true;
            this.lst_msg.Size = new System.Drawing.Size(422, 134);
            this.lst_msg.TabIndex = 6;
            this.lst_msg.SelectedIndexChanged += new System.EventHandler(this.xamlListBoxUsers_SelectionChanged);
            this.lst_msg.SelectedValueChanged += new System.EventHandler(this.xamlListBoxUsers_SelectionChanged);
            // 
            // fPanel1
            // 
            this.bunifuTransition1.SetDecoration(this.fPanel1, BunifuAnimatorNS.DecorationType.None);
            this.fPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fPanel1.Location = new System.Drawing.Point(0, 0);
            this.fPanel1.Name = "fPanel1";
            this.fPanel1.Size = new System.Drawing.Size(624, 225);
            this.fPanel1.TabIndex = 14;
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
            this.txt_selectedUser.HintText = "Enter Client Name";
            this.txt_selectedUser.isPassword = false;
            this.txt_selectedUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_selectedUser.LineIdleColor = System.Drawing.Color.Maroon;
            this.txt_selectedUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_selectedUser.LineThickness = 3;
            this.txt_selectedUser.Location = new System.Drawing.Point(23, 64);
            this.txt_selectedUser.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectedUser.MaxLength = 32767;
            this.txt_selectedUser.Name = "txt_selectedUser";
            this.txt_selectedUser.Size = new System.Drawing.Size(185, 33);
            this.txt_selectedUser.TabIndex = 17;
            this.txt_selectedUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.Active = false;
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "Close Window";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(893, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Maroon;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(166, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close Window";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picBusy
            // 
            this.bunifuTransition1.SetDecoration(this.picBusy, BunifuAnimatorNS.DecorationType.None);
            this.picBusy.Image = global::DermalogMultiScannerDemo.Properties.Resources.ajaxLoadingAnimation;
            this.picBusy.Location = new System.Drawing.Point(851, 464);
            this.picBusy.Name = "picBusy";
            this.picBusy.Size = new System.Drawing.Size(215, 18);
            this.picBusy.TabIndex = 7;
            this.picBusy.TabStop = false;
            this.picBusy.Visible = false;
            // 
            // pic_Webcam
            // 
            this.bunifuTransition1.SetDecoration(this.pic_Webcam, BunifuAnimatorNS.DecorationType.None);
            this.pic_Webcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Webcam.Location = new System.Drawing.Point(0, 0);
            this.pic_Webcam.Name = "pic_Webcam";
            this.pic_Webcam.Size = new System.Drawing.Size(196, 222);
            this.pic_Webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Webcam.TabIndex = 7;
            this.pic_Webcam.TabStop = false;
            // 
            // xamlImageOnScannerDetect
            // 
            this.xamlImageOnScannerDetect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.xamlImageOnScannerDetect, BunifuAnimatorNS.DecorationType.None);
            this.xamlImageOnScannerDetect.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers4;
            this.xamlImageOnScannerDetect.Location = new System.Drawing.Point(735, 458);
            this.xamlImageOnScannerDetect.Name = "xamlImageOnScannerDetect";
            this.xamlImageOnScannerDetect.Size = new System.Drawing.Size(49, 38);
            this.xamlImageOnScannerDetect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xamlImageOnScannerDetect.TabIndex = 7;
            this.xamlImageOnScannerDetect.TabStop = false;
            this.xamlImageOnScannerDetect.Visible = false;
            // 
            // xamlImageOnScannerImage
            // 
            this.xamlImageOnScannerImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.xamlImageOnScannerImage, BunifuAnimatorNS.DecorationType.None);
            this.xamlImageOnScannerImage.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
            this.xamlImageOnScannerImage.Location = new System.Drawing.Point(790, 458);
            this.xamlImageOnScannerImage.Name = "xamlImageOnScannerImage";
            this.xamlImageOnScannerImage.Size = new System.Drawing.Size(52, 38);
            this.xamlImageOnScannerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xamlImageOnScannerImage.TabIndex = 7;
            this.xamlImageOnScannerImage.TabStop = false;
            this.xamlImageOnScannerImage.Visible = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.fPanel1);
            this.bunifuTransition1.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(216, 89);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(628, 229);
            this.bunifuCards1.TabIndex = 18;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.pic_Webcam);
            this.bunifuTransition1.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(859, 89);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 30;
            this.bunifuCards2.Size = new System.Drawing.Size(200, 226);
            this.bunifuCards2.TabIndex = 19;
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
            this.CircleProgressbar1.Location = new System.Drawing.Point(23, 121);
            this.CircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CircleProgressbar1.MaxValue = 100;
            this.CircleProgressbar1.Name = "CircleProgressbar1";
            this.CircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.CircleProgressbar1.Size = new System.Drawing.Size(153, 153);
            this.CircleProgressbar1.TabIndex = 20;
            this.CircleProgressbar1.Value = 0;
            this.CircleProgressbar1.Click += new System.EventHandler(this.CircleProgressbar1_Click);
            // 
            // pixBarcode
            // 
            this.pixBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTransition1.SetDecoration(this.pixBarcode, BunifuAnimatorNS.DecorationType.None);
            this.pixBarcode.Location = new System.Drawing.Point(10, 464);
            this.pixBarcode.Name = "pixBarcode";
            this.pixBarcode.Size = new System.Drawing.Size(198, 36);
            this.pixBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixBarcode.TabIndex = 35;
            this.pixBarcode.TabStop = false;
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
            // btn_startScan
            // 
            this.btn_startScan.Active = false;
            this.btn_startScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_startScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_startScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startScan.BorderRadius = 0;
            this.btn_startScan.ButtonText = "Start Scanning";
            this.btn_startScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_startScan, BunifuAnimatorNS.DecorationType.None);
            this.btn_startScan.DisabledColor = System.Drawing.Color.Gray;
            this.btn_startScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_startScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_startScan.Iconimage")));
            this.btn_startScan.Iconimage_right = null;
            this.btn_startScan.Iconimage_right_Selected = null;
            this.btn_startScan.Iconimage_Selected = null;
            this.btn_startScan.IconMarginLeft = 0;
            this.btn_startScan.IconMarginRight = 0;
            this.btn_startScan.IconRightVisible = true;
            this.btn_startScan.IconRightZoom = 0D;
            this.btn_startScan.IconVisible = true;
            this.btn_startScan.IconZoom = 90D;
            this.btn_startScan.IsTab = false;
            this.btn_startScan.Location = new System.Drawing.Point(721, 502);
            this.btn_startScan.Name = "btn_startScan";
            this.btn_startScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_startScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_startScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_startScan.selected = false;
            this.btn_startScan.Size = new System.Drawing.Size(166, 35);
            this.btn_startScan.TabIndex = 16;
            this.btn_startScan.Text = "Start Scanning";
            this.btn_startScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_startScan.Textcolor = System.Drawing.Color.White;
            this.btn_startScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startScan.Click += new System.EventHandler(this.btn_startScan_Click);
            // 
            // lb_format
            // 
            this.lb_format.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_format, BunifuAnimatorNS.DecorationType.None);
            this.lb_format.Location = new System.Drawing.Point(216, 64);
            this.lb_format.Name = "lb_format";
            this.lb_format.Size = new System.Drawing.Size(88, 19);
            this.lb_format.TabIndex = 13;
            this.lb_format.Text = "metroLabel12";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.metroLabel2, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel2.Location = new System.Drawing.Point(264, 477);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "metroLabel13";
            this.metroLabel2.Visible = false;
            // 
            // txt_userDetails
            // 
            this.txt_userDetails.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.txt_userDetails, BunifuAnimatorNS.DecorationType.None);
            this.txt_userDetails.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txt_userDetails.Location = new System.Drawing.Point(14, 510);
            this.txt_userDetails.Name = "txt_userDetails";
            this.txt_userDetails.Size = new System.Drawing.Size(102, 19);
            this.txt_userDetails.TabIndex = 13;
            this.txt_userDetails.Text = "metroLabel13";
            this.txt_userDetails.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(644, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 134);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remark";
            // 
            // textBox1
            // 
            this.bunifuTransition1.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(409, 115);
            this.textBox1.TabIndex = 0;
            // 
            // btn_showlarge
            // 
            this.btn_showlarge.Active = false;
            this.btn_showlarge.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_showlarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_showlarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showlarge.BorderRadius = 0;
            this.btn_showlarge.ButtonText = "Show Enlarged Photo";
            this.btn_showlarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_showlarge, BunifuAnimatorNS.DecorationType.None);
            this.btn_showlarge.DisabledColor = System.Drawing.Color.Gray;
            this.btn_showlarge.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_showlarge.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_showlarge.Iconimage")));
            this.btn_showlarge.Iconimage_right = null;
            this.btn_showlarge.Iconimage_right_Selected = null;
            this.btn_showlarge.Iconimage_Selected = null;
            this.btn_showlarge.IconMarginLeft = 0;
            this.btn_showlarge.IconMarginRight = 0;
            this.btn_showlarge.IconRightVisible = true;
            this.btn_showlarge.IconRightZoom = 0D;
            this.btn_showlarge.IconVisible = true;
            this.btn_showlarge.IconZoom = 90D;
            this.btn_showlarge.IsTab = false;
            this.btn_showlarge.Location = new System.Drawing.Point(500, 502);
            this.btn_showlarge.Name = "btn_showlarge";
            this.btn_showlarge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_showlarge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_showlarge.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_showlarge.selected = false;
            this.btn_showlarge.Size = new System.Drawing.Size(215, 35);
            this.btn_showlarge.TabIndex = 16;
            this.btn_showlarge.Text = "Show Enlarged Photo";
            this.btn_showlarge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showlarge.Textcolor = System.Drawing.Color.White;
            this.btn_showlarge.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showlarge.Click += new System.EventHandler(this.btn_showlarge_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbVersion, BunifuAnimatorNS.DecorationType.None);
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVersion.Location = new System.Drawing.Point(783, 22);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(140, 39);
            this.lbVersion.TabIndex = 42;
            this.lbVersion.Text = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(635, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Version:";
            // 
            // VerifyZF10_template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 548);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pixBarcode);
            this.Controls.Add(this.CircleProgressbar1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.txt_selectedUser);
            this.Controls.Add(this.btn_showlarge);
            this.Controls.Add(this.btn_startScan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txt_userDetails);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.xamlLabelMessage);
            this.Controls.Add(this.lb_format);
            this.Controls.Add(this.lbStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.picBusy);
            this.Controls.Add(this.xamlImageOnScannerDetect);
            this.Controls.Add(this.xamlImageOnScannerImage);
            this.Controls.Add(this.lst_msg);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerifyZF10_template";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "InforMetriQ Biometric ZF10 Data Verification";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VerifyZF10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerDetect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xamlImageOnScannerImage)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox xamlImageOnScannerImage;
        private System.Windows.Forms.PictureBox xamlImageOnScannerDetect;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.PictureBox pic_Webcam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBusy;
        private MetroFramework.Controls.MetroLabel lbStorage;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroLabel xamlLabelMessage;
        private System.Windows.Forms.ListBox lst_msg;
        private System.Windows.Forms.FlowLayoutPanel fPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_selectedUser;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressbar1;
        private System.Windows.Forms.PictureBox pixBarcode;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_startScan;
        private MetroFramework.Controls.MetroLabel lb_format;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel txt_userDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_showlarge;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label1;
    }
}