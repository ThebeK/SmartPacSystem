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
    public partial class FrmMaintainVehicle : Form
    {
        int tempID;
        public FrmMaintainVehicle(int x)
        {
            InitializeComponent();
            tempID = x;
            vehicleBindingSource.DataSource = db.Vehicles.ToList();
            vehicleStatusBindingSource.DataSource = db.Vehicle_Status.ToList();
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
            this.Hide();
            rs.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchVehicle.pdf");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool correct = false;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                correct = true;

                if (txtMake.Text == "")
                {

                    MessageBox.Show("Please Enter a Vehicle Make");
                    correct = false;
                }
                if (txtModel.Text == "")
                {

                    MessageBox.Show("Please Enter a Vehicle Model");
                    correct = false;
                }
                if (txtRegNo.Text == "")
                {

                    MessageBox.Show("Please Enter a Vehicle Registration Number");
                    correct = false;
                }
                if (txtVIN.Text == "")
                {

                    MessageBox.Show("Please Enter a Vehicle VIN Code");
                    correct = false;
                }


                if (correct == true)
                {
                   
                    var query = db.Vehicles.Where(co => co.Vehicle_ID == tempID).FirstOrDefault();

                    query.Vehicle_Make = txtMake.Text;
                    query.Vehicle_Model = txtModel.Text;
                    query.Vehicle_Registration_Number = txtRegNo.Text;
                    query.VIN_Number = txtVIN.Text;
                    query.Last_Serviced = dtpLastServiced.Value;
                    query.Vehicle_Status_ID = Convert.ToInt32(cbxStatus.SelectedValue);

                    //var query2 = db.Vehicle_Status.Where(co => co.Vehicle_Status_ID == tempID).FirstOrDefault();
                    //query.Vehicle_Status_ID = query2.Vehicle_Status_ID;
                    //query.Vehicle_Status_ID = cbxStatus.SelectedIndex + 1;
                    //query.Last_Serviced = dtpLastServiced.Value;


                    db.SaveChanges();
                    MessageBox.Show("Vehicle Successfully Updated");
                    this.Close();
                }
            }
            catch { }
        }

        private void FrmMaintainVehicle_Load(object sender, EventArgs e)
        {
            var query = db.Vehicles.Where(co => co.Vehicle_ID == tempID).First();

            txtMake.Text = query.Vehicle_Make;
            txtModel.Text = query.Vehicle_Model;
            txtRegNo.Text = query.Vehicle_Registration_Number;
            txtVIN.Text = query.VIN_Number;
            dtpLastServiced.Value = Convert.ToDateTime(query.Last_Serviced);
            cbxStatus.SelectedValue = query.Vehicle_Status_ID;

            
            //var quer1y = db.Vehicles.Where(co => co.Vehicle_ID == tempID).FirstOrDefault();
            //Vehicle vehicle = new Vehicle();
            //vehicle = db.Vehicles.Where(co => co.Vehicle_ID == tempID).First();

            //var newq= db.Vehicles.Where(co => co.Vehicle_ID == tempID).First();
            //cbxStatus.DataSource = db.Vehicle_Status.ToList();
            //cbxStatus.ValueMember = "Vehicle_Status_Description";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Vehicle VehicleM = new Vehicle();
                    VehicleM = db.Vehicles.Find(tempID);

                    db.Vehicles.Remove(VehicleM);
                    db.SaveChanges();
                   // db.SaveChangesAsync();

                    int vehM = Convert.ToInt32(VehicleM.Vehicle_ID);
                    string Vehicle_Value = Convert.ToString(VehicleM);
                    MessageBox.Show("Vehicle Successfully Deleted");
                    this.Close();

                }
                catch
                {


                }
            }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
