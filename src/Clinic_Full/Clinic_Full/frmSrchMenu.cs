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
    public partial class frmSrchMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmSrchMenu()
        {
            InitializeComponent();
        }

        private void frmSrchMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmSrchPat s = new frmSrchPat();
            s.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmSrchDoc d = new frmSrchDoc();
            d.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSrchServ s = new frmSrchServ();
            s.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmSrchSec s = new frmSrchSec();
            s.ShowDialog();
        }
    }
}
