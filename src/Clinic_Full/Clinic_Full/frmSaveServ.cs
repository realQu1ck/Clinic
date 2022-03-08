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
    public partial class frmSaveServ : DevComponents.DotNetBar.OfficeForm
    {
        public frmSaveServ()
        {
            InitializeComponent();
        }
        int SecID;
        private void frmSaveServ_Load(object sender, EventArgs e)
        {
            Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();

            cmb_Sec.DisplayMember = "title";
            cmb_Sec.ValueMember = "ID";
            cmb_Sec.DataSource = objDB.Tbl_Section.ToList();

            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Tbl_Services objServ = new Model.Tbl_Services();
                Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();

                objServ.title = txtName.Text;
                objServ.SecID = SecID;

                objDB.Tbl_Services.Add(objServ);

                objDB.SaveChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show(".اطلاعات ثبت شد", " Save ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Text = "";
                txtName.Focus();


            }
            catch (Exception)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void cmb_Sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecID = int.Parse(cmb_Sec.SelectedValue.ToString());
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmEditMenu ea = new frmEditMenu();
            ea.ShowDialog();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            frmDelMenu s = new frmDelMenu();
            s.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmInfo i = new frmInfo();
            i.ShowDialog();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            frmCal c = new frmCal();
            c.ShowDialog();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            frmSginup s = new frmSginup();
            s.ShowDialog();
        }
    }
}
