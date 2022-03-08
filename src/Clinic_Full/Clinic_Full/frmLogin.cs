using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;

namespace Clinic_Full
{
    public partial class frmLogin : Form
    {

        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private bool AnalyzeSignin(string Username, string Pass)
        {
            bool Check;
            var CheckUser = objDB.Tbl_Login.Where(x => x.Username == Username);
            if (CheckUser.Count() == 1)
            {
                string Password;
                byte[] b = System.Text.Encoding.UTF8.GetBytes(Pass);

                System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();
                byte[] hashed = h.ComputeHash(b);

                Password = Convert.ToBase64String(hashed);

                var CheckPass = objDB.Tbl_Login.ToList().Find(x => x.Username == Username);
                if (CheckPass.Password == Password)
                {

                    objDB.SaveChanges();
                    return Check = true;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("!! اطلاعات نامعتبر می باشد.لطفا دوباره تلاش کنید ", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Check = false;
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("!! اطلاعات نامعتبر می باشد.لطفا دوباره تلاش کنید ", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Check = false;
            }
        }
        public frmLogin()
        {
            InitializeComponent();

            Cursor.Show();
        }
      
        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            Cursor.Show();
            foreach (Control control in this.Controls)
            {
                control.MouseEnter += control_MouseEnter;
                control.MouseLeave += control_MouseLeave;
                Cursor.Show();
            }
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            string Time = PC.GetHour(DateTime.Now) + ":" + PC.GetMinute(DateTime.Now) + ":" + PC.GetSecond(DateTime.Now);
            lblTime.Text = Time;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (AnalyzeSignin(txtUser.Text.Trim(), txtPass.Text) == true)
            {
                Cursor = Cursors.Arrow;
                var user = objDB.Tbl_Login.ToList().Find(x => txtUser.Text == x.Username);
                Trans.Username = "";
                Trans.Email = "";
                Trans.Name = "";
                Trans.NCode = "";
                Trans.Username = user.Username;
                Trans.Email = user.Email.ToString();
                Trans.Name = user.Name.ToString();
                Trans.NCode = user.NCode.ToString();
                frmMenu f = new frmMenu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                Cursor = Cursors.Arrow;

            }
        }
      
        private void timer2_Tick(object sender, EventArgs e)
        {
       
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSginup s = new frmSginup();
            s.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("برای خروج از برنامه اطمینان دارید ؟","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
           Application.Exit();
            }
            else
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
