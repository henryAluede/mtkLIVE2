namespace DermalogMultiScannerDemo.winforms
{
    partial class CreateRoleForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoleForm1));
            this.btn_Add = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_show = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_generateBtnList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(206, 169);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(70, 24);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add >>";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(206, 210);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(70, 24);
            this.Btn_Remove.TabIndex = 3;
            this.Btn_Remove.Text = "<< Remove ";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Enrolment",
            "Verification"});
            this.comboBox1.Location = new System.Drawing.Point(23, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_show
            // 
            this.btn_show.Active = false;
            this.btn_show.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show.BorderRadius = 0;
            this.btn_show.ButtonText = "Save Role Access";
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.DisabledColor = System.Drawing.Color.Gray;
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
            this.btn_show.Location = new System.Drawing.Point(112, 311);
            this.btn_show.Name = "btn_show";
            this.btn_show.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_show.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_show.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show.selected = false;
            this.btn_show.Size = new System.Drawing.Size(182, 33);
            this.btn_show.TabIndex = 29;
            this.btn_show.Text = "Save Role Access";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.Textcolor = System.Drawing.Color.White;
            this.btn_show.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_close.Location = new System.Drawing.Point(306, 311);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(151, 33);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "Close Window";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_generateBtnList
            // 
            this.btn_generateBtnList.Active = false;
            this.btn_generateBtnList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_generateBtnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_generateBtnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generateBtnList.BorderRadius = 0;
            this.btn_generateBtnList.ButtonText = "Generate ButtonsList";
            this.btn_generateBtnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generateBtnList.DisabledColor = System.Drawing.Color.Gray;
            this.btn_generateBtnList.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_generateBtnList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_generateBtnList.Iconimage")));
            this.btn_generateBtnList.Iconimage_right = null;
            this.btn_generateBtnList.Iconimage_right_Selected = null;
            this.btn_generateBtnList.Iconimage_Selected = null;
            this.btn_generateBtnList.IconMarginLeft = 0;
            this.btn_generateBtnList.IconMarginRight = 0;
            this.btn_generateBtnList.IconRightVisible = true;
            this.btn_generateBtnList.IconRightZoom = 0D;
            this.btn_generateBtnList.IconVisible = true;
            this.btn_generateBtnList.IconZoom = 90D;
            this.btn_generateBtnList.IsTab = false;
            this.btn_generateBtnList.Location = new System.Drawing.Point(282, 63);
            this.btn_generateBtnList.Name = "btn_generateBtnList";
            this.btn_generateBtnList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_generateBtnList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_generateBtnList.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_generateBtnList.selected = false;
            this.btn_generateBtnList.Size = new System.Drawing.Size(175, 33);
            this.btn_generateBtnList.TabIndex = 31;
            this.btn_generateBtnList.Text = "Generate ButtonsList";
            this.btn_generateBtnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generateBtnList.Textcolor = System.Drawing.Color.White;
            this.btn_generateBtnList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateBtnList.Click += new System.EventHandler(this.btn_generateBtnList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(154, 186);
            this.listBox1.TabIndex = 32;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(295, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(154, 186);
            this.listBox2.TabIndex = 33;
            // 
            // CreateRoleForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 356);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_generateBtnList);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "CreateRoleForm1";
            //this.Resizable = false;
            this.Text = "Add Buttons to Role";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton btn_generateBtnList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}