namespace Clinic_Full
{
    partial class frmVisit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVisit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmb_Sec = new System.Windows.Forms.ComboBox();
            this.cmb_Serv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Doc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Pat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDate_Save = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVDate = new BPersianCalender.BPersianCalenderTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVisit
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgVisit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVisit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVisit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgVisit.Enabled = false;
            this.dtgVisit.EnableHeadersVisualStyles = false;
            this.dtgVisit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgVisit.Location = new System.Drawing.Point(0, 251);
            this.dtgVisit.Name = "dtgVisit";
            this.dtgVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVisit.Size = new System.Drawing.Size(958, 374);
            this.dtgVisit.TabIndex = 74;
            // 
            // cmb_Sec
            // 
            this.cmb_Sec.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Sec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sec.FormattingEnabled = true;
            this.cmb_Sec.Location = new System.Drawing.Point(616, 151);
            this.cmb_Sec.Name = "cmb_Sec";
            this.cmb_Sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Sec.Size = new System.Drawing.Size(334, 27);
            this.cmb_Sec.TabIndex = 76;
            // 
            // cmb_Serv
            // 
            this.cmb_Serv.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Serv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Serv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Serv.FormattingEnabled = true;
            this.cmb_Serv.Location = new System.Drawing.Point(616, 203);
            this.cmb_Serv.Name = "cmb_Serv";
            this.cmb_Serv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Serv.Size = new System.Drawing.Size(334, 27);
            this.cmb_Serv.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(884, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "نام بیمار :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(886, 77);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "نام دکتر :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(879, 129);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "نام بخش :";
            // 
            // cmb_Doc
            // 
            this.cmb_Doc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Doc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Doc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Doc.FormattingEnabled = true;
            this.cmb_Doc.Location = new System.Drawing.Point(616, 99);
            this.cmb_Doc.Name = "cmb_Doc";
            this.cmb_Doc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Doc.Size = new System.Drawing.Size(334, 27);
            this.cmb_Doc.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(868, 181);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "نام سرویس :";
            // 
            // cmb_Pat
            // 
            this.cmb_Pat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Pat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Pat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Pat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pat.FormattingEnabled = true;
            this.cmb_Pat.Location = new System.Drawing.Point(616, 47);
            this.cmb_Pat.Name = "cmb_Pat";
            this.cmb_Pat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Pat.Size = new System.Drawing.Size(334, 27);
            this.cmb_Pat.TabIndex = 81;
            this.cmb_Pat.SelectedIndexChanged += new System.EventHandler(this.cmb_Pat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(430, 47);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(126, 19);
            this.label10.TabIndex = 93;
            this.label10.Text = "تاریخ و ساعت ثبت :";
            // 
            // txtDate_Save
            // 
            this.txtDate_Save.Enabled = false;
            this.txtDate_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtDate_Save.Location = new System.Drawing.Point(218, 69);
            this.txtDate_Save.Name = "txtDate_Save";
            this.txtDate_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate_Save.Size = new System.Drawing.Size(334, 27);
            this.txtDate_Save.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(476, 99);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 95;
            this.label11.Text = "تاریخ نوبت :";
            // 
            // txtVDate
            // 
            this.txtVDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtVDate.Location = new System.Drawing.Point(218, 121);
            this.txtVDate.Miladi = new System.DateTime(((long)(0)));
            this.txtVDate.Name = "txtVDate";
            this.txtVDate.NowDateSelected = false;
            this.txtVDate.ReadOnly = true;
            this.txtVDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVDate.SelectedDate = null;
            this.txtVDate.Shamsi = null;
            this.txtVDate.Size = new System.Drawing.Size(334, 27);
            this.txtVDate.TabIndex = 97;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.FadeEffect = false;
            this.buttonX1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(23, 28);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX1.Size = new System.Drawing.Size(142, 46);
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 20F;
            this.buttonX1.TabIndex = 98;
            this.buttonX1.Text = "  ثبت اطلاعات";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX2.Enabled = false;
            this.buttonX2.FadeEffect = false;
            this.buttonX2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(23, 80);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX2.Size = new System.Drawing.Size(142, 46);
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 20F;
            this.buttonX2.TabIndex = 99;
            this.buttonX2.Text = "  چاپ اطلاعات";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.FadeEffect = false;
            this.buttonX3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(23, 132);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX3.Size = new System.Drawing.Size(142, 46);
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 20F;
            this.buttonX3.TabIndex = 100;
            this.buttonX3.Text = "  حذف اطلاعات";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX5.FadeEffect = false;
            this.buttonX5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX5.Location = new System.Drawing.Point(23, 184);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonX5.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonX5.Size = new System.Drawing.Size(142, 46);
            this.buttonX5.Symbol = "";
            this.buttonX5.SymbolSize = 20F;
            this.buttonX5.TabIndex = 102;
            this.buttonX5.Text = "  بازگشت";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // frmVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 625);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtVDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDate_Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Pat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Doc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Sec);
            this.Controls.Add(this.cmb_Serv);
            this.Controls.Add(this.dtgVisit);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(974, 664);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(974, 664);
            this.Name = "frmVisit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit Time";
            this.Load += new System.EventHandler(this.frmVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgVisit;
        private System.Windows.Forms.ComboBox cmb_Sec;
        private System.Windows.Forms.ComboBox cmb_Serv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Doc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Pat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDate_Save;
        private System.Windows.Forms.Label label11;
        private BPersianCalender.BPersianCalenderTextBox txtVDate;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX5;
    }
}