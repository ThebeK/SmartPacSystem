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
    public partial class FrmMaintainLength : Form
    {
        int tempID;
        public FrmMaintainLength(int x)
        {
            InitializeComponent();
            tempID = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;

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

        private void FrmMaintainLength_Load(object sender, EventArgs e)
        {
            var query = db.pLengths.Where(co => co.Length_ID == tempID).FirstOrDefault();

            txtWidthDesc.Text = query.Length_Size.ToString();
            txtUnit.Text = query.Length_Measurement_Unit;
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtWidthDesc.Text == "")
                {
                    lblLength.Visible = true;
                    correct = false;
                }
                if (txtUnit.Text == "")
                {
                    lblUnit.Visible = true;
                    correct = false;

                }

                if (txtWidthDesc.Text == "" || txtUnit.Text == "")
                {
                    lblLength.Visible = true;
                    lblUnit.Visible = true;

                    //MessageBox.Show("Please Enter a product length");
                    correct = false;
                }



                if (txtWidthDesc.Text != "" && txtUnit.Text != "")
                {

                    var query = db.pLengths.Where(co => co.Length_ID == tempID).FirstOrDefault();

                    query.Length_Size = Convert.ToInt32(txtWidthDesc.Text);
                    query.Length_Measurement_Unit = txtUnit.Text;

                    db.SaveChanges();
                    MessageBox.Show("Product Length Successfully Updated");
                    this.Close();
                }
            }
            catch
            {
                
            }
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product Length?", "Delete Product Length", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    pLength Emt2 = new pLength();
                    Emt2 = db.pLengths.Find(tempID);

                    db.pLengths.Remove(Emt2);
                    db.SaveChanges();

                    int length = Convert.ToInt32(Emt2.Length_ID);
                    string Length_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Length Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Length was not deleted");

                }
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void FrmMaintainLength_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtWidthDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
