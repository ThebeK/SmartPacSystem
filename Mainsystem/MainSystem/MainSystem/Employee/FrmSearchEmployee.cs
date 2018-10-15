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
    public partial class FrmSearchEmployee : Form
    {
        SPEntities db = new SPEntities();
        public FrmSearchEmployee()
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

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            FrmMaintainEmployee mEmployee = new FrmMaintainEmployee(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value));
            mEmployee.ShowDialog();
        }

        private void FrmSearchEmployee_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchEmployee.pdf");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtSeachEmployee, "Enter Employees Name");
            toolTip1.SetToolTip(this.btnMaintain, "Click to edit or delete employee");
            toolTip1.SetToolTip(this.btnSearch, "Click to search for employee");


            dgvEmployees.DataSource = Get1();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public List<object> Get1()
        {
            var details = (from a in db.Employees

                           join a8 in db.Employee_Type on a.Employee_Type_ID equals a8.Employee_Type_ID

                           //join a11 in db.Users on a.Users_Id equals a11.Users_Id
                           join a12 in db.Titles on a.Title_Id equals a12.Title_Id


                           //where a.Employee_Name.Contains(name)
                           select new
                           {
                               a.Employee_Id,
                               a.Employee_Name,
                               a.Employee_Surname,
                               a.Employee_Email_Address,
                               a.Employee_Id_Number,
                               a.Employee_Account_Number,
                               a.Employee_Tax_Number,
                               a8.Employees_Type_Description,
                               a.Employee_Cellphone_Number,
                               a.Employee_Address,
                               //a11.Users_Name,
                               a12.Title_Description


                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }



        public List<object> Get(string name)
        {
            var details = (from a in db.Employees

                           join a8 in db.Employee_Type on a.Employee_Type_ID equals a8.Employee_Type_ID

                           //join a11 in db.Users on a.Users_Id equals a11.Users_Id
                           join a12 in db.Titles on a.Title_Id equals a12.Title_Id


                           where a.Employee_Name.Contains(name)
                           select new
                           {
                               a.Employee_Id,
                               a.Employee_Name,
                               a.Employee_Surname,
                               a.Employee_Email_Address,
                               a.Employee_Id_Number,
                               a.Employee_Account_Number,
                               a.Employee_Tax_Number,
                               a8.Employees_Type_Description,
                               a.Employee_Cellphone_Number,
                               a.Employee_Address,
                               
                               a12.Title_Description


                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeachEmployee.Text == "")
                {

                    //MessageBox.Show("Error: No search details entered");
                    lblEmployeeSearch.Visible = true;


                }
                else if (txtSeachEmployee.Text != "")
                {

                    List<Employee> Etype = db.Employees.Where(o => o.Employee_Name.Contains(txtSeachEmployee.Text)).ToList();


                    if (Etype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Employee  found");

                    }

                    else
                    {
                        foreach (var a in Etype)
                        {

                            //    dgvEmployees.DataSource = Etype.Select(col => new { col.Employee_Id,col.Employee_Name, col.Employee_Surname, col.Employee_Tax_Number, col.Employee_Id_Number, col.Employee_Address, col.Employee_Cellphone_Number, col.Employee_Account_Number, col.Employee_Email_Address, col.Employee_Type }).ToList();

                            dgvEmployees.DataSource = Get(txtSeachEmployee.Text);

                            dgvEmployees.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            dgvEmployees.Columns[0].HeaderText = "ID";
                            dgvEmployees.Columns[1].HeaderText = "Name";
                            dgvEmployees.Columns[2].HeaderText = "Surname";
                            dgvEmployees.Columns[3].HeaderText = "Email Address";
                            dgvEmployees.Columns[4].HeaderText = "Identity_No";
                            dgvEmployees.Columns[5].HeaderText = "Account_No";
                            dgvEmployees.Columns[6].HeaderText = "Tax_No";
                            dgvEmployees.Columns[7].HeaderText = "Role/Type";
                            dgvEmployees.Columns[8].HeaderText = "Contact";
                            dgvEmployees.Columns[9].HeaderText = "Address";
                            dgvEmployees.Columns[10].HeaderText = "Title";
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void txtSeachEmployee_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
