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

namespace MainSystem.Products.Brand
{
    public partial class FrmAddBrand : Form
    {
        string option;
        SPEntities db = new SPEntities();
        bool correct = false;
        public FrmAddBrand(string x)
        {
            InitializeComponent();
            option = x;
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
        public bool ValidateIfBrandExists(string brandNAME)
        {
            bool Check = false;
            foreach (var item in db.Product_Brand)
            {
                if (item.Product_Brand_Name == brandNAME)
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }
        private void FrmAddBrand_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                correct = true;
                Product_Brand prodB = new Product_Brand();
                if (ValidateIfBrandExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Product Brand exists");
                    correct = false;
                }
               else if (rtxtDescription.Text == "")
                {
                    lblBrandDes.Visible = true;
                    //essageBox.Show("Please Enter brand details");
                    correct = false;
                }

                if (correct == true)
                {
                    prodB.Product_Brand_Name = rtxtDescription.Text;
                    MessageBox.Show("Product Successfully Added");
                    db.Product_Brand.Add(prodB);

                    db.SaveChanges();

                    int Product_Type_ID = prodB.Product_Brand_ID;
                    string ProdT_value = Convert.ToString(prodB);
                    //MessageBox.Show("Product Successfully Added");
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Please enter valid details");
                }



            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Product Type Not Added");
            }
        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
