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
    public partial class frmRptVisit : DevComponents.DotNetBar.OfficeForm
    {
        public frmRptVisit()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmRptVisit_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.SetParameters(new
                Microsoft.Reporting.WinForms.ReportParameter("PNP", ClsVisit.Pat.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PND", ClsVisit.Doc.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PNS", ClsVisit.Sec.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PNSE", ClsVisit.Serv.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PTS", ClsVisit.SDate.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PTN", ClsVisit.VTime.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PNH", Trans.Name.ToString()));

                reportViewer1.LocalReport.SetParameters(new
              Microsoft.Reporting.WinForms.ReportParameter("PTN", ClsVisit.VTime.ToString()));

                //reportViewer1.LocalReport.DataSources.Add(new
                //    Microsoft.Reporting.WinForms.ReportDataSource("DB_Clinic_FullDataSet1", Row));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception a)
            {

                MessageBox.Show("دوباره تلاش کنید" +a , "Report Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
