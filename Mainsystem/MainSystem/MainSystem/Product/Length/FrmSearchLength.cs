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

namespace MainSystem.Products.Length
{
    public partial class FrmSearchLength : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchLength(string x)
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
            try
            {

                int val = Convert.ToInt32(dgvLength.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Length")
                {//FIX
                    FrmMaintainLength form1 = new FrmMaintainLength(val);
                    form1.ShowDialog();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product length search details first");
            }
            this.Show();
            this.Activate();
        }

        private void FrmSearchLength_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.pLengths on a.Length_ID equals a1.Length_ID

                           select new
                           {
                               a.Length_ID,
                               a1.Length_Size,
                               a1.Length_Measurement_Unit

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Length_Size == Convert.ToInt32(txtSearchLength.Text))
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
                if (txtSearchLength.Text == "")
                {
                    lblSearch.Visible = true;
                    //MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchLength.Text != "")
                {
                    //FIX
                    List<pLength> PStype = db.pLengths.Where(o => o.Length_Size.ToString().Contains(txtSearchLength.Text.ToLower())).ToList();


                    if (PStype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Product Length found");

                    }

                    else
                    {
                        foreach (var a in PStype)
                        {
                            dgvLength.DataSource = PStype.Select(col => new { col.Length_ID, col.Length_Measurement_Unit, col.Length_Size }).ToList();

                            dgvLength.Columns[0].HeaderText = "Length_ID";
                            dgvLength.Columns[1].HeaderText = "Length_Measurement_Unit";
                            dgvLength.Columns[2].HeaderText = "Length_Size";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void FrmSearchLength_Load(object sender, EventArgs e)
        {
            dgvLength.DataSource = db.pLengths.ToList();
            dgvLength.Columns[3].Visible = false;
            dgvLength.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLength.Columns[2].HeaderText = "Unit";
        }

        private void txtSearchLength_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
