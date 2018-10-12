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
    public partial class frmMaintainClient : Form
    {
        public frmMaintainClient()
        {
            InitializeComponent();
        }
        public SPEntities db = new SPEntities();
        byte[] FileData;
        string FName;
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
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainClient.pdf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMaintainClient_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(this.txtName, "Enter Client Name ");

            toolTip1.SetToolTip(this.txtVatRegNum, "Enter 10 digit Vat Registration number");

            toolTip1.SetToolTip(this.txtTelephone, "Enter 10 digit telephone number");

            toolTip1.SetToolTip(this.txtFaxNumber, "Enter 10 digit fax number number");

            toolTip1.SetToolTip(this.txtEmailAdd, "Enter a valid email containing @");

            toolTip1.SetToolTip(this.txtPhysicalAdd, "Enter address");
            toolTip1.SetToolTip(this.cbxProvince, "Select South African Province");
            toolTip1.SetToolTip(this.cbxCity, "Select South African City");
            toolTip1.SetToolTip(this.txtCreditAmount, "Enter credit amount");
            toolTip1.SetToolTip(this.cbxCreditStatus, "Select valid credit status");
            toolTip1.SetToolTip(this.txtDateTimeDateOfCommencement, "Select date");
            toolTip1.SetToolTip(this.cbxCreditStatus, "Select valid credit status");
            toolTip1.SetToolTip(this.btnBrowse, "Browse to upload credit approval");
            toolTip1.SetToolTip(this.btnDeleteClient, "Click to remove client");
            toolTip1.SetToolTip(this.btnUpdateClient, "Click to edit client");
            toolTip1.SetToolTip(this.btnDownload, "Click to obtain credit approval");

            using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                clientAccountStatusBindingSource.DataSource = db.Client_Account_Status.ToList();
                creditStatusBindingSource.DataSource = db.Credit_Status.ToList();
            }


        }
    }
}
