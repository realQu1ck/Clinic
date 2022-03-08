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
    public partial class frmEditSec : DevComponents.DotNetBar.OfficeForm
    {
        public frmEditSec()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmEditSec_Load(object sender, EventArgs e)
        {
            dtgSec.AutoGenerateColumns = false;

            dtgSec.ColumnCount = 2;

            dtgSec.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgSec.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgSec.DefaultCellStyle.BackColor = Color.White;

            this.dtgSec.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            this.dtgSec.DefaultCellStyle.SelectionForeColor = Color.Black;

            dtgSec.Columns[0].Name = "ID";
            dtgSec.Columns[0].DataPropertyName = "ID";
            dtgSec.Columns[0].HeaderText = "ID";

            dtgSec.Columns[1].Name = "title";
            dtgSec.Columns[1].DataPropertyName = "title";
            dtgSec.Columns[1].HeaderText = "نام";

            dtgSec.DataSource = objDB.Tbl_Section.ToList();

            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;
        }
        int GridID;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                var query = objDB.Tbl_Section.ToList().Find(x => x.ID == GridID);

                query.title = txtName.Text;

                objDB.SaveChanges();

                dtgSec.DataSource = objDB.Tbl_Section.ToList();
                MessageBox.Show(". عملیات ویرایش موفقیت آمیز بود ", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }

        private void dtgSec_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgSec.Rows[e.RowIndex].Cells["ID"].Value;

            objDB.Tbl_Section.Where(s => s.ID == GridID);

            txtName.Text = objDB.Tbl_Section.ToList().Find(s => s.ID == GridID).title;
        }
    }
}
