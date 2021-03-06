﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUp.frmHelp GG = new StartUp.frmHelp();
            GG.ShowDialog();
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmASale a = new frmASale();
            a.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void searchSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchSale ab = new frmSearchSale(0);
            ab.ShowDialog();

            this.Show();
            this.Activate();

        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient client = new frmAddClient();
            client.ShowDialog();
        }

        private void maintainClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchClient dd = new frmSearchClient("Maintain Client");
            dd.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct rr = new frmAddProduct();
            rr.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void addAccessLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessLevel.FrmAddAccessLevel al = new AccessLevel.FrmAddAccessLevel();
            al.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.FrmAddUser a2 = new Users.FrmAddUser("Maintain Access Level");
            a2.ShowDialog();


        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessLevel.FrmSearchAccessLevel qw = new AccessLevel.FrmSearchAccessLevel("Maintain Access Level");
            qw.ShowDialog();



        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.FrmAddEmployee eew = new Employees.FrmAddEmployee();
            eew.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void maintainEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Employees.FrmSearchEmployee eew = new Employees.FrmSearchEmployee();
            eew.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void addEmployeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.FrmAddEmployeeType eew = new Employees.FrmAddEmployeeType("");
            eew.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void maintainEmployeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.FrmSearchEmployeeType eew = new Employees.FrmSearchEmployeeType("Maintain Employee Type");
            eew.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void employeeLogsheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.FrmEmployeeSignInSignOut eew = new Employees.FrmEmployeeSignInSignOut();
            eew.ShowDialog();
            this.Show();
            this.Activate();
        }
        private void LoadAccess()
        {

            if (!clsGlobals.Userlogin.Access_Level.User_Role.Admin_Role)
            {
                administrationToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Client_Role)
            {
                clientToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Client_Order_Role)
            {
                purchaseOrderToolStripMenuItem.Visible = false;
                supplierOrderToolStripMenuItem.Visible = true;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Employee_Role)
            {
                employeeToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Product_Role)
            {
                productToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Reports_Role)
            {
                reportsToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Supplier_Order_Role)
            {
                supplierOrderToolStripMenuItem.Visible = false;
                purchaseOrderToolStripMenuItem.Visible = true;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Supplier_Order_Role && !clsGlobals.Userlogin.Access_Level.User_Role.Client_Order_Role)
            {
                supplierOrderToolStripMenuItem.Visible = false;
                purchaseOrderToolStripMenuItem.Visible = false;
                orderToolStripMenuItem.Visible = false;

            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.User_And_Access_Level_Role)
            {
                userAccessLevelToolStripMenuItem.Visible = false;

            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Vehicle_Role)
            {
                vehicleToolStripMenuItem.Visible = false;
            }
            if (!clsGlobals.Userlogin.Access_Level.User_Role.Sale_Role)
            {
                saleToolStripMenuItem.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            LoadAccess();

            SmartPacDash Dash = new SmartPacDash(0);

            Dash.TopLevel = false;
            Dash.AutoScroll = true;
            this.panel1.Controls.Add(Dash);
            Dash.BringToFront();
            Dash.Dock = DockStyle.Fill;
            Dash.Show();

            label1.Text = "Logged in as: " + frmLogin.setvalue;
        }

        private void maintainClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Products.FrmSearchProduct qw = new Products.FrmSearchProduct("Maintain Product");
            qw.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.FrmAddProductType ee = new Products.FrmAddProductType("Maintain Product T");
            ee.TopLevel = false;
            ee.AutoScroll = true;
            this.panel1.Controls.Add(ee);
            ee.BringToFront();
            ee.Dock = DockStyle.Fill;
            ee.Show();
        }

        private void maintainProductTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.FrmSearchNotification ff = new Admin.FrmSearchNotification("Publish Email");
            ff.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void maintainUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Users.FrmSearchUser su = new Users.FrmSearchUser("Maintain User");
            su.ShowDialog();
            
            //Users.FrmMaintainUser su = new Users.FrmMaintainUser();
            //su.ShowDialog();
            //this.Show();
            //this.Activate();
        }

        private void generatePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.FrmPO gf = new Order.FrmPO();
            gf.TopLevel = false;
            gf.AutoScroll = true;
            this.panel1.Controls.Add(gf);
            gf.BringToFront();
            gf.Dock = DockStyle.Fill;
            gf.Show();

        }

        private void packagePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.FrmPackagePO gg = new Order.FrmPackagePO();
            gg.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void loadPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.FrmLoadPO gg = new Order.FrmLoadPO();
            gg.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void generateDeliveryRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoutePlan gg = new frmRoutePlan();
            gg.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void confirmDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmDelivery gg = new frmConfirmDelivery();
            gg.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void generateCreditRetunrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.frmSearchPO tgv = new Order.frmSearchPO();
            //tgv.ShowDialog();
            tgv.Show();
            //this.Activate();
        }

        private void generatePurchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmReceiveSO f = new frmReceiveSO();
                f.ShowDialog();
                this.Show();
                this.Activate();

            }
            catch (Exception)
            {


            }
        }

        private void generateSupplierOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSO gg = new frmSO();
            gg.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.FrmBackUp qq = new Admin.FrmBackUp();
            qq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void updateCompanyImformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.FrmUpdateCompanyInformation qq = new Admin.FrmUpdateCompanyInformation();
            qq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                frmLogin ml = new frmLogin();
                this.Hide();
                ml.ShowDialog();
                this.Close();

            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
           
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicles.FrmAddVehicle av = new Vehicles.FrmAddVehicle("Maintain Vehicle");
            av.ShowDialog();

        }

        private void maintainVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicles.FrmSearchVehicle sv = new Vehicles.FrmSearchVehicle("Maintain Vehicle");
            sv.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartPacDash f = new SmartPacDash(0);
            f.TopLevel = false;
            f.AutoScroll = true;
            this.panel1.Controls.Add(f);
            f.BringToFront();
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
