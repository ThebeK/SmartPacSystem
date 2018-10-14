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

namespace MainSystem
{
    public partial class frmSearchClient : Form
    {
        string selectedOption;
        public frmSearchClient(string option)
        {
            if (option == "Maintain Client")
            {
                selectedOption = "Maintain Client";
            }
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
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            string val = Convert.ToString(dgvClientSearch.CurrentRow.Cells[0].Value);


            if (selectedOption == "Maintain Client")
            {
                frmMaintainClient frm1 = new frmMaintainClient(val, "Clients");

                frm1.ShowDialog();

            }
        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtSearchclient, "Enter client name");
            toolTip1.SetToolTip(this.btnSearch, "Click to search client");
            toolTip1.SetToolTip(this.btnMaintain, "Click to edit or remove client");

            dgvClientSearch.DataSource= db.Load_Client().ToList();
        }

        private void txtSearchSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchclient.Text == "")
            {
                label3.Visible= true;
                 

            }
            else if (txtSearchclient.Text !="")
            {
                label3.Visible = false;
                List<Client> search = db.Clients.Where(o => o.Client_Name.Contains(txtSearchclient.Text)).ToList();

                if (search.Count == 0)
                {
                    label3.Visible = true;
                }
                else
                {
                    
                        dgvClientSearch.DataSource = db.Load_Client().Where(o => o.Name.Contains(txtSearchclient.Text)).ToList();

                    
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSearchClient_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchClient.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
