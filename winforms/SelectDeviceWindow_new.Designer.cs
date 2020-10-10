namespace DermalogMultiScannerDemo
{
    partial class SelectDeviceWindow_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDeviceWindow_new));
            this.xamlListBoxDevices = new System.Windows.Forms.ListBox();
            this.xamlProgressBar = new System.Windows.Forms.PictureBox();
            this.xamlButtonOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.xamlLabelMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xamlProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // xamlListBoxDevices
            // 
            this.xamlListBoxDevices.FormattingEnabled = true;
            this.xamlListBoxDevices.Location = new System.Drawing.Point(16, 93);
            this.xamlListBoxDevices.Name = "xamlListBoxDevices";
            this.xamlListBoxDevices.ScrollAlwaysVisible = true;
            this.xamlListBoxDevices.Size = new System.Drawing.Size(323, 147);
            this.xamlListBoxDevices.TabIndex = 1;
            this.xamlListBoxDevices.SelectedIndexChanged += new System.EventHandler(this.xamlListBoxDevices_SelectionChanged);
            // 
            // xamlProgressBar
            // 
            this.xamlProgressBar.Image = global::DermalogMultiScannerDemo.Properties.Resources.ajaxLoadingAnimation;
            this.xamlProgressBar.Location = new System.Drawing.Point(16, 246);
            this.xamlProgressBar.Name = "xamlProgressBar";
            this.xamlProgressBar.Size = new System.Drawing.Size(223, 17);
            this.xamlProgressBar.TabIndex = 8;
            this.xamlProgressBar.TabStop = false;
            // 
            // xamlButtonOK
            // 
            this.xamlButtonOK.Active = false;
            this.xamlButtonOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xamlButtonOK.BorderRadius = 0;
            this.xamlButtonOK.ButtonText = "Select Device";
            this.xamlButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xamlButtonOK.DisabledColor = System.Drawing.Color.Gray;
            this.xamlButtonOK.Enabled = false;
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
            this.xamlButtonOK.Location = new System.Drawing.Point(158, 279);
            this.xamlButtonOK.Name = "xamlButtonOK";
            this.xamlButtonOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xamlButtonOK.OnHoverTextColor = System.Drawing.Color.White;
            this.xamlButtonOK.selected = false;
            this.xamlButtonOK.Size = new System.Drawing.Size(181, 39);
            this.xamlButtonOK.TabIndex = 9;
            this.xamlButtonOK.Text = "Select Device";
            this.xamlButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xamlButtonOK.Textcolor = System.Drawing.Color.White;
            this.xamlButtonOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xamlButtonOK.Click += new System.EventHandler(this.xamlButtonOK_Click);
            // 
            // xamlLabelMessage
            // 
            this.xamlLabelMessage.AutoSize = true;
            this.xamlLabelMessage.Location = new System.Drawing.Point(14, 66);
            this.xamlLabelMessage.Name = "xamlLabelMessage";
            this.xamlLabelMessage.Size = new System.Drawing.Size(103, 13);
            this.xamlLabelMessage.TabIndex = 10;
            this.xamlLabelMessage.Text = "bunifuCustomLabel1";
            // 
            // SelectDeviceWindow_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 329);
            this.Controls.Add(this.xamlLabelMessage);
            this.Controls.Add(this.xamlButtonOK);
            this.Controls.Add(this.xamlProgressBar);
            this.Controls.Add(this.xamlListBoxDevices);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDeviceWindow_new";
            this.Resizable = false;
            this.Text = "Select Device Window ";
            ((System.ComponentModel.ISupportInitialize)(this.xamlProgressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox xamlListBoxDevices;
        private System.Windows.Forms.PictureBox xamlProgressBar;
        private Bunifu.Framework.UI.BunifuFlatButton xamlButtonOK;
        private Bunifu.Framework.UI.BunifuCustomLabel xamlLabelMessage;
    }
}