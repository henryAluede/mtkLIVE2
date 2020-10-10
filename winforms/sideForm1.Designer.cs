namespace DermalogMultiScannerDemo.winforms
{
    partial class sideForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sideForm1));
            this.btn_Setting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_assignRoleBtns = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Identification = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_CloseApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_resetData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_verifyTemplate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_CheckUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_searchByIIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_creatUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_setupDevice = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_enroll = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btn_Setting
            // 
            this.btn_Setting.Active = false;
            this.btn_Setting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Setting.BackColor = System.Drawing.Color.Maroon;
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Setting.BorderRadius = 0;
            this.btn_Setting.ButtonText = "Check  Connection";
            this.btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Setting.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Setting.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Setting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Iconimage")));
            this.btn_Setting.Iconimage_right = null;
            this.btn_Setting.Iconimage_right_Selected = null;
            this.btn_Setting.Iconimage_Selected = null;
            this.btn_Setting.IconMarginLeft = 0;
            this.btn_Setting.IconMarginRight = 0;
            this.btn_Setting.IconRightVisible = true;
            this.btn_Setting.IconRightZoom = 0D;
            this.btn_Setting.IconVisible = true;
            this.btn_Setting.IconZoom = 90D;
            this.btn_Setting.IsTab = false;
            this.btn_Setting.Location = new System.Drawing.Point(10, 539);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Normalcolor = System.Drawing.Color.Maroon;
            this.btn_Setting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Setting.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Setting.selected = false;
            this.btn_Setting.Size = new System.Drawing.Size(191, 38);
            this.btn_Setting.TabIndex = 4;
            this.btn_Setting.Text = "Check  Connection";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Textcolor = System.Drawing.Color.White;
            this.btn_Setting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_assignRoleBtns
            // 
            this.btn_assignRoleBtns.Active = false;
            this.btn_assignRoleBtns.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_assignRoleBtns.BackColor = System.Drawing.Color.Black;
            this.btn_assignRoleBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_assignRoleBtns.BorderRadius = 0;
            this.btn_assignRoleBtns.ButtonText = "View Statistics";
            this.btn_assignRoleBtns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_assignRoleBtns.DisabledColor = System.Drawing.Color.Gray;
            this.btn_assignRoleBtns.Enabled = false;
            this.btn_assignRoleBtns.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_assignRoleBtns.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_assignRoleBtns.Iconimage")));
            this.btn_assignRoleBtns.Iconimage_right = null;
            this.btn_assignRoleBtns.Iconimage_right_Selected = null;
            this.btn_assignRoleBtns.Iconimage_Selected = null;
            this.btn_assignRoleBtns.IconMarginLeft = 0;
            this.btn_assignRoleBtns.IconMarginRight = 0;
            this.btn_assignRoleBtns.IconRightVisible = true;
            this.btn_assignRoleBtns.IconRightZoom = 0D;
            this.btn_assignRoleBtns.IconVisible = true;
            this.btn_assignRoleBtns.IconZoom = 90D;
            this.btn_assignRoleBtns.IsTab = false;
            this.btn_assignRoleBtns.Location = new System.Drawing.Point(10, 495);
            this.btn_assignRoleBtns.Name = "btn_assignRoleBtns";
            this.btn_assignRoleBtns.Normalcolor = System.Drawing.Color.Black;
            this.btn_assignRoleBtns.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_assignRoleBtns.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_assignRoleBtns.selected = false;
            this.btn_assignRoleBtns.Size = new System.Drawing.Size(191, 38);
            this.btn_assignRoleBtns.TabIndex = 3;
            this.btn_assignRoleBtns.Text = "View Statistics";
            this.btn_assignRoleBtns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_assignRoleBtns.Textcolor = System.Drawing.Color.White;
            this.btn_assignRoleBtns.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assignRoleBtns.Click += new System.EventHandler(this.btn_assignRoleBtns_Click);
            // 
            // btn_Identification
            // 
            this.btn_Identification.Active = false;
            this.btn_Identification.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Identification.BackColor = System.Drawing.Color.Maroon;
            this.btn_Identification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Identification.BorderRadius = 0;
            this.btn_Identification.ButtonText = "Identification";
            this.btn_Identification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Identification.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Identification.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Identification.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Identification.Iconimage")));
            this.btn_Identification.Iconimage_right = null;
            this.btn_Identification.Iconimage_right_Selected = null;
            this.btn_Identification.Iconimage_Selected = null;
            this.btn_Identification.IconMarginLeft = 0;
            this.btn_Identification.IconMarginRight = 0;
            this.btn_Identification.IconRightVisible = true;
            this.btn_Identification.IconRightZoom = 0D;
            this.btn_Identification.IconVisible = true;
            this.btn_Identification.IconZoom = 90D;
            this.btn_Identification.IsTab = false;
            this.btn_Identification.Location = new System.Drawing.Point(10, 202);
            this.btn_Identification.Name = "btn_Identification";
            this.btn_Identification.Normalcolor = System.Drawing.Color.Maroon;
            this.btn_Identification.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Identification.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Identification.selected = false;
            this.btn_Identification.Size = new System.Drawing.Size(191, 38);
            this.btn_Identification.TabIndex = 2;
            this.btn_Identification.Text = "Identification";
            this.btn_Identification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Identification.Textcolor = System.Drawing.Color.White;
            this.btn_Identification.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Identification.Click += new System.EventHandler(this.btn_Identification_Click);
            // 
            // btn_CloseApp
            // 
            this.btn_CloseApp.Active = false;
            this.btn_CloseApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CloseApp.BorderRadius = 0;
            this.btn_CloseApp.ButtonText = "Close Aplication";
            this.btn_CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseApp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_CloseApp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CloseApp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_CloseApp.Iconimage")));
            this.btn_CloseApp.Iconimage_right = null;
            this.btn_CloseApp.Iconimage_right_Selected = null;
            this.btn_CloseApp.Iconimage_Selected = null;
            this.btn_CloseApp.IconMarginLeft = 0;
            this.btn_CloseApp.IconMarginRight = 0;
            this.btn_CloseApp.IconRightVisible = true;
            this.btn_CloseApp.IconRightZoom = 0D;
            this.btn_CloseApp.IconVisible = true;
            this.btn_CloseApp.IconZoom = 90D;
            this.btn_CloseApp.IsTab = false;
            this.btn_CloseApp.Location = new System.Drawing.Point(10, 640);
            this.btn_CloseApp.Name = "btn_CloseApp";
            this.btn_CloseApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CloseApp.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_CloseApp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CloseApp.selected = false;
            this.btn_CloseApp.Size = new System.Drawing.Size(191, 38);
            this.btn_CloseApp.TabIndex = 1;
            this.btn_CloseApp.Text = "Close Aplication";
            this.btn_CloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CloseApp.Textcolor = System.Drawing.Color.White;
            this.btn_CloseApp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseApp.Click += new System.EventHandler(this.btn_CloseApp_Click);
            // 
            // btn_resetData
            // 
            this.btn_resetData.Active = false;
            this.btn_resetData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_resetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_resetData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resetData.BorderRadius = 0;
            this.btn_resetData.ButtonText = "Reset User Data";
            this.btn_resetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resetData.DisabledColor = System.Drawing.Color.Gray;
            this.btn_resetData.Enabled = false;
            this.btn_resetData.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_resetData.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_resetData.Iconimage")));
            this.btn_resetData.Iconimage_right = null;
            this.btn_resetData.Iconimage_right_Selected = null;
            this.btn_resetData.Iconimage_Selected = null;
            this.btn_resetData.IconMarginLeft = 0;
            this.btn_resetData.IconMarginRight = 0;
            this.btn_resetData.IconRightVisible = true;
            this.btn_resetData.IconRightZoom = 0D;
            this.btn_resetData.IconVisible = true;
            this.btn_resetData.IconZoom = 90D;
            this.btn_resetData.IsTab = false;
            this.btn_resetData.Location = new System.Drawing.Point(10, 596);
            this.btn_resetData.Name = "btn_resetData";
            this.btn_resetData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_resetData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_resetData.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_resetData.selected = false;
            this.btn_resetData.Size = new System.Drawing.Size(191, 38);
            this.btn_resetData.TabIndex = 1;
            this.btn_resetData.Text = "Reset User Data";
            this.btn_resetData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resetData.Textcolor = System.Drawing.Color.White;
            this.btn_resetData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetData.Click += new System.EventHandler(this.btn_resetData_Click);
            // 
            // btn_verifyTemplate
            // 
            this.btn_verifyTemplate.Active = false;
            this.btn_verifyTemplate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verifyTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verifyTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verifyTemplate.BorderRadius = 0;
            this.btn_verifyTemplate.ButtonText = "Verify Using Template";
            this.btn_verifyTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verifyTemplate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_verifyTemplate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_verifyTemplate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_verifyTemplate.Iconimage")));
            this.btn_verifyTemplate.Iconimage_right = null;
            this.btn_verifyTemplate.Iconimage_right_Selected = null;
            this.btn_verifyTemplate.Iconimage_Selected = null;
            this.btn_verifyTemplate.IconMarginLeft = 0;
            this.btn_verifyTemplate.IconMarginRight = 0;
            this.btn_verifyTemplate.IconRightVisible = true;
            this.btn_verifyTemplate.IconRightZoom = 0D;
            this.btn_verifyTemplate.IconVisible = true;
            this.btn_verifyTemplate.IconZoom = 90D;
            this.btn_verifyTemplate.IsTab = false;
            this.btn_verifyTemplate.Location = new System.Drawing.Point(10, 158);
            this.btn_verifyTemplate.Name = "btn_verifyTemplate";
            this.btn_verifyTemplate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verifyTemplate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_verifyTemplate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_verifyTemplate.selected = false;
            this.btn_verifyTemplate.Size = new System.Drawing.Size(191, 38);
            this.btn_verifyTemplate.TabIndex = 1;
            this.btn_verifyTemplate.Text = "Verify Using Template";
            this.btn_verifyTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verifyTemplate.Textcolor = System.Drawing.Color.White;
            this.btn_verifyTemplate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verifyTemplate.Click += new System.EventHandler(this.btn_verifyTemplate_Click);
            // 
            // btn_CheckUser
            // 
            this.btn_CheckUser.Active = false;
            this.btn_CheckUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CheckUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CheckUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CheckUser.BorderRadius = 0;
            this.btn_CheckUser.ButtonText = "Check by Username";
            this.btn_CheckUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckUser.DisabledColor = System.Drawing.Color.Gray;
            this.btn_CheckUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CheckUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_CheckUser.Iconimage")));
            this.btn_CheckUser.Iconimage_right = null;
            this.btn_CheckUser.Iconimage_right_Selected = null;
            this.btn_CheckUser.Iconimage_Selected = null;
            this.btn_CheckUser.IconMarginLeft = 0;
            this.btn_CheckUser.IconMarginRight = 0;
            this.btn_CheckUser.IconRightVisible = true;
            this.btn_CheckUser.IconRightZoom = 0D;
            this.btn_CheckUser.IconVisible = true;
            this.btn_CheckUser.IconZoom = 90D;
            this.btn_CheckUser.IsTab = false;
            this.btn_CheckUser.Location = new System.Drawing.Point(10, 451);
            this.btn_CheckUser.Name = "btn_CheckUser";
            this.btn_CheckUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CheckUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CheckUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CheckUser.selected = false;
            this.btn_CheckUser.Size = new System.Drawing.Size(191, 38);
            this.btn_CheckUser.TabIndex = 1;
            this.btn_CheckUser.Text = "Check by Username";
            this.btn_CheckUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheckUser.Textcolor = System.Drawing.Color.White;
            this.btn_CheckUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckUser.Click += new System.EventHandler(this.btn_CheckUser_Click);
            // 
            // btn_searchByIIN
            // 
            this.btn_searchByIIN.Active = false;
            this.btn_searchByIIN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_searchByIIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_searchByIIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchByIIN.BorderRadius = 0;
            this.btn_searchByIIN.ButtonText = "Search by IIN";
            this.btn_searchByIIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchByIIN.DisabledColor = System.Drawing.Color.Gray;
            this.btn_searchByIIN.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_searchByIIN.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_searchByIIN.Iconimage")));
            this.btn_searchByIIN.Iconimage_right = null;
            this.btn_searchByIIN.Iconimage_right_Selected = null;
            this.btn_searchByIIN.Iconimage_Selected = null;
            this.btn_searchByIIN.IconMarginLeft = 0;
            this.btn_searchByIIN.IconMarginRight = 0;
            this.btn_searchByIIN.IconRightVisible = true;
            this.btn_searchByIIN.IconRightZoom = 0D;
            this.btn_searchByIIN.IconVisible = true;
            this.btn_searchByIIN.IconZoom = 90D;
            this.btn_searchByIIN.IsTab = false;
            this.btn_searchByIIN.Location = new System.Drawing.Point(10, 397);
            this.btn_searchByIIN.Name = "btn_searchByIIN";
            this.btn_searchByIIN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_searchByIIN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_searchByIIN.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_searchByIIN.selected = false;
            this.btn_searchByIIN.Size = new System.Drawing.Size(191, 38);
            this.btn_searchByIIN.TabIndex = 1;
            this.btn_searchByIIN.Text = "Search by IIN";
            this.btn_searchByIIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchByIIN.Textcolor = System.Drawing.Color.White;
            this.btn_searchByIIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByIIN.Click += new System.EventHandler(this.btn_searchByIIN_Click);
            // 
            // btn_creatUser
            // 
            this.btn_creatUser.Active = false;
            this.btn_creatUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_creatUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_creatUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_creatUser.BorderRadius = 0;
            this.btn_creatUser.ButtonText = "Create User";
            this.btn_creatUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creatUser.DisabledColor = System.Drawing.Color.Gray;
            this.btn_creatUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_creatUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_creatUser.Iconimage")));
            this.btn_creatUser.Iconimage_right = null;
            this.btn_creatUser.Iconimage_right_Selected = null;
            this.btn_creatUser.Iconimage_Selected = null;
            this.btn_creatUser.IconMarginLeft = 0;
            this.btn_creatUser.IconMarginRight = 0;
            this.btn_creatUser.IconRightVisible = true;
            this.btn_creatUser.IconRightZoom = 0D;
            this.btn_creatUser.IconVisible = true;
            this.btn_creatUser.IconZoom = 90D;
            this.btn_creatUser.IsTab = false;
            this.btn_creatUser.Location = new System.Drawing.Point(10, 353);
            this.btn_creatUser.Name = "btn_creatUser";
            this.btn_creatUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_creatUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_creatUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_creatUser.selected = false;
            this.btn_creatUser.Size = new System.Drawing.Size(191, 38);
            this.btn_creatUser.TabIndex = 1;
            this.btn_creatUser.Text = "Create User";
            this.btn_creatUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creatUser.Textcolor = System.Drawing.Color.White;
            this.btn_creatUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creatUser.Click += new System.EventHandler(this.btn_creatUser_Click);
            // 
            // btn_setupDevice
            // 
            this.btn_setupDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_setupDevice.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_setupDevice.colorActive = System.Drawing.Color.Maroon;
            this.btn_setupDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setupDevice.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_setupDevice.ForeColor = System.Drawing.Color.White;
            this.btn_setupDevice.Image = ((System.Drawing.Image)(resources.GetObject("btn_setupDevice.Image")));
            this.btn_setupDevice.ImagePosition = 5;
            this.btn_setupDevice.ImageZoom = 50;
            this.btn_setupDevice.LabelPosition = 29;
            this.btn_setupDevice.LabelText = "Setup Devices";
            this.btn_setupDevice.Location = new System.Drawing.Point(10, 259);
            this.btn_setupDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_setupDevice.Name = "btn_setupDevice";
            this.btn_setupDevice.Size = new System.Drawing.Size(112, 87);
            this.btn_setupDevice.TabIndex = 0;
            this.btn_setupDevice.Click += new System.EventHandler(this.btn_setupDevice_Click);
            // 
            // btn_enroll
            // 
            this.btn_enroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_enroll.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_enroll.colorActive = System.Drawing.Color.Maroon;
            this.btn_enroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enroll.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_enroll.ForeColor = System.Drawing.Color.White;
            this.btn_enroll.Image = ((System.Drawing.Image)(resources.GetObject("btn_enroll.Image")));
            this.btn_enroll.ImagePosition = 10;
            this.btn_enroll.ImageZoom = 50;
            this.btn_enroll.LabelPosition = 29;
            this.btn_enroll.LabelText = "Enroll User";
            this.btn_enroll.Location = new System.Drawing.Point(10, 64);
            this.btn_enroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(90, 87);
            this.btn_enroll.TabIndex = 0;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // sideForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 687);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_assignRoleBtns);
            this.Controls.Add(this.btn_Identification);
            this.Controls.Add(this.btn_CloseApp);
            this.Controls.Add(this.btn_resetData);
            this.Controls.Add(this.btn_verifyTemplate);
            this.Controls.Add(this.btn_CheckUser);
            this.Controls.Add(this.btn_searchByIIN);
            this.Controls.Add(this.btn_creatUser);
            this.Controls.Add(this.btn_setupDevice);
            this.Controls.Add(this.btn_enroll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "sideForm1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu Option";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sideForm1_FormClosing);
            this.Load += new System.EventHandler(this.sideForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btn_enroll;
        private Bunifu.Framework.UI.BunifuTileButton btn_setupDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btn_creatUser;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CloseApp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_resetData;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Identification;
        private Bunifu.Framework.UI.BunifuFlatButton btn_verifyTemplate;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CheckUser;
        private Bunifu.Framework.UI.BunifuFlatButton btn_searchByIIN;
        private Bunifu.Framework.UI.BunifuFlatButton btn_assignRoleBtns;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Setting;
    }
}