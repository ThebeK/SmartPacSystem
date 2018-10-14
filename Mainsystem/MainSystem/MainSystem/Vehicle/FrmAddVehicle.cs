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
    public partial class FrmAddVehicle : Form
    {
        string option;
        SPEntities db = new SPEntities();
        public FrmAddVehicle(string x)
        {
            option = x;
            InitializeComponent();
        }
        public bool ValidateIfVehicleExists(string RegN)
        {
            bool Check = false;
            foreach (var item in db.Vehicles)
            {
                if (item.Vehicle_Registration_Number == RegN)
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
            Process.Start(@".\" + "AddVehicle.pdf");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool correct = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            correct = true;
            Vehicle vehicle = new Vehicle();
            try
            {

                if (ValidateIfVehicleExists(txtRegNo.Text) == true)
                {
                    MessageBox.Show("Vehicles registration number already exists");
                    correct = false;
                }

                if (txtMake.Text == "" || txtModel.Text == "" || txtRegNo.Text == "" || txtVIN.Text == "")
                {
                    MessageBox.Show("Please Enter Vehicles details");
                    correct = false;
                }
                if (txtRegNo.Text == "")
                {
                    lblReg.Visible = true;
                    correct = false;
                }
                if (txtModel.Text == "")
                {
                    lblModel.Visible = true;
                    correct = false;
                }
                if (txtVIN.Text == "")
                {
                    lblVIN.Visible = true;
                    correct = false;
                }
                if (txtMake.Text == "")
                {
                    lblMake.Visible = true;
                    correct = false;
                }



                if (correct == true)
                {
                    vehicle.Vehicle_Make = txtMake.Text;
                    vehicle.Vehicle_Model = txtModel.Text;
                    vehicle.Vehicle_Registration_Number = txtRegNo.Text;
                    Vehicle_Status st = cbxStatus.SelectedItem as Vehicle_Status;
                    vehicle.Vehicle_Status_ID = st.Vehicle_Status_ID;
                    vehicle.Last_Serviced = dtpLastServiced.Value;
                    //vehicle.Vehicle_Status.Vehicle_Status_Description = "Active";// cbxStatus.Text;
                    vehicle.VIN_Number = txtVIN.Text;
                    db.Vehicles.Add(vehicle);
                    string Vehicle_value = Convert.ToString(vehicle);

                    db.SaveChanges();
                    MessageBox.Show("Vehicles Added Successfully");

                    this.Close();
                }


            }

            catch 
            {

            }
        }

        private void FrmAddVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPDataSet.Vehicle_Status' table. You can move, or remove it, as needed.
            //this.vehicle_StatusTableAdapter.Fill(this.sPDataSet.Vehicle_Status);
            cbxStatus.DataSource = db.Vehicle_Status.ToList();
            cbxStatus.ValueMember = "Vehicle_Status_Description";
            cbxStatus.SelectedIndex = -1;
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtMake_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtVIN_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
