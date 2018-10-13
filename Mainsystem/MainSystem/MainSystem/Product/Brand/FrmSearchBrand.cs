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

namespace MainSystem.Products.Brand
{
    public partial class FrmSearchBrand : Form
    {
        string option;
        SPEntities db = new SPEntities();
        public FrmSearchBrand(string x)
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

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    int val = Convert.ToInt32(dgvBrand.CurrentRow.Cells[0].Value);

                    if (option == "Maintain Product Brand")
                    {
                        Brand.FrmMaintainBrand ww = new Brand.FrmMaintainBrand(val);
                        ww.ShowDialog();
                        this.Show();
                        this.Activate();



                        this.Close();

                    }

                }

                catch 
                {
                    // MessageBox.Show("Please specify your product brand search details first");
                }
            }

        }

        private void FrmSearchBrand_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Product_Brand on a.Product_Brand_ID equals a1.Product_Brand_ID

                           select new
                           {
                               a1.Product_Brand_ID,
                               a1.Product_Brand_Name

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Product_Brand_Name == txtSearchBrand.Text)
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchBrand.Text == "")
                {
                    lblSearchBrand.Visible = true;
                    //ssageBox.Show("Error: No search details entered");

                }
                else if (txtSearchBrand.Text != "")
                {

                    List<Product_Brand> Brandtype = db.Product_Brand.Where(o => o.Product_Brand_Name.Contains(txtSearchBrand.Text)).ToList();


                    if (Brandtype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Brand found");

                    }

                    else
                    {
                        foreach (var a in Brandtype)
                        {
                            dgvBrand.DataSource = Brandtype.Select(col => new { col.Product_Brand_ID, col.Product_Brand_Name }).ToList();
                            dgvBrand.DataSource = Get();
                            dgvBrand.Columns[0].HeaderText = "Product_Brand_ID";
                            dgvBrand.Columns[1].HeaderText = "Product_Brand_Name";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }

            catch
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSearchBrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPDataSet.Product_Brand' table. You can move, or remove it, as needed.
            this.product_BrandTableAdapter.Fill(this.sPDataSet.Product_Brand);
            dgvBrand.DataSource = db.Product_Brand.ToList();
            //dgvBrand.Columns[2].Visible = false;
            dgvBrand.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBrand.Columns[1].HeaderText = "Brand Name";
        }

        private void txtSearchBrand_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
