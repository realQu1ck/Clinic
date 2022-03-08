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
    public partial class frmDelServ : DevComponents.DotNetBar.OfficeForm
    {
        public frmDelServ()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmDelServ_Load(object sender, EventArgs e)
        {
            dtgServ.AutoGenerateColumns = false;

            dtgServ.ColumnCount = 3;

            dtgServ.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgServ.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgServ.DefaultCellStyle.BackColor = Color.White;

            this.dtgServ.DefaultCellStyle.SelectionBackColor = Color.Blue;
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
        }
        int GridID;
        private void dtgServ_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgServ.Rows[e.RowIndex].Cells["ID"].Value;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = objDB.SP_DelServ(GridID);
                if (i != 0)
                {
                    MessageBox.Show(" . عملیات حذف موفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" . عملیات حذف ناموفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgServ.DataSource = objDB.Tbl_Services.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
