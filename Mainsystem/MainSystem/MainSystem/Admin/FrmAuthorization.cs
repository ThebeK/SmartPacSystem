using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Admin
{
    public partial class FrmAuthorization : Form
    {
        public FrmAuthorization()
        {
            InitializeComponent();
            this.Opacity = 0;

            timer1.Start();
        }
        SPEntities db = new SPEntities();
        public sealed class UserActivityMonitor
        {
            /// <summary>Determines the time of the last user activity (any mouse activity or key press).</summary>
            /// <returns>The time of the last user activity.</returns>

            public DateTime LastActivity => DateTime.Now - this.InactivityPeriod;

            /// <summary>The amount of time for which the user has been inactive (no mouse activity or key press).</summary>

            public TimeSpan InactivityPeriod
            {
                get
                {
                    var lastInputInfo = new LastInputInfo();
                    lastInputInfo.CbSize = Marshal.SizeOf(lastInputInfo);
                    GetLastInputInfo(ref lastInputInfo);
                    uint elapsedMilliseconds = (uint)Environment.TickCount - lastInputInfo.DwTime;
                    elapsedMilliseconds = Math.Min(elapsedMilliseconds, int.MaxValue);
                    return TimeSpan.FromMilliseconds(elapsedMilliseconds);
                }
            }

            public async Task WaitForInactivity(TimeSpan inactivityThreshold, TimeSpan checkInterval, CancellationToken cancel)
            {
                while (true)
                {
                    await Task.Delay(checkInterval, cancel);

                    if (InactivityPeriod > inactivityThreshold)
                        return;
                }
            }

            // ReSharper disable UnaccessedField.Local
            /// <summary>Struct used by Windows API function GetLastInputInfo()</summary>

            struct LastInputInfo
            {
#pragma warning disable 649
                public int CbSize;
                public uint DwTime;
#pragma warning restore 649
            }

            // ReSharper restore UnaccessedField.Local

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool GetLastInputInfo(ref LastInputInfo plii);
        }
        readonly UserActivityMonitor _monitor = new UserActivityMonitor();

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await _monitor.WaitForInactivity(TimeSpan.FromMinutes(2), TimeSpan.FromSeconds(5), CancellationToken.None);
            MessageBox.Show("You have been inactive for sometime, please Login again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmLogin rs = new frmLogin();
            rs.ShowDialog();
            this.Close();
        }
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

        private void FrmAuthorization_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "Authorization.pdf");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
