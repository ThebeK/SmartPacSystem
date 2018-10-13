using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Admin
{
    public partial class FrmAuthorize : Form
    {
        public FrmAuthorize()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string Hashb;
            List<Active_User> myUser = new List<Active_User>();
            try
            {
                myUser = db.Active_User.Where(someuser => someuser.Username == txtEmail.Text).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                Active_User emp = myUser[0];
                clsGlobals.Userlogin = myUser[0];
            }
            catch (Exception)
            {

                throw;
            }

            db.SaveChanges();
            try
            {

                SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(txtPassword.Text)));
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SP;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select pass from Active_User where Username=@Username", con);
                cmd.Parameters.AddWithValue("@Username", txtEmail.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Hashb = dr[0].ToString();
                con.Close();
                if (txtEmail.Text == "")
                {
                    lbWarningEmail.Visible = true;
                    //label4.Text = "Please Provide the username you wish to reset";

                    //correct = false;
                }
                if (txtPassword.Text == "")
                {
                    lbWarningPassword.Visible = true;
                    //label4.Text = "Please Provide the username you wish to reset";

                    //correct = false;
                }
                if (hash == Hashb)
                {
                    MessageBox.Show("Authorization was successful");
                    this.Dispose();
                    Users.FrmResetPassword rs = new Users.FrmResetPassword(3);
                    rs.ShowDialog();
                    rs.Focus();

                }
                else
                {
                    MessageBox.Show("Authorization failed, please try again");
                    lbWarningEmail.Visible = true;
                    lbWarningPassword.Visible = true;
                }

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Error has occured:" + ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "Authorization.pdf");
        }
    }
}
