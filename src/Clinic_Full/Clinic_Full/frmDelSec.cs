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
    public partial class frmDelSec : DevComponents.DotNetBar.OfficeForm
    {
        public frmDelSec()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
       private void frmDelSec_Load(object sender, EventArgs e)
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
        }
        int GridID;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = objDB.SP_DelSec(GridID);
                if (i != 0)
                {
                    MessageBox.Show(" . عملیات حذف موفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" . عملیات حذف ناموفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgSec.DataSource = objDB.Tbl_Section.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgSec_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgSec.Rows[e.RowIndex].Cells["ID"].Value;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
