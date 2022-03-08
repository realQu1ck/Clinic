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
    public partial class frmDelMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmDelMenu()
        {
            InitializeComponent();
        }

        private void frmDelMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmDelPat d = new frmDelPat();
            d.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmDelDoc d = new frmDelDoc();
            d.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmDelServ s = new frmDelServ();
            s.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmDelSec s = new frmDelSec();
            s.ShowDialog();
        }
    }
}
