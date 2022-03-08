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
    public partial class frmEditMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmEditMenu()
        {
            InitializeComponent();
        }

        private void frmEditMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmEditPat p = new frmEditPat();
            p.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmEditDoc d = new frmEditDoc();
            d.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmEditServ s = new frmEditServ();
            s.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmEditSec s = new frmEditSec();
            s.ShowDialog();
        }
    }
}
