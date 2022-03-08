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
    public partial class frmSginup : Form
    {
        public frmSginup()
        {
            InitializeComponent();
        }
        Model.DB_Clinic_FullEntities objDB = new Model.DB_Clinic_FullEntities();
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void frmSginup_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Model.Tbl_Login objUser = new Model.Tbl_Login();

            Random rnd = new Random();
            rnd.Next(1, 102654);


                objUser.Name = txtName.Text;
                objUser.Username = txtUser.Text;
                objUser.Email = txtMail.Text;
                objUser.PhoneNum = txtPhone.Text;
               objUser.NCode = rnd.Next(1, 102654).ToString();
                objUser.Img = File.ReadAllBytes(openFileDialog1.FileName);
            objDB.SaveChanges();

            if (txtPass.Text == txtRePass.Text)
            {
                byte[] b = System.Text.Encoding.UTF8.GetBytes(txtPass.Text);

                System.Security.Cryptography.SHA1 h = System.Security.Cryptography.SHA1.Create();
                byte[] hashed = h.ComputeHash(b);

                objUser.Password = Convert.ToBase64String(hashed);

                objDB.Tbl_Login.Add(objUser);
            }
            else
            {
                MessageBox.Show(" password not matched!");
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
