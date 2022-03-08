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
    public partial class frmEditDoc : DevComponents.DotNetBar.OfficeForm
    {
        public frmEditDoc()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void frmEditDoc_Load(object sender, EventArgs e)
        {
            dtgDoc.AutoGenerateColumns = false;

            dtgDoc.ColumnCount = 9;

            dtgDoc.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgDoc.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgDoc.DefaultCellStyle.BackColor = Color.White;

            this.dtgDoc.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            this.dtgDoc.DefaultCellStyle.SelectionForeColor = Color.Black;

            dtgDoc.Columns[8].Name = "ID";
            dtgDoc.Columns[8].DataPropertyName = "ID";
            dtgDoc.Columns[8].HeaderText = "ID";

            dtgDoc.Columns[0].Name = "Name_Family";
            dtgDoc.Columns[0].DataPropertyName = "Name_Family";
            dtgDoc.Columns[0].HeaderText = "نام";

            dtgDoc.Columns[1].Name = "Tell";
            dtgDoc.Columns[1].DataPropertyName = "Tell";
            dtgDoc.Columns[1].HeaderText = "شماره تلفن ";

            dtgDoc.Columns[2].Name = "Adrs";
            dtgDoc.Columns[2].DataPropertyName = "Adrs";
            dtgDoc.Columns[2].HeaderText = "آدرس";
            dtgDoc.Columns[2].Width = 80;

            dtgDoc.Columns[3].Name = "MeliCode";
            dtgDoc.Columns[3].DataPropertyName = "MeliCode";
            dtgDoc.Columns[3].HeaderText = "شماره ملی";

            dtgDoc.Columns[4].Name = "Ncode";
            dtgDoc.Columns[4].DataPropertyName = "Ncode";
            dtgDoc.Columns[4].HeaderText = "شماره";

            dtgDoc.Columns[5].Name = "Resume";
            dtgDoc.Columns[5].DataPropertyName = "Resume";
            dtgDoc.Columns[5].HeaderText = "سابقه";

            dtgDoc.Columns[6].Name = "SecID";
            dtgDoc.Columns[6].DataPropertyName = "SecID";
            dtgDoc.Columns[6].HeaderText = "شماره سرویس";

            dtgDoc.Columns[7].Name = "ServID";
            dtgDoc.Columns[7].DataPropertyName = "ServID";
            dtgDoc.Columns[7].HeaderText = "شماره بخش";

            dtgDoc.DataSource = objDB.Tbl_Doctors.ToList();

            lblName.Text = Trans.Name;
            lblUser.Text = Trans.Username;

            cmb_Sec.DisplayMember = "title";
            cmb_Sec.ValueMember = "ID";
            cmb_Sec.DataSource = objDB.Tbl_Section.ToList();

            cmb_Serv.DisplayMember = "title";
            cmb_Serv.ValueMember = "ID";
            cmb_Serv.DataSource = objDB.Tbl_Services.ToList();
        }
        int GridID;
        int Serv = 0;
        int Sec = 0;
        private void dtgDoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridID = (int)dtgDoc.Rows[e.RowIndex].Cells["ID"].Value;


            txtName.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).Name_Family;
            txtNcode.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).Ncode;
            txtMeliCode.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).MeliCode;
            txtResume.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).Resume;
            txtTell.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).Tell;
            txtAdrs.Text = objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).Adrs;
            Sec =(int)objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).SecID;
            Serv = (int)objDB.Tbl_Doctors.ToList().Find(s => s.ID == GridID).ServID;

            cmb_Sec.SelectedValue = Sec;
            cmb_Serv.SelectedValue = Serv;

            var q = objDB.Tbl_Doctors.Find(GridID).img;
            pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(q));
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
                var query = objDB.Tbl_Doctors.ToList().Find(x => x.ID == GridID);

           
                try
                {
                  query.img = File.ReadAllBytes(openFileDialog1.FileName);
                }
                catch (Exception)
                {
                    query.Name_Family = txtName.Text;
                    query.Tell = txtTell.Text;
                    query.MeliCode = txtMeliCode.Text;
                    query.Adrs = txtAdrs.Text;
                    query.SecID = Sec;
                    query.ServID = Serv;
                    query.Ncode = txtNcode.Text;
                    query.Resume = txtResume.Text;
                }


                objDB.SaveChanges();

                dtgDoc.DataSource = objDB.Tbl_Doctors.ToList();

                MessageBox.Show(". عملیات ویرایش موفقیت آمیز بود ", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a)
            {
                MessageBox.Show(" . خطا در متصل شدن به دیتابیس  " + a, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
