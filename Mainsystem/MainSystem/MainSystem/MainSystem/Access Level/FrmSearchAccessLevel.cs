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

namespace MainSystem.Access_Level
{
    public partial class FrmSearchAccessLevel : Form
    {
        public FrmSearchAccessLevel(string option)
        {
            if (option == "Maintain Access Level")
            {
                selectedOption = "Maintain Access Level";

            }
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
        string selectedOption;
        private void btnMaintain_Click(object sender, EventArgs e)
        {

            string val = Convert.ToString(dgvAccesSearch.CurrentRow.Cells[0].Value);



            if (selectedOption == "Maintain Access Level")
            {
                FrmMaintainAccessLevel ma = new FrmMaintainAccessLevel(val);
                    ma.ShowDialog();
               
                this.Dispose();
                


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //if (txtSearchAccess.Text == "")
            //{

            //    MessageBox.Show("Error: No search details entered");

            //}
            //else if (txtSearchAccess.Text != "")
            //{

            //    List<Access_Level> Accesssearch = db.Access_Level.Where(o => o.Access_Level_Name.Contains(textBox1.Text)).ToList();

            //    if (Accesssearch.Count == 0)
            //    {


            //        MessageBox.Show("Error: No access level Found");

            //    }

            //    else
            //    {
            //        foreach (var a in Accesssearch)
            //        {
            //            dgvAccesSearch.DataSource = Accesssearch.Select(col => new { col.Access_Level_Id, col.Access_Level_Name }).ToList();
            //            dgvAccesSearch.Columns[0].HeaderText = "Access Level ID";
            //            dgvAccesSearch.Columns[0].Width = 100;
            //            dgvAccesSearch.Columns[1].HeaderText = "Access_Level_Name";
            //            dgvAccesSearch.Columns[1].Width = 150;


            //        }
            //    }
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSearchAccessLevel_Load(object sender, EventArgs e)
        {
            //tips
            toolTip1.SetToolTip(this.txtSearchAccess, "Enter Access Level Name");
           
            toolTip1.SetToolTip(this.btnSearch, "Click to search access level");
            toolTip1.SetToolTip(this.btnMaintain, "Click to delete or update access level");

        }

        private void FrmSearchAccessLevel_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchAccessLevel.pdf");
        }
    }
}
