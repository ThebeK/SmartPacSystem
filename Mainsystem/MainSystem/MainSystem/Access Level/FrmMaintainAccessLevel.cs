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



namespace MainSystem.AccessLevel
{
    public partial class FrmMaintainAccessLevel : Form
    {
        int AccessId;
        SPEntities db = new SPEntities();
        
        public FrmMaintainAccessLevel(string val)
        {
            InitializeComponent();
            AccessId = Convert.ToInt32(val);
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
        private void FrmMaintainAccessLevel_Load(object sender, EventArgs e)
        { //tips
            toolTip1.SetToolTip(this.txtAccessName, "Please enter access name");
            toolTip1.SetToolTip(this.btnDelete, "Click to remove access level");
            toolTip1.SetToolTip(this.btnUpdate, "Click to edit access level");
            var query = db.Access_Level.Where(co => co.Access_Level_Id == AccessId).FirstOrDefault();
            var mark = db.User_Role.Where(co => co.User_Role_Id == query.Access_Level_Id).FirstOrDefault();

            txtAccessName.Text = query.Access_Level_Name;
            cbxAdminScreen.Checked = query.User_Role.Admin_Role;
            cbxUserAccessLevelScreen.Checked = query.User_Role.User_And_Access_Level_Role;
            cbxEmployeeScreen.Checked = query.User_Role.Employee_Role;
            cbxSupplierOrderScreen.Checked = query.User_Role.Supplier_Order_Role;
            cbxPurchaseOrderScreen.Checked = query.User_Role.Client_Order_Role;
            cbxProductScreen.Checked = query.User_Role.Product_Role;
            cbxClient.Checked = query.User_Role.Client_Role;
            cbxReportsScreen.Checked = query.User_Role.Reports_Role;
            cbWebsite.Checked = query.User_Role.Website_Role;
            cbxSaleScreen.Checked = query.User_Role.Sale_Role;
            cbxVehicleScreen.Checked = query.User_Role.Vehicle_Role;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainAccessLevel.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = db.Access_Level.Where(co => co.Access_Level_Id == AccessId).FirstOrDefault();
                var UserRole = db.User_Role.Where(co => co.User_Role_Id == query.Access_Level_Id).FirstOrDefault();

                Access_Level CurrentAccessLevel = new Access_Level();
                User_Role CurrentRole = new User_Role();

                CurrentAccessLevel = db.Access_Level.Where(co => co.Access_Level_Id == AccessId).FirstOrDefault();
                CurrentRole = db.User_Role.Where(co => co.User_Role_Id == query.Access_Level_Id).FirstOrDefault();

                var Newquery = db.Access_Level.Where(co => co.Access_Level_Id == AccessId).FirstOrDefault();
                var NewUserRole = db.User_Role.Where(co => co.User_Role_Id == query.Access_Level_Id).FirstOrDefault();

                query.Access_Level_Name = txtAccessName.Text;
                UserRole.Admin_Role = cbxAdminScreen.Checked;
                UserRole.User_And_Access_Level_Role = cbxUserAccessLevelScreen.Checked;
                UserRole.Employee_Role = cbxEmployeeScreen.Checked;
                UserRole.Supplier_Order_Role = cbxSupplierOrderScreen.Checked;
                UserRole.Client_Order_Role = cbxPurchaseOrderScreen.Checked;
                UserRole.Product_Role = cbxProductScreen.Checked;
                UserRole.Client_Role = cbxClient.Checked;
                UserRole.Reports_Role = cbxReportsScreen.Checked;
                UserRole.Website_Role = cbWebsite.Checked;
                UserRole.Sale_Role = cbxSaleScreen.Checked;
                UserRole.Vehicle_Role = cbxVehicleScreen.Checked;

                db.SaveChanges();
                MessageBox.Show("Access Level Updated Successfully");

            }
            catch (Exception)
            {

                MessageBox.Show("An error occured, please try again");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
