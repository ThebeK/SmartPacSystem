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
    public partial class FrmAddEmployeeType : Form
    {
        string option;
        public FrmAddEmployeeType(string x)
        {
            InitializeComponent();
            option = x;
        }

        SPEntities db = new SPEntities();
        bool correct = false;

        public bool ValidateIfEmployeeTypeExists(string EmployeeTypeDescription)
        {
            bool Check = false;
            foreach (var item in db.Employee_Type)
            {
                if (item.Employees_Type_Description == EmployeeTypeDescription)
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
            Process.Start(@".\" + "AddEmployeeType.pdf");
        }

        private void FrmAddEmployeeType_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.rtxtDescription, "Enter Employees Type/Role");
            toolTip1.SetToolTip(this.btnAdd, "Click to add Employees Type/Role");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            correct = true;
            Employee_Type EmT = new Employee_Type();

            try
            {

                foreach (var item in db.Employee_Type)
                {
                    if (item.Employees_Type_Description == rtxtDescription.Text)
                    {
                        MessageBox.Show("Employee Type already exists");
                        correct = false;
                    }
                }
                //if (ValidateIfEmployeeTypeExists(rtxtDescription.Text) == true)
                //{
                //    MessageBox.Show("Employee Type already exists");
                //    correct = false;
                //}



                if (rtxtDescription.Text == "")
                {
                    lblDescription.Visible = true;
                    //MessageBox.Show("Please Enter Employee type details");
                    correct = false;
                }

                else if (rtxtDescription.Text == "")
                {
                    lblDescription.Visible = true;
                    // MessageBox.Show("Please Enter Employee type details");
                    correct = false;
                }
                else
                {
                    correct = true;
                    EmT.Employees_Type_Description = rtxtDescription.Text;
                    //EmT.Employees_Type1 = txtEmployeeType.Text;


                    db.Employee_Type.Add(EmT);

                    db.SaveChanges();

                    MessageBox.Show("Employee Type Added Successfully");
                    this.Close();
                }
            }
            catch { }
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
