using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Full
{
    public partial class frmSrchPat : DevComponents.DotNetBar.OfficeForm
    {
        public frmSrchPat()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
       
        private void frmSrchPat_Load(object sender, EventArgs e)
        {
            try
            {
                dtgPat.ColumnCount = 8;

                dtgPat.AutoGenerateColumns = false;

                dtgPat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                this.dtgPat.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgPat.DefaultCellStyle.BackColor = Color.White;

                this.dtgPat.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                this.dtgPat.DefaultCellStyle.SelectionForeColor = Color.Black;

                dtgPat.Columns[0].Name = "ID";
                dtgPat.Columns[0].DataPropertyName = "ID";
                dtgPat.Columns[0].HeaderText = "شماره ";

                dtgPat.Columns[1].Name = "Name_Family";
                dtgPat.Columns[1].DataPropertyName = "Name_Family";
                dtgPat.Columns[1].HeaderText = "نام بیمار";

                dtgPat.Columns[3].Name = "Tell";
                dtgPat.Columns[3].DataPropertyName = "Tell";
                dtgPat.Columns[3].HeaderText = "شماره همراه";
                dtgPat.Columns[3].Width = 80;


                dtgPat.Columns[4].Name = "Adrs";
                dtgPat.Columns[4].DataPropertyName = "Adrs";
                dtgPat.Columns[4].HeaderText = "آدرس";
                dtgPat.Columns[4].Width = 100;

                dtgPat.Columns[2].Name = "MeliCode";
                dtgPat.Columns[2].DataPropertyName = "MeliCode";
                dtgPat.Columns[2].HeaderText = "کد ملی";
                dtgPat.Columns[2].Width = 80;

                dtgPat.Columns[5].Name = "Date";
                dtgPat.Columns[5].DataPropertyName = "Date";
                dtgPat.Columns[5].HeaderText = "تاریخ";
                dtgPat.Columns[5].Width = 80;

                dtgPat.Columns[6].Name = "Time";
                dtgPat.Columns[6].DataPropertyName = "Time";
                dtgPat.Columns[6].HeaderText = "ساعت";
                dtgPat.Columns[6].Width = 80;

                dtgPat.Columns[7].Name = "NCodePat";
                dtgPat.Columns[7].DataPropertyName = "NCodePat";
                dtgPat.Columns[7].HeaderText = "کد";
                dtgPat.Columns[7].Width = 80;

                var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();
                dtgPat.DataSource = user.ToList();

                cmb_Srch.Items.Add("نام و نام  خانوادگی");
                cmb_Srch.Items.Add("شماره همراه");
                cmb_Srch.Items.Add("آدرس");
                cmb_Srch.Items.Add("کد ملی");
                cmb_Srch.Items.Add("کد");
                cmb_Srch.Items.Add("تاریخ");
                cmb_Srch.Items.Add("ساعت");
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();
            if (cmb_Srch.Text == "نام و نام  خانوادگی")
            {
                var querySrch = user.Where(s => s.Name_Family.Contains(txtName.Text));
                dtgPat.DataSource = querySrch.ToList();
            }
            if (cmb_Srch.Text == "شماره همراه")
            {
                var querySrch7 = user.Where(s => s.Tell.Contains(txtName.Text));
                dtgPat.DataSource = querySrch7.ToList();
            }
            if (cmb_Srch.Text == "آدرس")
            {
                var querySrch2 = user.Where(s => s.Adrs.Contains(txtName.Text));
                dtgPat.DataSource = querySrch2.ToList();
            }
            if (cmb_Srch.Text == "کد ملی")
            {
                var querySrch3 = user.Where(s => s.MeliCode.Contains(txtName.Text));
                dtgPat.DataSource = querySrch3.ToList();
            }
            if (cmb_Srch.Text == "کد")
            {
                var querySrch4 = user.Where(s => s.NCodePat.Contains(txtName.Text));
                dtgPat.DataSource = querySrch4.ToList();
            }
            if (cmb_Srch.Text == "تاریخ")
            {
                var querySrch5 = user.Where(s => s.Date.Contains(txtName.Text));
                dtgPat.DataSource = querySrch5.ToList();
            }
            if (cmb_Srch.Text == "ساعت")
            {
                var querySrch6 = user.Where(s => s.Time.Contains(txtName.Text));
                dtgPat.DataSource = querySrch6.ToList();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();
            if (cmb_Srch.Text == "نام و نام  خانوادگی")
            {
                var querySrch = user.Where(s => s.Name_Family.Contains(txtName.Text));
                dtgPat.DataSource = querySrch.ToList();
            }
            if (cmb_Srch.Text == "شماره همراه")
            {
                var querySrch7 = user.Where(s => s.Tell.Contains(txtName.Text));
                dtgPat.DataSource = querySrch7.ToList();
            }
            if (cmb_Srch.Text == "آدرس")
            {
                var querySrch2 = user.Where(s => s.Adrs.Contains(txtName.Text));
                dtgPat.DataSource = querySrch2.ToList();
            }
            if (cmb_Srch.Text == "کد ملی")
            {
                var querySrch3 = user.Where(s => s.MeliCode.Contains(txtName.Text));
                dtgPat.DataSource = querySrch3.ToList();
            }
            if (cmb_Srch.Text == "کد")
            {
                var querySrch4 = user.Where(s => s.NCodePat.Contains(txtName.Text));
                dtgPat.DataSource = querySrch4.ToList();
            }
            if (cmb_Srch.Text == "تاریخ")
            {
                var querySrch5 = user.Where(s => s.Date.Contains(txtName.Text));
                dtgPat.DataSource = querySrch5.ToList();
            }
            if (cmb_Srch.Text == "ساعت")
            {
                var querySrch6 = user.Where(s => s.Time.Contains(txtName.Text));
                dtgPat.DataSource = querySrch6.ToList();
            }

        }
     
        private void buttonX2_Click(object sender, EventArgs e)
        {

              
        }
        private void dtgPat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          

        }
    }
}