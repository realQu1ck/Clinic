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
    public partial class frmEditServ : DevComponents.DotNetBar.OfficeForm
    {
        public frmEditServ()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmEditServ_Load(object sender, EventArgs e)
        {
            dtgServ.AutoGenerateColumns = false;

            dtgServ.ColumnCount = 3;

            dtgServ.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgServ.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgServ.DefaultCellStyle.BackColor = Color.White;

            this.dtgServ.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            this.dtgServ.DefaultCellStyle.SelectionForeColor = Color.Black;

            dtgServ.Columns[0].Name = "ID";
            dtgServ.Columns[0].DataPropertyName = "ID";
            dtgServ.Columns[0].HeaderText = "شماره"; 

            dtgServ.Columns[1].Name = "title";
            dtgServ.Columns[1].DataPropertyName = "title";
            dtgServ.Columns[1].HeaderText = "نام";

            dtgServ.Columns[2].Name = "SecID";
            dtgServ.Columns[2].DataPropertyName = "SecID";
            dtgServ.Columns[2].HeaderText = "بخش";

            dtgServ.DataSource = objDB.Tbl_Services.ToList();

            cmb_Sec.DisplayMember = "title";
            cmb_Sec.ValueMember = "ID";
            cmb_Sec.DataSource = objDB.Tbl_Section.ToList();

            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        int Sec;
        int GridID;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                var query = objDB.Tbl_Services.ToList().Find(x => x.ID == GridID);

                query.title = txtName.Text;
                query.SecID = Sec;

                objDB.SaveChanges();

                dtgServ.DataSource = objDB.Tbl_Services.ToList();
                MessageBox.Show(". عملیات ویرایش موفقیت آمیز بود ", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgServ_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgServ.Rows[e.RowIndex].Cells["ID"].Value;

            objDB.Tbl_Services.Where(s => s.ID == GridID);

            txtName.Text = objDB.Tbl_Services.ToList().Find(s => s.ID == GridID).title;
            Sec = (int)objDB.Tbl_Services.ToList().Find(s => s.ID == GridID).SecID;

            cmb_Sec.SelectedValue = Sec;

        }
    }
}
