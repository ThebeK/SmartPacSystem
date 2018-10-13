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

namespace MainSystem.Products.PackSize
{
    public partial class FrmSearchPackSize : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchPackSize(string x)
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

                int val = Convert.ToInt32(dgvProductPS.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Pack Size")
                {
                    FrmMaintainPackSize ff = new FrmMaintainPackSize(val);
                    ff.ShowDialog();
                    this.Activate();
                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product pack size search details first");
            }
            
        }

        private void FrmSearchPackSize_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void FrmSearchPackSize_Load(object sender, EventArgs e)
        {
            dgvProductPS.DataSource = db.Pack_Size.ToList();
            dgvProductPS.Columns[2].Visible = false;
            dgvProductPS.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductPS.Columns[1].HeaderText = "Pack Size";
        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Pack_Size on a.Pack_Size_ID equals a1.Pack_Size_ID

                           select new
                           {
                               a.Pack_Size_ID,
                               a1.Pack_Size_Description

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Pack_Size_Description == txtSearchPS.Text)
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try {
                if (txtSearchPS.Text == "")
                {
                    lblPackSize.Visible = true;

                    //MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchPS.Text != "")
                {

                    List<Pack_Size> PStype = db.Pack_Size.Where(o => o.Pack_Size_Description.ToLower().Contains(txtSearchPS.Text.ToLower())).ToList();


                    if (PStype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Product Pack Size found");

                    }

                    else
                    {
                        foreach (var a in PStype)
                        {
                            dgvProductPS.DataSource = PStype.Select(col => new { col.Pack_Size_ID, col.Pack_Size_Description }).ToList();

                            dgvProductPS.Columns[0].HeaderText = "Pack_Size_ID";
                            dgvProductPS.Columns[1].HeaderText = "Pack_Size_Description";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void txtSearchPS_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
