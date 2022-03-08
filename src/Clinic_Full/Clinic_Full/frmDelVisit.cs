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
    public partial class frmDelVisit : DevComponents.DotNetBar.OfficeForm
    {
        public frmDelVisit()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmDelVisit_Load(object sender, EventArgs e)
        {

            dtgVisit.AutoGenerateColumns = false;

            dtgVisit.ColumnCount = 7;

            dtgVisit.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgVisit.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgVisit.DefaultCellStyle.BackColor = Color.White;

            this.dtgVisit.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            this.dtgVisit.DefaultCellStyle.SelectionForeColor = Color.Black;

            dtgVisit.Columns[6].Name = "ID";
            dtgVisit.Columns[6].DataPropertyName = "ID";
            dtgVisit.Columns[6].HeaderText = "ID";

            dtgVisit.Columns[0].Name = "PatID";
            dtgVisit.Columns[0].DataPropertyName = "PatID";
            dtgVisit.Columns[0].HeaderText = "شماره بیمار";

            dtgVisit.Columns[1].Name = "DocID";
            dtgVisit.Columns[1].DataPropertyName = "DocID";
            dtgVisit.Columns[1].HeaderText = "شماره دکتر ";

            dtgVisit.Columns[2].Name = "SecID";
            dtgVisit.Columns[2].DataPropertyName = "SecID";
            dtgVisit.Columns[2].HeaderText = "ششماره بخش";
            dtgVisit.Columns[2].Width = 80;

            dtgVisit.Columns[3].Name = "ServID";
            dtgVisit.Columns[3].DataPropertyName = "ServID";
            dtgVisit.Columns[3].HeaderText = "شماره سرویس";

            dtgVisit.Columns[4].Name = "Time_Date";
            dtgVisit.Columns[4].DataPropertyName = "Time_Date";
            dtgVisit.Columns[4].HeaderText = "تاریخ ثبت";

            dtgVisit.Columns[5].Name = "VTime";
            dtgVisit.Columns[5].DataPropertyName = "VTime";
            dtgVisit.Columns[5].HeaderText = "تاریخ نوبت";

            var userVisit = objDB.Tbl_VisitTime.Where(x => x.LoginCode == Trans.NCode).ToList();
            dtgVisit.DataSource = userVisit.ToList();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int GridID;
        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                int i = objDB.SP_DelVisit(GridID);
                if (i != 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(" . عملیات حذف موفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(" . عملیات حذف ناموفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var userVisit = objDB.Tbl_VisitTime.Where(x => x.LoginCode == Trans.NCode).ToList();
                dtgVisit.DataSource = userVisit.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgVisit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgVisit.Rows[e.RowIndex].Cells["ID"].Value;
        }
    }
}
