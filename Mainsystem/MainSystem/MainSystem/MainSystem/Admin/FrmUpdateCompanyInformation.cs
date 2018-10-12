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
    public partial class FrmUpdateCompanyInformation : Form
    {
        SPEntities db = new SPEntities();
        public FrmUpdateCompanyInformation()
        {
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

        private void button5_Click(object sender, EventArgs e)
        {
            StartUp.frmHelp ff = new StartUp.frmHelp();
            ff.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool correct = false;
        private void button1_Click(object sender, EventArgs e)
        {
            correct = true;

            if (correct == true)
            {
                try
                {
                    var query = db.Company_Information.FirstOrDefault();

                    query.Company_Name = txtName.Text;
                    query.Company_Address = txtCompnyAddress.Text;
                    query.VAT_Percentage = Convert.ToDecimal(txtPercent.Text);
                    query.VAT_Number = txtVatNmber.Text;
                    query.Registration_Number = txtRegNumber.Text;
                    query.Email_Address = txtEmailAdress.Text;
                    query.Telephone_Number = txtTelephone.Text;

                    db.SaveChanges();
                    MessageBox.Show("Company information updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured" + ex);
                }
                // MessageBox.Show("Please fill in all required fields");

                //MessageBox.Show("Please fill in all required fields");
                //MessageBox.Show("Company information updated successfully");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUpdateCompanyInformation_Load(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCompnyAddress.Clear();
            txtVatNmber.Clear();
            txtPercent.Clear();
            txtRegNumber.Clear();
            txtEmailAdress.Clear();
            txtTelephone.Clear();

            var query = db.Company_Information.FirstOrDefault();

            txtName.Text = query.Company_Name;
            txtCompnyAddress.Text = query.Company_Address;
            txtVatNmber.Text = query.VAT_Number;
            txtPercent.Text = Convert.ToString(query.VAT_Percentage);
            txtRegNumber.Text = query.Registration_Number;
            txtEmailAdress.Text = query.Email_Address;
            txtTelephone.Text = query.Telephone_Number;
        }
    }
}
