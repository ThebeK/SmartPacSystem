﻿using System;
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

namespace MainSystem
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            Products.FrmAddProductType qq = new Products.FrmAddProductType();
            qq.ShowDialog();
            this.Show();
            this.Activate();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Products.FrmSearchProductType qq = new Products.FrmSearchProductType();
            qq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmAddBrand wq = new Products.Brand.FrmAddBrand();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmSearchBrand wq = new Products.Brand.FrmSearchBrand();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products.Length.FrmAddLength wq = new Products.Length.FrmAddLength();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Products.Length.FrmSearchLength wq = new Products.Length.FrmSearchLength();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void btnAddPackSize_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Products.Pack_Size.FrmSearchPackSize wq = new Products.Pack_Size.FrmSearchPackSize();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void btnAddSheetNumber_Click(object sender, EventArgs e)
        {
            Products.Sheet.FrmAddSheet wq = new Products.Sheet.FrmAddSheet();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Products.Sheet.FrmSearchSheet wq = new Products.Sheet.FrmSearchSheet();
            wq.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtDescription, "Products Name");
            toolTip1.SetToolTip(this.txtQuantity, "Number of Products");
            toolTip1.SetToolTip(this.cbxbrand, "Select Products Brand");
            toolTip1.SetToolTip(this.cbxLength, "Select Products Length");
            toolTip1.SetToolTip(this.cbxPackSize, "Select Number of packs");
            toolTip1.SetToolTip(this.cbxprodT, "Select product type");
            toolTip1.SetToolTip(this.cbxWidth, "Select Width size");
            toolTip1.SetToolTip(this.cbxSheet, "Select Sheet");
            toolTip1.SetToolTip(this.btnAdd, "Click to add product");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
