using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Full
{
    public partial class frmVisit : DevComponents.DotNetBar.OfficeForm
    {
        public frmVisit()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmVisit_Load(object sender, EventArgs e)
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

            var user = objDB.Tbl_Patient.Where(x => x.LoginCode == Trans.NCode).ToList();

            cmb_Sec.DisplayMember = "title";
            cmb_Sec.ValueMember = "ID";
            cmb_Sec.DataSource = objDB.Tbl_Section.ToList();

            cmb_Serv.DisplayMember = "title";
            cmb_Serv.ValueMember = "ID";
            cmb_Serv.DataSource = objDB.Tbl_Services.ToList();

            cmb_Doc.DisplayMember = "Name_Family";
            cmb_Doc.ValueMember = "ID";
            cmb_Doc.DataSource = objDB.Tbl_Doctors.ToList();

            cmb_Pat.DisplayMember = "Name_Family";
            cmb_Pat.ValueMember = "ID";
            cmb_Pat.DataSource = user.ToList();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            string Time = PC.GetHour(DateTime.Now) + ":" + PC.GetMinute(DateTime.Now) + ":" + PC.GetSecond(DateTime.Now);
            string Date = PC.GetYear(DateTime.Now) + "-" + PC.GetMonth(DateTime.Now) + "-" + PC.GetDayOfMonth(DateTime.Now);
            txtDate_Save.Text = Time + " " + Date;
        }
        int ID;
        private void cmb_Pat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_Tell_Pat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Pat_NC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_MeliCodePat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Tbl_VisitTime objVisit = new Model.Tbl_VisitTime();
                Model.View_1 objVisit1 = new Model.View_1();
                Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();

                objVisit.PatID = (int)cmb_Pat.SelectedValue;
                objVisit.DocID = (int)cmb_Doc.SelectedValue;
                objVisit.SecID = (int)cmb_Sec.SelectedValue;
                objVisit.ServID = (int)cmb_Serv.SelectedValue;
                objVisit.Time_Date = txtDate_Save.Text;
                objVisit.VTime = txtVDate.Text;
                objVisit.LoginCode = Trans.NCode;
                objVisit.LoginName = Trans.Username;

                objDB.Tbl_VisitTime.Add(objVisit);

                objDB.SaveChanges();

                var userVisit = objDB.Tbl_VisitTime.Where(x => x.LoginCode == Trans.NCode).ToList();
                dtgVisit.DataSource = userVisit.ToList();

                ClsVisit.Pat = cmb_Pat.Text.ToString();
                ClsVisit.Doc = cmb_Doc.Text.ToString();
                ClsVisit.Sec = cmb_Sec.SelectedText;
                ClsVisit.Serv = cmb_Serv.SelectedText;
                ClsVisit.SDate = txtDate_Save.Text;
                ClsVisit.VTime = txtVDate.Text;

                DevExpress.XtraEditors.XtraMessageBox.Show(".اطلاعات ثبت شد", " Save ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonX2.Enabled = true;
            }
            catch (Exception a)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(" . خطا در متصل شدن به دیتابیس  " + a, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ClsVisit.Pat = cmb_Pat.Text.ToString();
            ClsVisit.Doc = cmb_Doc.Text.ToString();
            ClsVisit.Sec = cmb_Sec.Text.ToString();
            ClsVisit.Serv = cmb_Serv.Text.ToString();
            ClsVisit.SDate = txtDate_Save.Text.ToString();
            ClsVisit.VTime = txtVDate.Text.ToString();

            frmRptVisit v = new frmRptVisit();
            v.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmDelVisit sv = new frmDelVisit();
            sv.ShowDialog();
        }
    }
}
