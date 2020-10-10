namespace DermalogMultiScannerDemo.winforms
{
    partial class IdentityForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentityForm1));
            this.lst_feedback = new System.Windows.Forms.ListBox();
            this.btn_start = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_feedback2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_verify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lst_feedback
            // 
            this.lst_feedback.FormattingEnabled = true;
            this.lst_feedback.Location = new System.Drawing.Point(12, 12);
            this.lst_feedback.Name = "lst_feedback";
            this.lst_feedback.Size = new System.Drawing.Size(289, 290);
            this.lst_feedback.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Active = false;
            this.btn_start.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.BorderRadius = 0;
            this.btn_start.ButtonText = "Start Identification";
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.DisabledColor = System.Drawing.Color.Gray;
            this.btn_start.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_start.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_start.Iconimage")));
            this.btn_start.Iconimage_right = null;
            this.btn_start.Iconimage_right_Selected = null;
            this.btn_start.Iconimage_Selected = null;
            this.btn_start.IconMarginLeft = 0;
            this.btn_start.IconMarginRight = 0;
            this.btn_start.IconRightVisible = true;
            this.btn_start.IconRightZoom = 0D;
            this.btn_start.IconVisible = true;
            this.btn_start.IconZoom = 90D;
            this.btn_start.IsTab = false;
            this.btn_start.Location = new System.Drawing.Point(12, 387);
            this.btn_start.Name = "btn_start";
            this.btn_start.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_start.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_start.selected = false;
            this.btn_start.Size = new System.Drawing.Size(182, 37);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start Identification";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Textcolor = System.Drawing.Color.White;
            this.btn_start.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "StartTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop Time";
            // 
            // lst_feedback2
            // 
            this.lst_feedback2.FormattingEnabled = true;
            this.lst_feedback2.Location = new System.Drawing.Point(400, 12);
            this.lst_feedback2.Name = "lst_feedback2";
            this.lst_feedback2.Size = new System.Drawing.Size(289, 290);
            this.lst_feedback2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stop Time";
            // 
            // btn_verify
            // 
            this.btn_verify.Active = false;
            this.btn_verify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verify.BorderRadius = 0;
            this.btn_verify.ButtonText = "Start Verification";
            this.btn_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verify.DisabledColor = System.Drawing.Color.Gray;
            this.btn_verify.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_verify.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_verify.Iconimage")));
            this.btn_verify.Iconimage_right = null;
            this.btn_verify.Iconimage_right_Selected = null;
            this.btn_verify.Iconimage_Selected = null;
            this.btn_verify.IconMarginLeft = 0;
            this.btn_verify.IconMarginRight = 0;
            this.btn_verify.IconRightVisible = true;
            this.btn_verify.IconRightZoom = 0D;
            this.btn_verify.IconVisible = true;
            this.btn_verify.IconZoom = 90D;
            this.btn_verify.IsTab = false;
            this.btn_verify.Location = new System.Drawing.Point(400, 387);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_verify.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_verify.selected = false;
            this.btn_verify.Size = new System.Drawing.Size(164, 37);
            this.btn_verify.TabIndex = 1;
            this.btn_verify.Text = "Start Verification";
            this.btn_verify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verify.Textcolor = System.Drawing.Color.White;
            this.btn_verify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // IdentityForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 436);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lst_feedback2);
            this.Controls.Add(this.lst_feedback);
            this.Name = "IdentityForm1";
            this.Text = "IdentityForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IdentityForm1_FormClosing);
            this.Load += new System.EventHandler(this.IdentityForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_feedback;
        private Bunifu.Framework.UI.BunifuFlatButton btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_feedback2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_verify;
    }
}