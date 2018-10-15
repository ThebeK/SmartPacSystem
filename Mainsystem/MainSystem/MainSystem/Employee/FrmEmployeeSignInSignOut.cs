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
    public partial class FrmEmployeeSignInSignOut : Form
    {
        public FrmEmployeeSignInSignOut()
        {
            InitializeComponent();
            employeeBindingSource.DataSource = db.Employees.ToList();
            employeeLogsheetBindingSource.DataSource = db.Employee_Logsheet.ToList();
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

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            Employees.FrmAddEmployee red = new Employees.FrmAddEmployee();
            red.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employees.FrmSearchEmployee red = new Employees.FrmSearchEmployee();
            red.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "EmployeeSignIn.pdf");
        }

        private void FrmEmployeeSignInSignOut_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbxEmployeeName, "Select Employees Name");
            toolTip1.SetToolTip(this.btnAddProdType, "Click to add employee");
            toolTip1.SetToolTip(this.pictureBox1, "Click to edit employee");
            //
            toolTip1.SetToolTip(this.pictureBox1, "Click to edit employee");
            toolTip1.SetToolTip(this.chbxTimeIN, "Tick for time in");
            toolTip1.SetToolTip(this.chbxTimeOut, "Tick for time out");
            toolTip1.SetToolTip(this.chbxLunchIn, "Tick for lunch time in");
            toolTip1.SetToolTip(this.chbxLunchO, "Tick for lunch time out");



            //employeeLogsheetBindingSource.DataSource = db.Employee_Logsheet.ToList();


            var query = db.Employees.ToList();
            employeeBindingSource1.DataSource = query;




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool correct = false;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            correct = false;
            try
            {
                Employee_Logsheet empL = new Employee_Logsheet();

               
             
                    if (chbxTimeIN.Checked == true)
                    {

                        empL.Time_In = (txtTimeIN.Text);

                    }
                    else if (chbxTimeOut.Checked == true)
                    {
                        empL.Time_Out = (txtTimeOut.Text);
                    }
                    else if (chbxLunchO.Checked == true)
                    {

                        empL.Lunch_Out = (txtLunchOut.Text);

                    }
                    else
                    {

                        empL.Lunch_In = (txtLunchIn.Text);
                    }






                    empL.Employee_Id = Convert.ToInt32(comboBox1.SelectedValue);
                    empL.Day_Of_The_Week = DateTime.Now;





                    db.Employee_Logsheet.Add(empL);
                    // string employee_value = Convert.ToString(empL);
                    db.SaveChanges();
                    MessageBox.Show("Time Logged Successfully");
                    this.Close();
                }
            
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbxTimeIN_CheckedChanged(object sender, EventArgs e)
        {

            txtTimeIN.Text = DateTime.Now.ToString("HH:mm");
        }

        private void chbxTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            txtTimeOut.Text = DateTime.Now.ToString("HH:mm");
        }

        private void chbxLunchIn_CheckedChanged(object sender, EventArgs e)
        {
            txtLunchIn.Text = DateTime.Now.ToString("HH:mm");
        }

        private void chbxLunchO_CheckedChanged(object sender, EventArgs e)
        {
            txtLunchOut.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
