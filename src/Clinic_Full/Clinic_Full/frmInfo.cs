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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmInfo_Load(object sender, EventArgs e)
        {
            try
            {
                dtgPat.AutoGenerateColumns = false;

                dtgPat.ColumnCount = 4;

                dtgPat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                this.dtgPat.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgPat.DefaultCellStyle.BackColor = Color.White;

                this.dtgPat.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                this.dtgPat.DefaultCellStyle.SelectionForeColor = Color.Black;

                dtgPat.Columns[0].Name = "Name_Family";
                dtgPat.Columns[0].DataPropertyName = "Name_Family";
                dtgPat.Columns[0].HeaderText = "نام";

                dtgPat.Columns[1].Name = "Tell";
                dtgPat.Columns[1].DataPropertyName = "Tell";
                dtgPat.Columns[1].HeaderText = "شماره تلفن ";

                dtgPat.Columns[3].Name = "Adrs";
                dtgPat.Columns[3].DataPropertyName = "Adrs";
                dtgPat.Columns[3].HeaderText = "آدرس";
                dtgPat.Columns[3].Width = 80;

                dtgPat.Columns[2].Name = "MeliCode";
                dtgPat.Columns[2].DataPropertyName = "MeliCode";
                dtgPat.Columns[2].HeaderText = "شماره ملی";

                dtgPat.Columns[3].Name = "NCodePat";
                dtgPat.Columns[3].DataPropertyName = "NCodePat";
                dtgPat.Columns[3].HeaderText = "شماره";

                var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();
                dtgPat.DataSource = user.ToList();
                ///////////////////////////////////////////////////////////////////////////////////////
                dtgDoc.AutoGenerateColumns = false;

                dtgDoc.ColumnCount = 6;

                dtgDoc.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                this.dtgDoc.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgDoc.DefaultCellStyle.BackColor = Color.White;

                this.dtgDoc.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                this.dtgDoc.DefaultCellStyle.SelectionForeColor = Color.Black;

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

                dtgDoc.DataSource = objDB.Tbl_Doctors.ToList();
                ///////////////////////////////////////////////////////////////////////////////////////
                dtgSec.AutoGenerateColumns = false;

                dtgSec.ColumnCount = 1;

                dtgSec.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                this.dtgSec.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgSec.DefaultCellStyle.BackColor = Color.White;

                this.dtgSec.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                this.dtgSec.DefaultCellStyle.SelectionForeColor = Color.Black;

                dtgSec.Columns[0].Name = "title";
                dtgSec.Columns[0].DataPropertyName = "title";
                dtgSec.Columns[0].HeaderText = "نام";

                dtgSec.DataSource = objDB.Tbl_Section.ToList();
                ///////////////////////////////////////////////////////////////////////////////////////
                dtgServ.AutoGenerateColumns = false;

                dtgServ.ColumnCount = 2;

                dtgServ.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                this.dtgServ.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgServ.DefaultCellStyle.BackColor = Color.White;

                this.dtgServ.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                this.dtgServ.DefaultCellStyle.SelectionForeColor = Color.Black;

                dtgServ.Columns[0].Name = "title";
                dtgServ.Columns[0].DataPropertyName = "title";
                dtgServ.Columns[0].HeaderText = "نام";

                dtgServ.Columns[1].Name = "SecID";
                dtgServ.Columns[1].DataPropertyName = "SecID";
                dtgServ.Columns[1].HeaderText = "بخش";

                dtgServ.DataSource = objDB.Tbl_Services.ToList();

                var count = objDB.SP_CountPat();
                GPat.Value = (count.SingleOrDefault().Value);
   
                var count1 = objDB.SP_CountDoc();
                GDoc.Value = (count1.SingleOrDefault().Value);

                var count2 = objDB.SP_CountSec();
                GSec.Value = (count2.SingleOrDefault().Value);

                var count3 = objDB.SP_CountServ();
                GServ.Value = (count3.SingleOrDefault().Value);

            }
            catch (Exception a)
            {

                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  " + a, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ///////////////////////////////////////////////////////////////////////


    }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
