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

namespace MainSystem.Products.Sheets
{
    
    public partial class FrmAddSheet : Form
    {
        string option;
        public FrmAddSheet(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;
        public bool ValidateIfSheetExists(string SH)
        {
            bool Check = false;
            foreach (var item in db.Sheets)
            {
                if (item.Number_Of_Sheet == Convert.ToInt32(SH))
                {
                    Check = true;
                    break;
                }
            }
            return Check;
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
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void FrmAddSheet_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                correct = true;
                Sheet Sheet = new Sheet();

                if (rtxtDescription.Text == "")
                {
                    lblSheet.Visible = true;
                    // MessageBox.Show("Please Enter Product sheet number details");
                    correct = false;
                }
                if (ValidateIfSheetExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Number of Sheets already exists");
                }
                if (correct == true)
                {
                    Sheet.Number_Of_Sheet = Convert.ToInt32(rtxtDescription.Text);
                }

                db.Sheets.Add(Sheet);

                db.SaveChanges();

                int Sheet_ID = Sheet.Sheet_ID;
                string ProdT_value = Convert.ToString(Sheet);
                MessageBox.Show("Product Sheets Number Successfully Added");
                this.Close();


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product Sheets Number Added");
            }
        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
