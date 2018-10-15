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

namespace MainSystem
{
    public partial class frmRefundSale : Form
    {
        public frmRefundSale()
        {
            InitializeComponent();
        }
        BindingList<SaleReturn> ReturnLine = new BindingList<SaleReturn>();
        SPEntities db = new SPEntities();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "RefundSale.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public List<object> Get(int ID)
        {
            var details = (from a in db.Sales_Order_line
                           where a.Sale_Id == ID
                           join a1 in db.Products on a.Product_ID equals a1.Product_ID
                           //join a2 in db.Sales_Unit_Price on a.Sales_Price_ID equals a2.Sales_Price_ID
                           //join a3 in db.Plies on a.Ply_ID equals a3.Ply_ID

                           select new
                           {
                               a.Sales_Order_line_Id,
                               a.Product_ID,
                               a1.Product_Description,
                               a1.Sales_Price,
                               a.Product_Quantity,
                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {

                retrurn.Add(item);

            }
            return retrurn;
        }
        public double RetrieveProductPrice(int ID)
        {
            double price = 0;

            foreach (var item in db.Products)
            {
                if (item.Product_ID == ID)
                {
                    price = Convert.ToDouble(item.Sales_Price);
                    break;
                }
            }

            return price;
        }
        private void frmRefundSale_Load(object sender, EventArgs e)
        {
            try
            {
                dgv1.DataSource = Get(clsGlobals.saleID);

                dgv1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv1.Columns[2].HeaderText = "Description";

                txtSale.Text = clsGlobals.saleID.ToString();


            }
            catch
            {

            }
        }
        List<SaleReturn> salereturnlist = new List<SaleReturn>();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numUDQuantity.Value > Convert.ToInt32(dgv1.CurrentRow.Cells[4].Value))
                {
                    MessageBox.Show("Quantity to return cannot be more than quantity bought");
                }
                else
                {
                    int quantity = 0;
                    int Quantity1 = Convert.ToInt32(dgv1.CurrentRow.Cells[4].Value);
                    if (numUDQuantity.Value != 0 && txtProductID.Text != "")
                    {

                        int ID = Convert.ToInt32(dgv1.CurrentRow.Cells[0].Value);
                        foreach (var item in db.Refund_Line)
                        {
                            if (item.Sales_Order_Line_ID == ID)
                            {
                                quantity += Convert.ToInt32(item.Refund_Quantity);
                            }
                        }
                    }

                    int Quantity3 = Quantity1 - quantity;
                    if (numUDQuantity.Value > Quantity3)
                    {
                        MessageBox.Show(quantity.ToString() + " has been alredy been return." + Quantity3.ToString() + " is only available to return.");
                    }
                    else
                    {
                        SaleReturn return1 = new SaleReturn(Convert.ToInt32(dgv1.CurrentRow.Cells[0].Value), Convert.ToInt32(dgv1.CurrentRow.Cells[1].Value), Convert.ToString(dgv1.CurrentRow.Cells[2].Value), Convert.ToInt32(numUDQuantity.Value), Convert.ToInt32(dgv1.CurrentRow.Cells[3].Value));
                        salereturnlist.Add(return1);
                        dgv2.DataSource = salereturnlist;

                        double total = 0;

                        for (int i = 0; i < dgv2.Rows.Count; i++)
                        {
                            total += Convert.ToInt32(numUDQuantity.Value) * Convert.ToDouble(dgv2.CurrentRow.Cells[4].Value);
                        }

                        lblSaleIncludVAT.Text = "Sale Total (Included. VAT): R" + total.ToString();
                        lblSaleExludedVAT.Text = "Sale Total (Excluded. VAT): R" + (total - (total * RetreiveVATAmount() / 100)).ToString();
                        lblVATPercentage.Text = "Sale Total(Included.VAT): R" + (total * RetreiveVATAmount() / 100).ToString();

                    }
                }
            }
            catch
            {
                //MessageBox.Show(er.ToString());
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtProductID.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            }

            catch
            {
                MessageBox.Show("Please select a product to return");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                salereturnlist.RemoveAt(dgv2.CurrentCell.RowIndex);
                dgv2.DataSource = null;
                dgv2.DataSource = salereturnlist;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Sale_Refund refund = new Sale_Refund();
                refund.Refund_Date = DateTime.Now;
                db.Sale_Refund.Add(refund);
                db.SaveChanges();

                foreach (var item in salereturnlist)
                {
                    Refund_Line refundline = new Refund_Line();
                    refundline.Refund_Amount = Convert.ToDecimal(item.GrossPrice);
                    refundline.Refund_Quantity = item.Quantity;
                    refundline.Sales_Order_Line_ID = item.SaleLineID;
                    refundline.Sale_Refund_ID = RetrieveLastSaleRefundID();
                    db.Refund_Line.Add(refundline);
                    db.SaveChanges();
                }
                MessageBox.Show("Success");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        public int RetrieveLastSaleRefundID()
        {
            int ID = 0;

            List<Sale_Refund> MyList = new List<Sale_Refund>();
            List<Sale_Refund> ReturnList = new List<Sale_Refund>();

            foreach (var item in db.Sale_Refund)
            {
                MyList.Add(item);
            }

            ReturnList.Add(MyList.Last());

            foreach (var item in ReturnList)
            {
                ID = item.Sale_Refund_Id;
                break;
            }

            return ID;
        }
        public double RetreiveVATAmount()
        {
            double vat = 0;
            List<Company_Information> Mylist = new List<Company_Information>();
            List<Company_Information> ReturmList = new List<Company_Information>();

            foreach (var item in db.Company_Information)
            {
                Mylist.Add(item);
            }
            ReturmList.Add(Mylist.Last());
            foreach (var item in ReturmList)
            {
                vat = Convert.ToDouble(item.VAT_Percentage);
                break;
            }

            return Math.Round(vat, 2);
        }
    }
}
