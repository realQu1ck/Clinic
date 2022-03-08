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
    public partial class frmSrchDoc : DevComponents.DotNetBar.OfficeForm
    {
        public frmSrchDoc()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmSrchDoc_Load(object sender, EventArgs e)
        {
            dtgDoc.AutoGenerateColumns = false;

            dtgDoc.ColumnCount = 9;

            dtgDoc.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgDoc.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgDoc.DefaultCellStyle.BackColor = Color.White;

            this.dtgDoc.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            this.dtgDoc.DefaultCellStyle.SelectionForeColor = Color.Black;

            dtgDoc.Columns[8].Name = "ID";
            dtgDoc.Columns[8].DataPropertyName = "ID";
            dtgDoc.Columns[8].HeaderText = "ID";

            dtgDoc.Columns[0].Name = "Name_Family";
            dtgDoc.Columns[0].DataPropertyName = "Name_Family";
            dtgDoc.Columns[0].HeaderText = "نام";

            dtgDoc.Columns[1].Name = "Tell";
            dtgDoc.Columns[1].DataPropertyName = "Tell";
            dtgDoc.Columns[1].HeaderText = "شماره تلفن ";

            dtgDoc.Columns[2].Name = "Adrs";
            dtgDoc.Columns[2].DataPropertyName = "Adrs";
            dtgDoc.Columns[2].HeaderText = "آدرس";
            dtgDoc.Columns[2].Width = 80;

            dtgDoc.Columns[3].Name = "MeliCode";
            dtgDoc.Columns[3].DataPropertyName = "MeliCode";
            dtgDoc.Columns[3].HeaderText = "شماره ملی";

            dtgDoc.Columns[4].Name = "Ncode";
            dtgDoc.Columns[4].DataPropertyName = "Ncode";
            dtgDoc.Columns[4].HeaderText = "شماره";

            dtgDoc.Columns[5].Name = "Resume";
            dtgDoc.Columns[5].DataPropertyName = "Resume";
            dtgDoc.Columns[5].HeaderText = "سابقه";

            dtgDoc.Columns[6].Name = "SecID";
            dtgDoc.Columns[6].DataPropertyName = "SecID";
            dtgDoc.Columns[6].HeaderText = "شماره سرویس";

            dtgDoc.Columns[7].Name = "ServID";
            dtgDoc.Columns[7].DataPropertyName = "ServID";
            dtgDoc.Columns[7].HeaderText = "شماره بخش";


            dtgDoc.DataSource = objDB.Tbl_Doctors.ToList();

            cmb_Srch.Items.Add("نام و نام  خانوادگی");
            cmb_Srch.Items.Add("شماره همراه");
            cmb_Srch.Items.Add("آدرس");
            cmb_Srch.Items.Add("کد ملی");
            cmb_Srch.Items.Add("کد");
            cmb_Srch.Items.Add("سابقه");
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (cmb_Srch.Text == "نام و نام  خانوادگی")
            {
                var querySrch = objDB.Tbl_Doctors.Where(s => s.Name_Family.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch.ToList();
            }
            if (cmb_Srch.Text == "شماره همراه")
            {
                var querySrch1 = objDB.Tbl_Doctors.Where(s => s.Tell.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch1.ToList();
            }
            if (cmb_Srch.Text == "آدرس")
            {
                var querySrch2 = objDB.Tbl_Doctors.Where(s => s.Adrs.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch2.ToList();
            }
            if (cmb_Srch.Text == "کد ملی")
            {
                var querySrch3 = objDB.Tbl_Doctors.Where(s => s.MeliCode.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch3.ToList();
            }
            if (cmb_Srch.Text == "کد")
            {
                var querySrch4 = objDB.Tbl_Doctors.Where(s => s.Ncode.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch4.ToList();
            }
            if (cmb_Srch.Text == "سابقه")
            {
                var querySrch5 = objDB.Tbl_Doctors.Where(s => s.Resume.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch5.ToList();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Srch.Text == "نام و نام  خانوادگی")
            {
                var querySrch = objDB.Tbl_Doctors.Where(s => s.Name_Family.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch.ToList();
            }
            if (cmb_Srch.Text == "شماره همراه")
            {
                var querySrch1 = objDB.Tbl_Doctors.Where(s => s.Tell.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch1.ToList();
            }
            if (cmb_Srch.Text == "آدرس")
            {
                var querySrch2 = objDB.Tbl_Doctors.Where(s => s.Adrs.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch2.ToList();
            }
            if (cmb_Srch.Text == "کد ملی")
            {
                var querySrch3 = objDB.Tbl_Doctors.Where(s => s.MeliCode.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch3.ToList();
            }
            if (cmb_Srch.Text == "کد")
            {
                var querySrch4 = objDB.Tbl_Doctors.Where(s => s.Ncode.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch4.ToList();
            }
            if (cmb_Srch.Text == "سابقه")
            {
                var querySrch5 = objDB.Tbl_Doctors.Where(s => s.Resume.Contains(txtName.Text));
                dtgDoc.DataSource = querySrch5.ToList();
            }
        }
    }
}