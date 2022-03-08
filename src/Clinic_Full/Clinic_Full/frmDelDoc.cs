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
    public partial class frmDelDoc : DevComponents.DotNetBar.OfficeForm
    {
        public frmDelDoc()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmDelDoc_Load(object sender, EventArgs e)
        {
            dtgDoc.AutoGenerateColumns = false;

            dtgDoc.ColumnCount = 9;

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
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int GridID;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = objDB.SP_DelDoc(GridID);
                if (i != 0)
                {
                    MessageBox.Show(" . عملیات حذف موفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" . عملیات حذف ناموفق بود  ", " Delete ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtgDoc.DataSource = objDB.Tbl_Doctors.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgDoc.Rows[e.RowIndex].Cells["ID"].Value;
        }
    }
}
