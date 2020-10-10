namespace DermalogMultiScannerDemo.winforms
{
    partial class frm_createUSERS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_createUSERS));
            this.cbo_location = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_loginID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_staffname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_emailaddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbo_role = new System.Windows.Forms.ComboBox();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.DGV_AppUsers = new System.Windows.Forms.DataGridView();
            this.btn_addnew = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_location
            // 
            this.cbo_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_location.FormattingEnabled = true;
            this.cbo_location.Items.AddRange(new object[] {
            "Head Office",
            "Ikeja",
            "Lekki",
            "Mainland",
            "Ikorodu"});
            this.cbo_location.Location = new System.Drawing.Point(131, 215);
            this.cbo_location.Name = "cbo_location";
            this.cbo_location.Size = new System.Drawing.Size(224, 21);
            this.cbo_location.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel1.Location = new System.Drawing.Point(68, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Login ID";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_loginID
            // 
            this.txt_loginID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_loginID.CustomButton.Image = null;
            this.txt_loginID.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txt_loginID.CustomButton.Name = "";
            this.txt_loginID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_loginID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_loginID.CustomButton.TabIndex = 1;
            this.txt_loginID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_loginID.CustomButton.UseSelectable = true;
            this.txt_loginID.CustomButton.Visible = false;
            this.txt_loginID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_loginID.ForeColor = System.Drawing.Color.Black;
            this.txt_loginID.Lines = new string[0];
            this.txt_loginID.Location = new System.Drawing.Point(131, 81);
            this.txt_loginID.MaxLength = 32767;
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.PasswordChar = '\0';
            this.txt_loginID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_loginID.SelectedText = "";
            this.txt_loginID.SelectionLength = 0;
            this.txt_loginID.SelectionStart = 0;
            this.txt_loginID.ShortcutsEnabled = true;
            this.txt_loginID.Size = new System.Drawing.Size(224, 23);
            this.txt_loginID.TabIndex = 44;
            this.txt_loginID.UseCustomBackColor = true;
            this.txt_loginID.UseCustomForeColor = true;
            this.txt_loginID.UseSelectable = true;
            this.txt_loginID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_loginID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel2.Location = new System.Drawing.Point(50, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Staff Name";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txt_staffname
            // 
            this.txt_staffname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_staffname.CustomButton.Image = null;
            this.txt_staffname.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txt_staffname.CustomButton.Name = "";
            this.txt_staffname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_staffname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_staffname.CustomButton.TabIndex = 1;
            this.txt_staffname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_staffname.CustomButton.UseSelectable = true;
            this.txt_staffname.CustomButton.Visible = false;
            this.txt_staffname.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_staffname.ForeColor = System.Drawing.Color.Black;
            this.txt_staffname.Lines = new string[0];
            this.txt_staffname.Location = new System.Drawing.Point(131, 110);
            this.txt_staffname.MaxLength = 32767;
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.PasswordChar = '\0';
            this.txt_staffname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_staffname.SelectedText = "";
            this.txt_staffname.SelectionLength = 0;
            this.txt_staffname.SelectionStart = 0;
            this.txt_staffname.ShortcutsEnabled = true;
            this.txt_staffname.Size = new System.Drawing.Size(224, 23);
            this.txt_staffname.TabIndex = 46;
            this.txt_staffname.UseCustomBackColor = true;
            this.txt_staffname.UseCustomForeColor = true;
            this.txt_staffname.UseSelectable = true;
            this.txt_staffname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_staffname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel3.Location = new System.Drawing.Point(28, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Email Address";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txt_emailaddress
            // 
            this.txt_emailaddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_emailaddress.CustomButton.Image = null;
            this.txt_emailaddress.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txt_emailaddress.CustomButton.Name = "";
            this.txt_emailaddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_emailaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_emailaddress.CustomButton.TabIndex = 1;
            this.txt_emailaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_emailaddress.CustomButton.UseSelectable = true;
            this.txt_emailaddress.CustomButton.Visible = false;
            this.txt_emailaddress.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_emailaddress.ForeColor = System.Drawing.Color.Black;
            this.txt_emailaddress.Lines = new string[0];
            this.txt_emailaddress.Location = new System.Drawing.Point(131, 139);
            this.txt_emailaddress.MaxLength = 32767;
            this.txt_emailaddress.Name = "txt_emailaddress";
            this.txt_emailaddress.PasswordChar = '\0';
            this.txt_emailaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_emailaddress.SelectedText = "";
            this.txt_emailaddress.SelectionLength = 0;
            this.txt_emailaddress.SelectionStart = 0;
            this.txt_emailaddress.ShortcutsEnabled = true;
            this.txt_emailaddress.Size = new System.Drawing.Size(293, 23);
            this.txt_emailaddress.TabIndex = 48;
            this.txt_emailaddress.UseCustomBackColor = true;
            this.txt_emailaddress.UseCustomForeColor = true;
            this.txt_emailaddress.UseSelectable = true;
            this.txt_emailaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_emailaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel4.Location = new System.Drawing.Point(62, 215);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 50;
            this.metroLabel4.Text = "Location";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel6.Location = new System.Drawing.Point(82, 177);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "State";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // cbo_state
            // 
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Items.AddRange(new object[] {
            "Head Office",
            "Lagos",
            "Abuja",
            "Oyo"});
            this.cbo_state.Location = new System.Drawing.Point(131, 177);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(224, 21);
            this.cbo_state.TabIndex = 52;
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
            this.btn_close.Location = new System.Drawing.Point(780, 505);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(151, 33);
            this.btn_close.TabIndex = 32;
            this.btn_close.Text = "Close Window";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Active = false;
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "Save New User";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_save.Location = new System.Drawing.Point(595, 505);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(165, 33);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "Save New User";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Load += new System.EventHandler(this.btn_save_Load);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DermalogMultiScannerDemo.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(452, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel5.Location = new System.Drawing.Point(15, 247);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Application Role";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // cbo_role
            // 
            this.cbo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_role.FormattingEnabled = true;
            this.cbo_role.Items.AddRange(new object[] {
            "Verify",
            "Identify",
            "Enroll",
            "Administrator",
            "Suspended",
            "None"});
            this.cbo_role.Location = new System.Drawing.Point(131, 247);
            this.cbo_role.Name = "cbo_role";
            this.cbo_role.Size = new System.Drawing.Size(155, 21);
            this.cbo_role.TabIndex = 55;
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.Location = new System.Drawing.Point(131, 281);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(65, 17);
            this.chk_status.TabIndex = 59;
            this.chk_status.Text = "Activate";
            this.chk_status.UseVisualStyleBackColor = true;
            // 
            // DGV_AppUsers
            // 
            this.DGV_AppUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AppUsers.Location = new System.Drawing.Point(5, 304);
            this.DGV_AppUsers.Name = "DGV_AppUsers";
            this.DGV_AppUsers.Size = new System.Drawing.Size(926, 195);
            this.DGV_AppUsers.TabIndex = 60;
            this.DGV_AppUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AppUsers_CellClick);
            this.DGV_AppUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AppUsers_RowEnter);
            // 
            // btn_addnew
            // 
            this.btn_addnew.Active = false;
            this.btn_addnew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_addnew.BackColor = System.Drawing.Color.Purple;
            this.btn_addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addnew.BorderRadius = 0;
            this.btn_addnew.ButtonText = "Add New User";
            this.btn_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addnew.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addnew.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addnew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_addnew.Iconimage")));
            this.btn_addnew.Iconimage_right = null;
            this.btn_addnew.Iconimage_right_Selected = null;
            this.btn_addnew.Iconimage_Selected = null;
            this.btn_addnew.IconMarginLeft = 0;
            this.btn_addnew.IconMarginRight = 0;
            this.btn_addnew.IconRightVisible = true;
            this.btn_addnew.IconRightZoom = 0D;
            this.btn_addnew.IconVisible = true;
            this.btn_addnew.IconZoom = 90D;
            this.btn_addnew.IsTab = false;
            this.btn_addnew.Location = new System.Drawing.Point(404, 505);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Normalcolor = System.Drawing.Color.Purple;
            this.btn_addnew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addnew.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addnew.selected = false;
            this.btn_addnew.Size = new System.Drawing.Size(165, 33);
            this.btn_addnew.TabIndex = 61;
            this.btn_addnew.Text = "Add New User";
            this.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addnew.Textcolor = System.Drawing.Color.White;
            this.btn_addnew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // frm_createUSERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 544);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.DGV_AppUsers);
            this.Controls.Add(this.chk_status);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbo_role);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbo_state);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_emailaddress);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_staffname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_loginID);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbo_location);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_createUSERS";
            this.Resizable = false;
            this.Text = "Create New User Form";
            this.Load += new System.EventHandler(this.frm_createUSERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_location;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_loginID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_staffname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_emailaddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox cbo_role;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.DataGridView DGV_AppUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addnew;
    }
}