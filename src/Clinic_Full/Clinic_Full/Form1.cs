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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
            objDB.Database.Create();
            foreach (Control c in Controls)
            {
                c.Hide();
                animator1.Show(c);
            }
            foreach (Control control in this.Controls)
            {
                control.MouseEnter += control_MouseEnter;
                control.MouseLeave += control_MouseLeave;
                Cursor.Hide();
            }
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        int P = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (P<100)
            {
                P++;
            }
            else
            {
                timer1.Stop();
                frmLogin l = new frmLogin();
                l.Show();
                this.Hide();
            }
        }
    }
}
