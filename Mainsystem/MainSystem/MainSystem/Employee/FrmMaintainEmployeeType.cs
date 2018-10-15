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

namespace MainSystem.Employees
{
    public partial class FrmMaintainEmployeeType : Form
    {
        int tempID;
        public FrmMaintainEmployeeType(int x)
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
            Process.Start(@".\" + "MaintainEmployeeType.pdf");
        }

        private void FrmMaintainEmployeeType_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.rtxtDescription, "Enter Employees Type/Role");
            toolTip1.SetToolTip(this.btnUpdate, "Click to edit Employees Type");
            toolTip1.SetToolTip(this.btnDelete, "Click to delete an employee Type");


            var query = db.Employee_Type.Where(co => co.Employee_Type_ID == tempID).First();

            rtxtDescription.Text = query.Employees_Type_Description;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            correct = true;

            if (rtxtDescription.Text == "")
            {
                lblDescription.Visible = true;
                //MessageBox.Show("Please Enter an Employee Type Description");
                correct = false;
            }
            else if (rtxtDescription.Text == "")
            {
                lblDescription.Visible = true;
                //MessageBox.Show("Please Enter employee type Text");
                correct = false;
            }

            if (correct == true)
            {

                var query = db.Employee_Type.Where(co => co.Employee_Type_ID == tempID).First();

                query.Employees_Type_Description = rtxtDescription.Text;

                db.SaveChanges();

                MessageBox.Show("Employee Type Successfully Updated");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Employee Type?", "Delete Employee Type", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Employee_Type Emt2 = new Employee_Type();
                    Emt2 = db.Employee_Type.Find(tempID);

                    db.Employee_Type.Remove(Emt2);
                    db.SaveChanges();

                    int Marketing = Emt2.Employee_Type_ID;
                    string Marketing_Template_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Employee Type Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    //MessageBox.Show("Error: Employee Type was not deleted");

                }
            }
        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
