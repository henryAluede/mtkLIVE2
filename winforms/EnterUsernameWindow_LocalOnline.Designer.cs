namespace DermalogMultiScannerDemo
{
    partial class EnterUsernameWindow_LocalOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterUsernameWindow_LocalOnline));
            this.xamlTextBoxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.xamlButtonOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pixBarcode = new System.Windows.Forms.PictureBox();
            this.btn_status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_exist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_checkExistLocal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pix_busy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_busy)).BeginInit();
            this.SuspendLayout();
            // 
            // xamlTextBoxUsername
            // 
            this.xamlTextBoxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.xamlTextBoxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.xamlTextBoxUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.xamlTextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xamlTextBoxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.xamlTextBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.xamlTextBoxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.xamlTextBoxUsername.HintText = "Search by UserName ";
            this.xamlTextBoxUsername.isPassword = false;
            this.xamlTextBoxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.xamlTextBoxUsername.LineIdleColor = System.Drawing.Color.Maroon;
            this.xamlTextBoxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.xamlTextBoxUsername.LineThickness = 5;
            this.xamlTextBoxUsername.Location = new System.Drawing.Point(24, 71);
            this.xamlTextBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.xamlTextBoxUsername.MaxLength = 32767;
            this.xamlTextBoxUsername.Name = "xamlTextBoxUsername";
            this.xamlTextBoxUsername.Size = new System.Drawing.Size(376, 33);
            this.xamlTextBoxUsername.TabIndex = 0;
            this.xamlTextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // xamlButtonOK
            // 
            this.xamlButtonOK.Active = false;
            this.xamlButtonOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xamlButtonOK.BorderRadius = 0;
            this.xamlButtonOK.ButtonText = "Ok to Enroll";
            this.xamlButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xamlButtonOK.DisabledColor = System.Drawing.Color.Gray;
            this.xamlButtonOK.Iconcolor = System.Drawing.Color.Transparent;
            this.xamlButtonOK.Iconimage = ((System.Drawing.Image)(resources.GetObject("xamlButtonOK.Iconimage")));
            this.xamlButtonOK.Iconimage_right = null;
            this.xamlButtonOK.Iconimage_right_Selected = null;
            this.xamlButtonOK.Iconimage_Selected = null;
            this.xamlButtonOK.IconMarginLeft = 0;
            this.xamlButtonOK.IconMarginRight = 0;
            this.xamlButtonOK.IconRightVisible = true;
            this.xamlButtonOK.IconRightZoom = 0D;
            this.xamlButtonOK.IconVisible = true;
            this.xamlButtonOK.IconZoom = 90D;
            this.xamlButtonOK.IsTab = false;
            this.xamlButtonOK.Location = new System.Drawing.Point(187, 188);
            this.xamlButtonOK.Name = "xamlButtonOK";
            this.xamlButtonOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xamlButtonOK.OnHoverTextColor = System.Drawing.Color.White;
            this.xamlButtonOK.selected = false;
            this.xamlButtonOK.Size = new System.Drawing.Size(133, 35);
            this.xamlButtonOK.TabIndex = 4;
            this.xamlButtonOK.Text = "Ok to Enroll";
            this.xamlButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xamlButtonOK.Textcolor = System.Drawing.Color.White;
            this.xamlButtonOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xamlButtonOK.Visible = false;
            this.xamlButtonOK.Click += new System.EventHandler(this.xamlButtonOK_Click);
            // 
            // pixBarcode
            // 
            this.pixBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pixBarcode.Location = new System.Drawing.Point(257, 152);
            this.pixBarcode.Name = "pixBarcode";
            this.pixBarcode.Size = new System.Drawing.Size(199, 30);
            this.pixBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixBarcode.TabIndex = 8;
            this.pixBarcode.TabStop = false;
            // 
            // btn_status
            // 
            this.btn_status.AutoSize = true;
            this.btn_status.Location = new System.Drawing.Point(23, 238);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(28, 13);
            this.btn_status.TabIndex = 9;
            this.btn_status.Text = ".......";
            // 
            // btn_exist
            // 
            this.btn_exist.Active = false;
            this.btn_exist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_exist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_exist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exist.BorderRadius = 0;
            this.btn_exist.ButtonText = "Check if it Exist Online";
            this.btn_exist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exist.DisabledColor = System.Drawing.Color.Gray;
            this.btn_exist.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_exist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_exist.Iconimage")));
            this.btn_exist.Iconimage_right = null;
            this.btn_exist.Iconimage_right_Selected = null;
            this.btn_exist.Iconimage_Selected = null;
            this.btn_exist.IconMarginLeft = 0;
            this.btn_exist.IconMarginRight = 0;
            this.btn_exist.IconRightVisible = true;
            this.btn_exist.IconRightZoom = 0D;
            this.btn_exist.IconVisible = true;
            this.btn_exist.IconZoom = 90D;
            this.btn_exist.IsTab = false;
            this.btn_exist.Location = new System.Drawing.Point(257, 111);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_exist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exist.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exist.selected = false;
            this.btn_exist.Size = new System.Drawing.Size(199, 35);
            this.btn_exist.TabIndex = 4;
            this.btn_exist.Text = "Check if it Exist Online";
            this.btn_exist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exist.Textcolor = System.Drawing.Color.White;
            this.btn_exist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // btn_close
            // 
            this.btn_close.Active = false;
            this.btn_close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_close.BackColor = System.Drawing.Color.Maroon;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderRadius = 0;
            this.btn_close.ButtonText = "Close";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_close.Location = new System.Drawing.Point(351, 188);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.Maroon;
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(105, 35);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_checkExistLocal
            // 
            this.btn_checkExistLocal.Active = false;
            this.btn_checkExistLocal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_checkExistLocal.BackColor = System.Drawing.Color.Blue;
            this.btn_checkExistLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkExistLocal.BorderRadius = 0;
            this.btn_checkExistLocal.ButtonText = "Check if it Exist Local";
            this.btn_checkExistLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkExistLocal.DisabledColor = System.Drawing.Color.Gray;
            this.btn_checkExistLocal.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_checkExistLocal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_checkExistLocal.Iconimage")));
            this.btn_checkExistLocal.Iconimage_right = null;
            this.btn_checkExistLocal.Iconimage_right_Selected = null;
            this.btn_checkExistLocal.Iconimage_Selected = null;
            this.btn_checkExistLocal.IconMarginLeft = 0;
            this.btn_checkExistLocal.IconMarginRight = 0;
            this.btn_checkExistLocal.IconRightVisible = true;
            this.btn_checkExistLocal.IconRightZoom = 0D;
            this.btn_checkExistLocal.IconVisible = true;
            this.btn_checkExistLocal.IconZoom = 90D;
            this.btn_checkExistLocal.IsTab = false;
            this.btn_checkExistLocal.Location = new System.Drawing.Point(23, 111);
            this.btn_checkExistLocal.Name = "btn_checkExistLocal";
            this.btn_checkExistLocal.Normalcolor = System.Drawing.Color.Blue;
            this.btn_checkExistLocal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_checkExistLocal.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_checkExistLocal.selected = false;
            this.btn_checkExistLocal.Size = new System.Drawing.Size(199, 35);
            this.btn_checkExistLocal.TabIndex = 10;
            this.btn_checkExistLocal.Text = "Check if it Exist Local";
            this.btn_checkExistLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkExistLocal.Textcolor = System.Drawing.Color.White;
            this.btn_checkExistLocal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkExistLocal.Click += new System.EventHandler(this.btn_checkExistLocal_Click);
            // 
            // pix_busy
            // 
            this.pix_busy.Image = ((System.Drawing.Image)(resources.GetObject("pix_busy.Image")));
            this.pix_busy.Location = new System.Drawing.Point(23, 163);
            this.pix_busy.Name = "pix_busy";
            this.pix_busy.Size = new System.Drawing.Size(212, 19);
            this.pix_busy.TabIndex = 76;
            this.pix_busy.TabStop = false;
            this.pix_busy.Visible = false;
            // 
            // EnterUsernameWindow_LocalOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 234);
            this.Controls.Add(this.pix_busy);
            this.Controls.Add(this.btn_checkExistLocal);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.pixBarcode);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.xamlButtonOK);
            this.Controls.Add(this.xamlTextBoxUsername);
            this.MaximizeBox = false;
            this.Name = "EnterUsernameWindow_LocalOnline";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Check by Username Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterUsernameWindow_new_FormClosing);
            this.Load += new System.EventHandler(this.EnterUsernameWindow_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pix_busy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox xamlTextBoxUsername;
        private Bunifu.Framework.UI.BunifuFlatButton xamlButtonOK;
        private System.Windows.Forms.PictureBox pixBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_status;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exist;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton btn_checkExistLocal;
        private System.Windows.Forms.PictureBox pix_busy;
    }
}