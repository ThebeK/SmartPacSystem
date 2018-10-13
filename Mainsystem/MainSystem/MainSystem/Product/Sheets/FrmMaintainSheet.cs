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
    public partial class FrmMaintainSheet : Form
    {
        int tempID;
        public FrmMaintainSheet(int x)
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

        private void FrmMaintainSheet_Load(object sender, EventArgs e)
        {
            var query = db.Sheets.Where(co => co.Sheet_ID == tempID).FirstOrDefault();

            txtProductTypeDesc.Text = query.Number_Of_Sheet.ToString();
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Sheet Number?", "Delete Product Sheet Number", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Sheet prodT2 = new Sheet();
                    prodT2 = db.Sheets.Find(tempID);

                    db.Sheets.Remove(prodT2);
                    db.SaveChanges();

                    int Sheets = prodT2.Sheet_ID;
                    string sheet_Value = Convert.ToString(prodT2);
                    MessageBox.Show("Product Sheet Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    //MessageBox.Show("Error: Sheet was not deleted");

                }
            }
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtProductTypeDesc.Text == "")
                {
                    lblSheet.Visible = true;
                    //MessageBox.Show("Please Enter a product sheet number");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Sheets.Where(co => co.Sheet_ID == tempID).FirstOrDefault();

                    query.Number_Of_Sheet = Convert.ToInt32(txtProductTypeDesc.Text);

                    db.SaveChanges();
                    MessageBox.Show("Product Sheet Number Successfully Updated");
                    this.Close();
                }
            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Sheet Number not updated");
            }
        }

        private void txtProductTypeDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
