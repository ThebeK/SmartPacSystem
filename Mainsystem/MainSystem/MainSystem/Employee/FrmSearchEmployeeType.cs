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
    public partial class FrmSearchEmployeeType : Form
    {
        string option;
        public FrmSearchEmployeeType(string x)
        {
            InitializeComponent();
            option = x;
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

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvClientSearch.CurrentRow.Cells[0].Value);

                if (option == "Maintain Employee Type")
                {
                    FrmMaintainEmployeeType form1 = new FrmMaintainEmployeeType(val);
                    form1.ShowDialog();

                    this.Close();
                    
                }

            }

            catch 
            {
                // MessageBox.Show("please specify your employee type you want to search");
            }
        }

        private void FrmSearchEmployeeType_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchEmployeeType.pdf");
        }

        private void FrmSearchEmployeeType_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtSearchEmployeeType, "Enter a Employees Type search criteria");
            toolTip1.SetToolTip(this.btnSearch, "Click to Search Employees Type/Role");
            toolTip1.SetToolTip(this.btnMaintain, "Click to edit or remove employee type");
            dgvClientSearch.DataSource = db.Employee_Type.ToList();

            dgvClientSearch.Columns[2].Visible = false;
            //this.dgvClientSearch.Columns["Employee"].Visible = false;
            dgvClientSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClientSearch.Columns[1].HeaderText = "Type/Role";
            dgvClientSearch.Columns[0].HeaderText = "ID";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEmployeeType.Text == "")
            {
                label3.Visible = true;

                // MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchEmployeeType.Text != "")
            {

                List<Employee_Type> Etype = db.Employee_Type.Where(o => o.Employees_Type_Description.Contains(txtSearchEmployeeType.Text)).ToList();


                if (Etype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Employee type found");

                }

                else
                {
                    foreach (var a in Etype)
                    {

                        dgvClientSearch.DataSource = Etype.Select(col => new { col.Employee_Type_ID, col.Employees_Type_Description }).ToList();



                        //groupBox1.Visible = true;
                    }
                }
            }
        }

        private void txtSearchEmployeeType_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
