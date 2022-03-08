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
    public partial class frmSavePati : DevComponents.DotNetBar.OfficeForm
    {
        public frmSavePati()
        {
            InitializeComponent();
        }

        private void frmSavePati_Load(object sender, EventArgs e)
        {
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

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmEditMenu ea = new frmEditMenu();
            ea.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmInfo i = new frmInfo();
            i.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Tbl_Patient objpatient = new Model.Tbl_Patient();
                Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();

                objpatient.Name_Family = txtName.Text;
                objpatient.MeliCode = txtMeliCode.Text;
                objpatient.Tell = txtTell.Text;
                objpatient.Adrs = txtAdrs.Text;
                objpatient.Date = txtDate.Text;
                objpatient.NCodePat = txtNcode.Text;
                objpatient.Time = txtTime.Text;
                objpatient.LoginCode = Trans.NCode;
                objpatient.LoginName = Trans.Username;

                objDB.Tbl_Patient.Add(objpatient);

                objDB.SaveChanges();
               DevExpress.XtraEditors.XtraMessageBox.Show(".اطلاعات ثبت شد", " Save ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Text = "";
                txtTell.Text = "";
                txtAdrs.Text = "";
                txtMeliCode.Text = "";
                txtName.Focus();


            }
            catch (Exception)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            string Time = PC.GetHour(DateTime.Now) + ":" + PC.GetMinute(DateTime.Now) + ":" + PC.GetSecond(DateTime.Now);
            string Date = PC.GetYear(DateTime.Now) + ":" + PC.GetMonth(DateTime.Now) + ":" + PC.GetDayOfMonth(DateTime.Now);
            txtTime.Text = Time;
            txtDate.Text = Date;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            frmCal c = new frmCal();
            c.ShowDialog();

        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            frmDelMenu d = new frmDelMenu();
            d.ShowDialog();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            frmSginup s = new frmSginup();
            s.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
