namespace Clinic_Full
{
    partial class frmSaveDoc
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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtAdrs = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeliCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmb_Serv = new System.Windows.Forms.ComboBox();
            this.cmb_Sec = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResume = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(231, 30);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX2.Size = new System.Drawing.Size(108, 96);
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 25F;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "بازگشت";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 150);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "منو ها";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX3.Location = new System.Drawing.Point(345, 30);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX3.Size = new System.Drawing.Size(108, 96);
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 25F;
            this.buttonX3.TabIndex = 32;
            this.buttonX3.Text = "خروج از برنامه";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(119, 30);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX1.Size = new System.Drawing.Size(108, 96);
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 25F;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "ثبت اطلاعات";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblUser.Location = new System.Drawing.Point(939, 7);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "کلینیک";
            // 
            // txtAdrs
            // 
            this.txtAdrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtAdrs.Border.Class = "TextBoxBorder";
            this.txtAdrs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdrs.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAdrs.Location = new System.Drawing.Point(654, 277);
            this.txtAdrs.Name = "txtAdrs";
            this.txtAdrs.PreventEnterBeep = true;
            this.txtAdrs.Size = new System.Drawing.Size(438, 33);
            this.txtAdrs.TabIndex = 37;
            this.txtAdrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdrs.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtAdrs.WatermarkText = "آدرس";
            // 
            // txtTell
            // 
            this.txtTell.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtTell.Border.Class = "TextBoxBorder";
            this.txtTell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTell.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTell.Location = new System.Drawing.Point(654, 199);
            this.txtTell.Name = "txtTell";
            this.txtTell.PreventEnterBeep = true;
            this.txtTell.Size = new System.Drawing.Size(438, 33);
            this.txtTell.TabIndex = 35;
            this.txtTell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTell.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtTell.WatermarkText = "تلفن";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(654, 160);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(438, 33);
            this.txtName.TabIndex = 34;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtName.WatermarkText = "نام و نام خانوادگی";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(918, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "|";
            // 
            // txtNcode
            // 
            this.txtNcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNcode.Border.Class = "TextBoxBorder";
            this.txtNcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtNcode.Location = new System.Drawing.Point(654, 316);
            this.txtNcode.Name = "txtNcode";
            this.txtNcode.PreventEnterBeep = true;
            this.txtNcode.Size = new System.Drawing.Size(438, 33);
            this.txtNcode.TabIndex = 38;
            this.txtNcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNcode.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtNcode.WatermarkText = "کد";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Shekari", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "ثبت اطلاعات دکتر جدید";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "ثبت اطلاعات دکتر جدید";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 143);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Shekari", 65F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(510, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 129);
            this.label3.TabIndex = 0;
            this.label3.Text = "کلینیک تخصصی مدرن";
            // 
            // txtMeliCode
            // 
            this.txtMeliCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtMeliCode.Border.Class = "TextBoxBorder";
            this.txtMeliCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMeliCode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtMeliCode.Location = new System.Drawing.Point(654, 238);
            this.txtMeliCode.Name = "txtMeliCode";
            this.txtMeliCode.PreventEnterBeep = true;
            this.txtMeliCode.Size = new System.Drawing.Size(438, 33);
            this.txtMeliCode.TabIndex = 36;
            this.txtMeliCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMeliCode.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtMeliCode.WatermarkText = "کد ملی";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 30);
            this.panel1.TabIndex = 41;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(832, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "کلینیک";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX4.Location = new System.Drawing.Point(243, 355);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3);
            this.buttonX4.Size = new System.Drawing.Size(88, 28);
            this.buttonX4.Symbol = "58835";
            this.buttonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX4.SymbolSize = 25F;
            this.buttonX4.TabIndex = 52;
            this.buttonX4.Text = "انتخاب";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cmb_Serv
            // 
            this.cmb_Serv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Serv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Serv.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmb_Serv.FormattingEnabled = true;
            this.cmb_Serv.Location = new System.Drawing.Point(654, 355);
            this.cmb_Serv.Name = "cmb_Serv";
            this.cmb_Serv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Serv.Size = new System.Drawing.Size(438, 34);
            this.cmb_Serv.TabIndex = 53;
            this.cmb_Serv.SelectedIndexChanged += new System.EventHandler(this.cmb_Serv_SelectedIndexChanged);
            // 
            // cmb_Sec
            // 
            this.cmb_Sec.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Sec.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmb_Sec.FormattingEnabled = true;
            this.cmb_Sec.Location = new System.Drawing.Point(654, 395);
            this.cmb_Sec.Name = "cmb_Sec";
            this.cmb_Sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Sec.Size = new System.Drawing.Size(438, 34);
            this.cmb_Sec.TabIndex = 54;
            this.cmb_Sec.SelectedIndexChanged += new System.EventHandler(this.cmb_Sec_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(30, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtResume
            // 
            this.txtResume.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtResume.Border.Class = "TextBoxBorder";
            this.txtResume.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtResume.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtResume.Location = new System.Drawing.Point(243, 160);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.PreventEnterBeep = true;
            this.txtResume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResume.Size = new System.Drawing.Size(405, 189);
            this.txtResume.TabIndex = 55;
            this.txtResume.WatermarkImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.txtResume.WatermarkText = "سابقه";
            // 
            // frmSaveDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.cmb_Sec);
            this.Controls.Add(this.cmb_Serv);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdrs);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMeliCode);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1111, 671);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1111, 671);
            this.Name = "frmSaveDoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveDoctor";
            this.Load += new System.EventHandler(this.frmSaveDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label lblUser;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdrs;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTell;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMeliCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmb_Serv;
        private System.Windows.Forms.ComboBox cmb_Sec;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResume;
    }
}