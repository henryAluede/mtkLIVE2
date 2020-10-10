namespace DermalogMultiScannerDemo.winforms
{
    partial class captureForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captureForm1));
            this.btnCapture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pic_Webcam = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_stop = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Active = false;
            this.btnCapture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.BorderRadius = 0;
            this.btnCapture.ButtonText = "Start Camera";
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnCapture.Location = new System.Drawing.Point(302, 512);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCapture.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapture.selected = false;
            this.btnCapture.Size = new System.Drawing.Size(173, 36);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Start Camera";
            this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Textcolor = System.Drawing.Color.White;
            this.btnCapture.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pic_Webcam
            // 
            this.pic_Webcam.Location = new System.Drawing.Point(14, 70);
            this.pic_Webcam.Name = "pic_Webcam";
            this.pic_Webcam.Size = new System.Drawing.Size(461, 431);
            this.pic_Webcam.TabIndex = 1;
            this.pic_Webcam.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Active = false;
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnClose.Location = new System.Drawing.Point(348, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Maroon;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(127, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Active = false;
            this.btn_stop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.BorderRadius = 0;
            this.btn_stop.ButtonText = "Capture Photo";
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.DisabledColor = System.Drawing.Color.Gray;
            this.btn_stop.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_stop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_stop.Iconimage")));
            this.btn_stop.Iconimage_right = null;
            this.btn_stop.Iconimage_right_Selected = null;
            this.btn_stop.Iconimage_Selected = null;
            this.btn_stop.IconMarginLeft = 0;
            this.btn_stop.IconMarginRight = 0;
            this.btn_stop.IconRightVisible = true;
            this.btn_stop.IconRightZoom = 0D;
            this.btn_stop.IconVisible = true;
            this.btn_stop.IconZoom = 90D;
            this.btn_stop.IsTab = false;
            this.btn_stop.Location = new System.Drawing.Point(125, 512);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_stop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_stop.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_stop.selected = false;
            this.btn_stop.Size = new System.Drawing.Size(162, 36);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "Capture Photo";
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stop.Textcolor = System.Drawing.Color.White;
            this.btn_stop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // captureForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 601);
            this.Controls.Add(this.pic_Webcam);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btnCapture);
            this.Name = "captureForm1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Picture Capture";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.captureForm1_FormClosing);
            this.Load += new System.EventHandler(this.captureForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Webcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnCapture;
        private System.Windows.Forms.PictureBox pic_Webcam;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btn_stop;
    }
}