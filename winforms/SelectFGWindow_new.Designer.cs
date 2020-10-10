namespace DermalogMultiScannerDemo
{
    partial class SelectFGWindow_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFGWindow_new));
            this.xamlListBoxFG = new System.Windows.Forms.ListBox();
            this.xamlButtonOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.xamlLabelMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.camToggle1 = new MetroFramework.Controls.MetroToggle();
            this.SuspendLayout();
            // 
            // xamlListBoxFG
            // 
            this.xamlListBoxFG.FormattingEnabled = true;
            this.xamlListBoxFG.Location = new System.Drawing.Point(16, 99);
            this.xamlListBoxFG.Name = "xamlListBoxFG";
            this.xamlListBoxFG.Size = new System.Drawing.Size(430, 121);
            this.xamlListBoxFG.TabIndex = 4;
            this.xamlListBoxFG.SelectedValueChanged += new System.EventHandler(this.xamlListBoxFG_SelectionChanged);
            this.xamlListBoxFG.Leave += new System.EventHandler(this.xamlListBoxFG_Leave);
            // 
            // xamlButtonOK
            // 
            this.xamlButtonOK.Active = false;
            this.xamlButtonOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xamlButtonOK.BorderRadius = 0;
            this.xamlButtonOK.ButtonText = "Select FG Device";
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
            this.xamlButtonOK.Location = new System.Drawing.Point(270, 226);
            this.xamlButtonOK.Name = "xamlButtonOK";
            this.xamlButtonOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.xamlButtonOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xamlButtonOK.OnHoverTextColor = System.Drawing.Color.White;
            this.xamlButtonOK.selected = false;
            this.xamlButtonOK.Size = new System.Drawing.Size(176, 36);
            this.xamlButtonOK.TabIndex = 6;
            this.xamlButtonOK.Text = "Select FG Device";
            this.xamlButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xamlButtonOK.Textcolor = System.Drawing.Color.White;
            this.xamlButtonOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xamlButtonOK.Click += new System.EventHandler(this.xamlButtonOK_Click);
            // 
            // xamlLabelMessage
            // 
            this.xamlLabelMessage.AutoSize = true;
            this.xamlLabelMessage.Location = new System.Drawing.Point(13, 71);
            this.xamlLabelMessage.Name = "xamlLabelMessage";
            this.xamlLabelMessage.Size = new System.Drawing.Size(103, 13);
            this.xamlLabelMessage.TabIndex = 7;
            this.xamlLabelMessage.Text = "bunifuCustomLabel1";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 240);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(106, 13);
            this.bunifuCustomLabel2.TabIndex = 49;
            this.bunifuCustomLabel2.Text = "Use External Camera";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // camToggle1
            // 
            this.camToggle1.AutoSize = true;
            this.camToggle1.Location = new System.Drawing.Point(127, 238);
            this.camToggle1.Name = "camToggle1";
            this.camToggle1.Size = new System.Drawing.Size(80, 17);
            this.camToggle1.TabIndex = 48;
            this.camToggle1.Text = "Off";
            this.camToggle1.UseSelectable = true;
            this.camToggle1.Visible = false;
            this.camToggle1.CheckedChanged += new System.EventHandler(this.camToggle1_CheckedChanged);
            // 
            // SelectFGWindow_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 273);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.camToggle1);
            this.Controls.Add(this.xamlLabelMessage);
            this.Controls.Add(this.xamlButtonOK);
            this.Controls.Add(this.xamlListBoxFG);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectFGWindow_new";
            this.Resizable = false;
            this.Text = "Select Frame Grabber Device Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox xamlListBoxFG;
        private Bunifu.Framework.UI.BunifuFlatButton xamlButtonOK;
        private Bunifu.Framework.UI.BunifuCustomLabel xamlLabelMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroToggle camToggle1;
    }
}