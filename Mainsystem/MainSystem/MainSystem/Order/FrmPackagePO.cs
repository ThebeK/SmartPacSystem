using System;
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
using System.Drawing.Printing;
using QRCoder;

namespace MainSystem.Order
{
    public partial class FrmPackagePO : Form
    {
        SPEntities db = new SPEntities();
        List<string> po = new List<string>();
        string ponum;
        public FrmPackagePO()
        {
            InitializeComponent();
            var qs = db.Supplier_Order.Where(x => x.Supplier_Order_Status_ID == 2).ToList();
            dataGridView1.DataSource = db.Load_Purchase_Order_1().Where(lpo => lpo.Purchase_Order_Status_Description == "Placed").ToList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnGenerateQR.Enabled = false;
            dataGridView1.ReadOnly = true;
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

        private void FrmPackagePO_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnGenerateQR, "Click to make QR");
            toolTip1.SetToolTip(this.btnContinue, "Click to go to next tab");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            frmPOLine f = new frmPOLine(ponum);
            f.ShowDialog();
            btnGenerateQR.Enabled = false;

            PrintDocument p = new PrintDocument();

            p.PrintPage += p_PrintPage_1;
            printPreviewDialog1.Document = p;
            printPreviewDialog1.ShowDialog();
            
        }
        private void p_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Image myI;
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel.L);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(ponum, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        myI = qrCode.GetGraphic(20, Color.Black, Color.White, true);
                    }
                }
            }
            e.Graphics.DrawImage(myI, 0, 0, 400, 400);
            e.Graphics.DrawString(ponum, new Font("arial", 30), Brushes.Black, 50, 350);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            ponum = r.Cells[0].Value.ToString();
            btnGenerateQR.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmScanQR scan = new frmScanQR();
            scan.ShowDialog();
            var q = db.Client_Purchase_Order.Where(po => po.PO_Number == scan.DecodeID).First();
            q.Purchase_Order_Status_ID = 2;
            var q2 = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q.PO_Number).First();
            
            var q3 = db.Getpoduct().Where(x => x.Product_Description == q2.Product).First();
            //int w = Convert.ToInt32(q.Available_Quantity);

            //q3.Available_Quantity +;
            db.Products.Where(x => x.Product_ID == q3.Product_ID).First().Available_Quantity -= q2.Quantity;
            
            db.SaveChanges();
            frmPOLine f = new frmPOLine(scan.DecodeID);
            var q1 = db.Purchase_Order_Status.Where(pos => pos.Purchase_Order_Status_ID == q.Purchase_Order_Status_ID).First();
            dgvPackaged.DataSource = db.Load_Purchase_Order_1().
                Where(lpo => lpo.Purchase_Order_Status_Description == q1.Purchase_Order_Status_Description).ToList();
            dataGridView1.DataSource = db.Load_Purchase_Order_1().Where(lpo => lpo.Purchase_Order_Status_Description == "Placed").ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPackaged_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvPackaged.Rows[e.RowIndex];
            ponum = r.Cells[0].Value.ToString();
            btnGenerateQR.Enabled = true;
            frmPOLine f = new frmPOLine(ponum);
            f.ShowDialog();
        }
    }
}
