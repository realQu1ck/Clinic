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
    public partial class frmSrchServ : DevComponents.DotNetBar.OfficeForm
    {
        public frmSrchServ()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmSrchServ_Load(object sender, EventArgs e)
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

            cmb_Srch.Items.Add("نام سرویس");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (cmb_Srch.Text == "نام سرویس")
            {
                var querySrch = objDB.Tbl_Services.Where(s => s.title.Contains(txtName.Text));
                dtgServ.DataSource = querySrch.ToList();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Srch.Text == "نام سرویس")
            {
                var querySrch = objDB.Tbl_Services.Where(s => s.title.Contains(txtName.Text));
                dtgServ.DataSource = querySrch.ToList();
            }
        }
    }
}
