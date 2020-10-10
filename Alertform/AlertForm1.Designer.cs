namespace Alertform
{
    partial class AlertForm1
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm1));
            this.lb_alert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ShowAlert = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_alert
            // 
            this.lb_alert.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lb_alert, BunifuAnimatorNS.DecorationType.None);
            this.lb_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert.ForeColor = System.Drawing.Color.White;
            this.lb_alert.Location = new System.Drawing.Point(23, 13);
            this.lb_alert.Name = "lb_alert";
            this.lb_alert.Size = new System.Drawing.Size(98, 17);
            this.lb_alert.TabIndex = 1;
            this.lb_alert.Text = "Alert Message";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Active = false;
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 7;
            this.btn_cancel.ButtonText = "CANCEL";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_cancel, BunifuAnimatorNS.DecorationType.None);
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Iconimage")));
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(236, 99);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.Red;
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(115, 37);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Textcolor = System.Drawing.Color.White;
            this.btn_cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Active = false;
            this.btn_ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.BorderRadius = 7;
            this.btn_ok.ButtonText = "OK";
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_ok, BunifuAnimatorNS.DecorationType.None);
            this.btn_ok.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ok.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ok.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ok.Iconimage")));
            this.btn_ok.Iconimage_right = null;
            this.btn_ok.Iconimage_right_Selected = null;
            this.btn_ok.Iconimage_Selected = null;
            this.btn_ok.IconMarginLeft = 0;
            this.btn_ok.IconMarginRight = 0;
            this.btn_ok.IconRightVisible = true;
            this.btn_ok.IconRightZoom = 0D;
            this.btn_ok.IconVisible = true;
            this.btn_ok.IconZoom = 90D;
            this.btn_ok.IsTab = false;
            this.btn_ok.Location = new System.Drawing.Point(357, 99);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ok.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ok.selected = false;
            this.btn_ok.Size = new System.Drawing.Size(117, 37);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Textcolor = System.Drawing.Color.White;
            this.btn_ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ShowAlert
            // 
            this.ShowAlert.Interval = 10;
            this.ShowAlert.Tick += new System.EventHandler(this.ShowAlert_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lb_alert);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.btn_cancel);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 145);
            this.panel1.TabIndex = 2;
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
            // AlertForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 200);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertForm1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alert Message Box";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlertForm1_FormClosing);
            this.Load += new System.EventHandler(this.AlertForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_ok;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_alert;
        private System.Windows.Forms.Timer ShowAlert;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}