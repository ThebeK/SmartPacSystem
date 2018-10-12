using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Users
{
    public partial class FrmResetPassword : Form
    {
        SPEntities db = new SPEntities();
        int Access_ID;
        public FrmResetPassword(int x)
        {
            Access_ID = x;
            InitializeComponent();
        }
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

        private void FrmResetPassword_Load(object sender, EventArgs e)
        {

            textBox1.PasswordChar = '•';
            textBox2.PasswordChar = '•';
            groupBox1.Enabled = false;
            button1.Enabled = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label4.Visible = false;
        }
        bool correct;
        public static byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correct = true;

            if (txtUsername.Text == "")
            {
                label4.Visible = true;
                label4.Text = "Please Provide the username you wish to reset";

                correct = false;
            }
            if (correct == true)
            {
                string username = txtUsername.Text;
                var query1 = db.Active_User.Where(co => co.Username == username).FirstOrDefault();

                if (query1 == null)
                {
                    label4.Visible = true;
                    label4.Text = "User Not Found. Re-enter userName";

                    correct = false;
                }
                else
                {
                    groupBox1.Enabled = true;
                    button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            correct = true;

            string username = txtUsername.Text;
            var query1 = db.Active_User.Where(co => co.Username == username/* && co.User_Type.User_Type_Description != "Customer"*/).FirstOrDefault();
            if (txtUsername.Text == "")
            {
                label4.Visible = true;
                label4.Text = "Please Provide the username you wish to reset";

                correct = false;
            }
            if (textBox1.Text == "")
            {
                label5.Visible = true;
                label5.Text = "Please Provide New Password";

                correct = false;
            }
            if (textBox2.Text == "")
            {
                label6.Visible = true;
                label6.Text = "Please Confirm Password";

                correct = false;
            }
            if (textBox1.Text != textBox2.Text)
            {
                label7.Visible = true;
                label7.Text = "Passwords provided do not match";

                correct = false;
            }


            if (correct == true)
            {
                byte[] bit = new byte[25];
                bit = StrToByteArray(textBox2.Text);

                query1.pass = Convert.ToString(bit);
                db.SaveChanges();
                MessageBox.Show("Password Successfully Updated");
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Process.Start(@".\" + "ResetPassword.pdf");
        }
    }
}
