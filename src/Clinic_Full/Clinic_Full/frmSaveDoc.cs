using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Full
{
    public partial class frmSaveDoc : DevComponents.DotNetBar.OfficeForm
    {
        public frmSaveDoc()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        int Serv;
        int Sec;
        private void frmSaveDoc_Load(object sender, EventArgs e)
        {
            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;

            cmb_Sec.DisplayMember = "title";
            cmb_Sec.ValueMember = "ID";
            cmb_Sec.DataSource = objDB.Tbl_Section.ToList();

            cmb_Serv.DisplayMember = "title";
            cmb_Serv.ValueMember = "ID";
            cmb_Serv.DataSource = objDB.Tbl_Services.ToList();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            frmCal c = new frmCal();
            c.ShowDialog();
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Tbl_Doctors objDoc = new Model.Tbl_Doctors();
                Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();

                objDoc.Name_Family = txtName.Text;
                objDoc.MeliCode = txtMeliCode.Text;
                objDoc.Tell = txtTell.Text;
                objDoc.Adrs = txtAdrs.Text;
                objDoc.SecID = Sec;
                objDoc.ServID = Serv;
                objDoc.Ncode= txtNcode.Text;
                objDoc.Resume = txtResume.Text;

                try
                {
                    objDoc.img = File.ReadAllBytes(openFileDialog1.FileName);
                }
                catch (Exception)
                {

                    DevExpress.XtraEditors.XtraMessageBox.Show("لطفا عکس را انتخاب نمایید", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                objDB.Tbl_Doctors.Add(objDoc);

                objDB.SaveChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show(".اطلاعات ثبت شد", " Save ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Text = "";
                txtTell.Text = "";
                txtAdrs.Text = "";
                txtMeliCode.Text = "";
                txtNcode.Text = "";
                txtResume.Text = "";
                txtName.Focus();


            }
            catch (Exception)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(" . خطا در متصل شدن به دیتابیس  ", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Serv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Serv = int.Parse(cmb_Serv.SelectedValue.ToString());
        }

        private void cmb_Sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sec = int.Parse(cmb_Sec.SelectedValue.ToString());
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmEditMenu ea = new frmEditMenu();
            ea.ShowDialog();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            frmDelMenu d = new frmDelMenu();
            d.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmInfo i = new frmInfo();
            i.ShowDialog();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            frmSginup s = new frmSginup();
            s.ShowDialog();
        }
    }
}
