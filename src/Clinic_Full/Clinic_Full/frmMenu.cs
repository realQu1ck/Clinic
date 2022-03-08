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
namespace Clinic_Full
{
    public partial class frmMenu : Form
    {
        Model.DB_Clinic_FullEntities Obj = new Model.DB_Clinic_FullEntities();
    
         
        public frmMenu()
        {
            InitializeComponent();
     
        }
      
        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("برای خروج از برنامه اطمینان دارید ؟", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Application.Exit();
            }
            else
            {

            }
        }

        private void radClock1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = Trans.Username;
            lblEmail.Text = Trans.Email; ;
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            string Time = PC.GetHour(DateTime.Now) + ":" + PC.GetMinute(DateTime.Now) + ":" + PC.GetSecond(DateTime.Now);
            string Date = PC.GetYear(DateTime.Now) + "-" + PC.GetMonth(DateTime.Now) + "-" + PC.GetDayOfMonth(DateTime.Now);
            lblTime.Text = Time;
            lblDate.Text = Date;


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmSaveMenu s = new frmSaveMenu();
            s.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            frmDelMenu d = new frmDelMenu();
            d.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmEditMenu ea = new frmEditMenu();
            ea.ShowDialog();
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

        private void buttonX7_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            frmLock l = new frmLock();
            l.Show();
            m.Close();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmInfo i = new frmInfo();
            i.ShowDialog();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            frmSrchMenu s = new frmSrchMenu();
            s.ShowDialog();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmVisit V = new frmVisit();
            V.ShowDialog();
                }
        int P = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (P < 10)
            {
                P++;
            }
            if (P == 10)
                {
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__104_;
                    P++;
                }
            if (P < 20)
            {
                P++;
            }
            if (P == 20)
                {
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__132_;
                    P++;
                }
            if (P < 30)
            {
                P++;
            }
            if (P == 30)
                { 
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__59_;
                    P++;
                }
            if (P < 40)
            {
                P++;
            }
                if (P == 40)
                {
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__1_;
                    P++;
                }
            if (P < 50)
            {
                P++;
            }
            if (P == 50)
                {
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__6_;
                    P++;
                }
            if (P < 60)
            {
                P++;
            }
            if (P == 60)
                {
                    pictureBox1.Image = Clinic_Full.Properties.Resources.Wallpaper__294_;

                P++;
                P = 0;
            }
        }
    }
}
