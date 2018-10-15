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
    public partial class FrmAddAccessLevel : Form
    {
        public SPEntities db = new SPEntities();
        Access_Level NewAccess = new Access_Level();
        User_Role NewRole = new User_Role();
        Active_User NewUser = new Active_User();
        public FrmAddAccessLevel()
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
            this.Hide();
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtAccessName.Text == "")
            {
                MessageBox.Show("Please enter Access Level Name");
            }
            else
            {
                try
                {
                    if (cbxAdminScreen.Checked == true || cbxUserAccessLevelScreen.Checked == true || cbxEmployeeScreen.Checked == true || cbxSupplierOrderScreen.Checked == true || cbxPurchaseOrderScreen.Checked == true || cbxProductScreen.Checked == true || cbxClient.Checked == true || cbxReportsScreen.Checked == true || cbxSaleScreen.Checked == true || cbxVehicleScreen.Checked == true)
                    {

                        if (db.Access_Level.Where(al => al.Access_Level_Name == txtAccessName.Text.ToUpper()).Count() == 0)
                        {
                            NewRole.Admin_Role = cbxAdminScreen.Checked;
                            NewRole.Client_Role = cbxClient.Checked;
                            NewRole.Employee_Role = cbxEmployeeScreen.Checked;
                            NewRole.Product_Role = cbxProductScreen.Checked;
                            NewRole.Reports_Role = cbxReportsScreen.Checked;
                            NewRole.Sale_Role = cbxSaleScreen.Checked;
                            NewRole.Supplier_Order_Role = cbxSupplierOrderScreen.Checked;
                            NewRole.Client_Order_Role = cbxPurchaseOrderScreen.Checked;
                            NewRole.Vehicle_Role = cbxVehicleScreen.Checked;
                            NewRole.User_And_Access_Level_Role = cbxUserAccessLevelScreen.Checked;
                            NewRole.Website_Role = false;




                            db.User_Role.Add(NewRole);
                            NewAccess.Access_Level_Name = txtAccessName.Text.ToUpper();
                            NewAccess.Role_Id = NewRole.User_Role_Id;
                            db.Access_Level.Add(NewAccess);
                            db.SaveChanges();
                            

                            MessageBox.Show("Access level added successfully");
                            //Audit Log
                            int accessidz = NewAccess.Access_Level_Id;
                            string access_Value = Convert.ToString(NewAccess);

                            Audit_Log Current_Audit4 = new Audit_Log();
                            Current_Audit4.Table_Name = "Access Level";
                            // Current_Audit3.Users_Id = Globals.Users_Id;
                            Current_Audit4.Date_Time = DateTime.Now;
                            db.Audit_Log.Add(Current_Audit4);
                            db.SaveChanges();
                            int Log_ID4 = Current_Audit4.Audit_Log_Id;


                            Audit_Create_Delete Current_Create4 = new Audit_Create_Delete();
                            Current_Create4.Audit_Log_Id = Log_ID4;
                            Current_Create4.Created = true;
                            Current_Create4.PK_Row_Effected = accessidz;
                            Current_Create4.Value = access_Value;
                            db.Audit_Create_Delete.Add(Current_Create4);
                            db.SaveChanges();
                            this.Close();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Access level already exists");
                        }




                    }

                    else
                    {
                        MessageBox.Show("Please select atleast one access level");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Whoops, An Error Occured, Please try again" + ex);
                }

            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAddAccessLevel_Load(object sender, EventArgs e)
        {   //tips
            toolTip1.SetToolTip(this.txtAccessName, "Enter Access Level Name");
            toolTip1.SetToolTip(this.btnAdd, "Click to Add");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddAccessLevel.pdf");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
