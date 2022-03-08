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
    public partial class frmEditPat : DevComponents.DotNetBar.OfficeForm
    {
        public frmEditPat()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmEditPat_Load(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ////////////////////////////////////////////////////////////////
            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;
        }
        int GridID = 0;
        private void dtgPat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgPat.Rows[e.RowIndex].Cells["ID"].Value;

            objDB.Tbl_Patient.Where(s => s.ID == GridID);

            txtName.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).Name_Family;
            txtNcode.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).NCodePat;
            txtMeliCode.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).MeliCode;
            txtTell.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).Tell;
            txtAdrs.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).Adrs;
            txtTime.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).Time;
            txtDate.Text = objDB.Tbl_Patient.ToList().Find(s => s.ID == GridID).Date;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("برای خروج از برنامه اطمینان دارید ؟", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                var query = objDB.Tbl_Patient.ToList().Find(x => x.ID == GridID);

                query.Name_Family = txtName.Text;
                query.Tell = txtTell.Text;
                query.MeliCode = txtMeliCode.Text;
                query.Adrs = txtAdrs.Text;
                query.Date = txtDate.Text;
                query.Time = txtTime.Text;
                query.NCodePat = txtNcode.Text;

                objDB.SaveChanges();

                var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();
                dtgPat.DataSource = user.ToList();
                MessageBox.Show(". عملیات ویرایش موفقیت آمیز بود " ,"Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
