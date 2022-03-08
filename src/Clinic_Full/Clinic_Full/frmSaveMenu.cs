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
    public partial class frmSaveMenu : DevComponents.DotNetBar.OfficeForm
    {
        public frmSaveMenu()
        {
            InitializeComponent();
        }

        private void frmSaveMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmSavePati p = new frmSavePati();
            p.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmSaveDoc d = new frmSaveDoc();
            d.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSaveServ s = new frmSaveServ();
            s.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmSaveSec s = new frmSaveSec();
            s.ShowDialog();
        }
    }
}
