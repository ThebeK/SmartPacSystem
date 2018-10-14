using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timer1.Start();
            this.Opacity = 0;
            timer2.Start();
        }
        public static string setvalue = "";
        //SPEntities db = new SPEntities();
        SPEntities db = new SPEntities();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            setvalue = txtUsername.Text;
            string Hashb;
            List<Active_User> myUser = new List<Active_User>();
            try
            {
                myUser = db.Active_User.Where(someuser => someuser.Username == txtUsername.Text).ToList();
            }
            catch
            {

                throw;
            }
            try
            {
                Active_User emp = myUser[0];
                clsGlobals.Userlogin = myUser[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);

            }

            // db.SaveChanges();
            try
            {

                SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(txtPasswordLogin.Text)));
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SP;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select pass from Active_User where Username=@User_Name", con);
                cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Hashb = dr[0].ToString();
                con.Close();

                if (hash == Hashb)
                {
                    MessageBox.Show("Login was successful");
                    
                    Form1 ds = new Form1();
                    this.Hide();
                    ds.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Login failed, please try again");

                }

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Error has occured:" + ex.Message);

            }
            Form1 qq = new Form1();
            qq.ShowDialog();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this Program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to close this Program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin.FrmAuthorization af = new Admin.FrmAuthorization();
            
            af.ShowDialog();
            af.Focus();
            af.BringToFront();
            af.Activate();
            
            //this.Activate();
            //this.Show();
            //this.Dispose();
        }
        double opacity = 0.00;
        private void timer2_Tick(object sender, EventArgs e)
        {
            while (opacity < 1)
            {
                this.Opacity = opacity; // update main form opacity - transparency

                opacity += 0.0001; // this can be changed
                //Task.Delay(1);

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Thabang";
            txtPasswordLogin.Text = "1234";
            this.Opacity = 0;
            timer2.Start();
            try
            {
                if (clsGlobals.ReadFromRegistry("SetupComplete") == "")
                {
                    clsGlobals.ModalPopup(this, new StartUp.FrmFirstTimeStartup());
                }

                string Username = clsGlobals.ReadFromRegistry("Username");
                txtUsername.Text = Username;

                if (Username != "")
                {
                    chkRemember.Checked = true;
                    txtPasswordLogin.Focus();
                    txtPasswordLogin.Focus();
                    ActiveControl = txtPasswordLogin;
                    ActiveControl = txtPasswordLogin;
                }
            }
            catch
            { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordLogin.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblTime.Text = datetime.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin.FrmAuthorization af = new Admin.FrmAuthorization();

            af.ShowDialog();
            af.Focus();
        }

        private void frmLogin_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
