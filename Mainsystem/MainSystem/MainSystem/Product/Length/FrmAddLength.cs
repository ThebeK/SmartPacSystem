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

namespace MainSystem.Products.Length
{
    public partial class FrmAddLength : Form
    {
        SPEntities db = new SPEntities();
        bool correct = false;
        public FrmAddLength()
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
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool ValidateIfLengthExists(string Lengthh)
        {
            bool Check = false;
            foreach (var item in db.pLengths)
            {
                if (item.Length_Size == Convert.ToInt32(Lengthh))
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }

        private void FrmAddLength_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateIfLengthExists(txtLengthDescription.Text) == true)
                {
                    MessageBox.Show("Product Length exists");
                }


                correct = true;
                pLength PL = new pLength();

                if (txtLengthDescription.Text == "")
                {
                    lblLength.Visible = true;
                    //MessageBox.Show("Please Enter Product Widths");
                    correct = false;
                }

                if (txtMeasurement.Text == "")
                {
                    lblUnit.Visible = true;
                }

                if (correct == true)
                {
                    PL.Length_Size = Convert.ToInt32(txtLengthDescription.Text);
                    PL.Length_Measurement_Unit = txtMeasurement.Text;
                    db.pLengths.Add(PL);

                    db.SaveChanges();

                    int Length_ID = PL.Length_ID;
                    string Length_value = Convert.ToString(PL);
                    MessageBox.Show("Product Length Successfully Added");
                    this.Close();
                }




            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product Length Added");
            }
        }

        private void txtLengthDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtMeasurement_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
