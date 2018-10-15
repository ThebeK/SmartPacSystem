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

namespace MainSystem.Vehicles
{
    public partial class FrmSearchVehicle : Form
    {
        string option;
        public FrmSearchVehicle(string x)
        {
            InitializeComponent();
            option = x;
        }

        SPEntities db = new SPEntities();
        public List<object> Get1()
        {
            var details = (from a in db.Vehicles
                           join a1 in db.Vehicle_Status on a.Vehicle_Status_ID equals a1.Vehicle_Status_ID
                           //where a.Vehicle_Make.ToUpper().Contains(y)
                           select new
                           {
                               a.Vehicle_ID,

                               a.Vehicle_Make,
                               a.Vehicle_Model,
                               a.Vehicle_Registration_Number,
                               a1.Vehicle_Status_ID,
                               a.VIN_Number,
                               a.Last_Serviced,
                               a.V_Number

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                
                    retrurn.Add(item);
                
            }
            return retrurn;
        }
        public List<object> Get(string y)
        {
            var details = (from a in db.Vehicles
                           join a1 in db.Vehicle_Status on a.Vehicle_Status_ID equals a1.Vehicle_Status_ID
                           where a.Vehicle_Make.ToUpper().Contains(y)
                           select new
                           {
                               a.Vehicle_ID,

                               a.Vehicle_Make,
                               a.Vehicle_Model,
                               a.Vehicle_Registration_Number,
                               a1.Vehicle_Status_Description,
                               a.VIN_Number,
                               a.Last_Serviced

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Vehicle_ID == Convert.ToInt32(txtSearchSale.Text))
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
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
            this.Hide();
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchVehicle_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchVehicle.pdf");
        }

        private void FrmSearchVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPDataSet2.Vehicle' table. You can move, or remove it, as needed.
            //this.vehicleTableAdapter1.Fill(this.sPDataSet2.Vehicle);
            dgvClientSearch.DataSource = Get1();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSale.Text == "")
                {
                    label2.Visible = true;
                    // MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchSale.Text != "")
                {

                    List<Vehicle> Vtype = db.Vehicles.Where(o => o.Vehicle_Make.Contains(txtSearchSale.Text)).ToList();
                    // dgvVehicleSearch.DataSource = Get(txtSearchVehicle.Text);


                    if (Vtype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Vehicle  found");

                    }

                    else
                    {
                        foreach (var a in Vtype)
                        {

                            dgvClientSearch.DataSource = Vtype.Select(col => new { col.Vehicle_ID, col.Vehicle_Make, col.Vehicle_Model, col.Vehicle_Registration_Number, col.Vehicle_Status.Vehicle_Status_Description, col.VIN_Number }).ToList();
                            dgvClientSearch.DataSource = Vtype;
                            dgvClientSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            dgvClientSearch.Columns[0].HeaderText = "Vehicle ID";
                            dgvClientSearch.Columns[1].HeaderText = "Vehicle Make";
                            dgvClientSearch.Columns[2].HeaderText = "Vehicle Model";
                            dgvClientSearch.Columns[3].HeaderText = "Vehicle Registration Nunmber";
                            dgvClientSearch.Columns[4].HeaderText = "Vehicle VIN Number";
                            dgvClientSearch.Columns[5].HeaderText = "Last Serviced";
                            dgvClientSearch.Columns[6].HeaderText = "Vehicle Status";
                            dgvClientSearch.Columns[7].HeaderText = "Vehicle Number";



                            //groupBox1.Visible = true;
                        }
                    }
                }
            }
            catch { }
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvClientSearch.CurrentRow.Cells[0].Value);

                if (option == "Maintain Vehicle")
                {
                    FrmMaintainVehicle form1 = new FrmMaintainVehicle(val);
                    form1.ShowDialog();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Please specify your vehicle search details first");
            }
        }
    }
}
