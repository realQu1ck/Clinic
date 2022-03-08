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
    public partial class frmSrchSec : DevComponents.DotNetBar.OfficeForm
    {
        public frmSrchSec()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmSrchSec_Load(object sender, EventArgs e)
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

            cmb_Srch.Items.Add("نام بخش");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (cmb_Srch.Text == "نام بخش")
            {
                var querySrch = objDB.Tbl_Section.Where(s => s.title.Contains(txtName.Text));
                dtgSec.DataSource = querySrch.ToList();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Srch.Text == "نام بخش")
            {
                var querySrch = objDB.Tbl_Section.Where(s => s.title.Contains(txtName.Text));
                dtgSec.DataSource = querySrch.ToList();
            }
        }
    }
}
