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

namespace MainSystem.Products
{
    public partial class FrmSearchProduct : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchProduct(string x)
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

        private void FrmSearchProduct_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainProduct.pdf");
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            dgvClientSearch.DataSource = db.Widths.ToList();
            dgvClientSearch.Columns[3].Visible = false;
            dgvClientSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClientSearch.Columns[2].HeaderText = "Unit";
        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Widths on a.Width_ID equals a1.Width_ID

                           select new
                           {
                               a.Width_ID,
                               a1.Width_Size,
                               a1.Width_Measurement_Unit

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Width_Size == Convert.ToInt32(txtSearchSale.Text))
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
                if (txtSearchSale.Text == "")
                {
                    label3.Visible = true;
                    //MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchSale.Text != "")
                {
                    //FIX
                    List<Width> PStype = db.Widths.Where(o => o.Width_Size.ToString().Contains(txtSearchSale.Text.ToLower())).ToList();


                    if (PStype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Product Width found");

                    }

                    else
                    {
                        foreach (var a in PStype)
                        {
                            dgvClientSearch.DataSource = PStype.Select(col => new { col.Width_ID, col.Width_Measurement_Unit, col.Width_Size }).ToList();

                            dgvClientSearch.Columns[0].HeaderText = "Width_ID";
                            dgvClientSearch.Columns[1].HeaderText = "Width_Measurement_Unit";
                            dgvClientSearch.Columns[2].HeaderText = "Width_Size";


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

                if (option == "Maintain Product")
                {
                    FrmMaintainProduct ff = new FrmMaintainProduct(val);
                    ff.ShowDialog();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product pack size search details first");
            }
        }

        private void txtSearchSale_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
