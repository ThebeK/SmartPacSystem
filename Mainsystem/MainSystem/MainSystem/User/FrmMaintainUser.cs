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
    public partial class FrmMaintainUser : Form
    {
        int AccessIds;
        public FrmMaintainUser(int valUE)
        {
            

            InitializeComponent();
            AccessIds = valUE;
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
            this.Hide();
            rs.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainUser.pdf");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMaintainUser_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {

                accessLevelBindingSource1.DataSource = db.Access_Level.ToList();
            }
            cbAccessLevelName.DataSource = db.Access_Level.ToList();
            var query = db.Active_User.Where(co => co.Active_User_Id == AccessIds).FirstOrDefault();

            txtUsername.Text = query.Username;
            txtPassword.Text = query.pass;
            txtConfirmPassword.Text = query.pass;

            var query1 = db.Access_Level.Where(co => co.Access_Level_Id == query.Access).FirstOrDefault();

            cbAccessLevelName.Text = query1.Access_Level_Name;
            
            //cbAccessLevelName.ValueMember = "Access_Level_Name";

            //var query = db.Access_Level.Where(co => co.Access_Level_Id == AccessIds).FirstOrDefault();
            //var mark = db.User_Role.Where(co => co.User_Role_Id == query.Access_Level_Id).FirstOrDefault();


            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
