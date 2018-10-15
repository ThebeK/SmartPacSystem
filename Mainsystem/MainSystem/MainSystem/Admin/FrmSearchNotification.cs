using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Admin
{
    public partial class FrmSearchNotification : Form
    {
        string option;
        public FrmSearchNotification(string x)
        {
            option = x;
            InitializeComponent();
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin.FrmAddNotification f = new Admin.FrmAddNotification();
            f.ShowDialog();
            dataGridView1.DataSource = db.Email_Notice_Template.ToList();
        }

        private void FrmSearchNotification_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var r = db.Email_Notice_Template.ToList();
            groupBox1.Visible = true;

            dataGridView1.DataSource = r.Select(col => new { col.Template_Id, col.Template_Description, col.Template_Text }).ToList();
            dataGridView1.Columns[0].HeaderText = "Template ID";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Template Description";
            dataGridView1.Columns[1].Width = 360;
            dataGridView1.Columns[2].HeaderText = "Template Text";
            dataGridView1.Columns[2].Width = 800;

            if (option == "Search Template")
            {
                // btnSelect.Visible = false;

            }
            dataGridView1.Refresh();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Notification")
            {
                Admin.FrmMaintainNotification myform = new Admin.FrmMaintainNotification(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();


            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Publish Email")
            {
                FrmPublishEmail myform = new FrmPublishEmail(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
            }

        }

        private void btnSendsms_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Publish Email")
            {
                frmPunblblishSms myform = new frmPunblblishSms(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
