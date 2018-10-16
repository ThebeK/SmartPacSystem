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
    public partial class frmASale : Form
    {
        public frmASale()
        {
            InitializeComponent();
            using (var context = new SPEntities())
            {
                var details = context.Products.ToList();
                productBindingSource.DataSource = details;
                cbxProductDesc.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxProductDesc.DisplayMember = "Product Description";
                //cbxProductDesc.DataSource = details;


            }
            cbxProductDesc.SelectedIndex = -1;
        }

        double total = 0;
        SPEntities db = new SPEntities();
        //method1
        public int CountSaleIDs()
        {
            int ID = 0;

            List<Sale> MyList = new List<Sale>();

            foreach (var item in db.Sales)
            {
                ID++;
            }

            return ID;

        }

        //method2
        public int QuantityOnHand(int ID)
        {
            int q = 0;

            foreach (var item in db.Products)
            {
                if (ID == item.Product_ID)
                {
                    q = Convert.ToInt32(item.Available_Quantity);
                    break;
                }
            }

            return q;
        }

        public void DecreaseProductQuantityOnHand(int ID, int quantity)
        {
            foreach (var item in db.Products)
            {
                if (ID == item.Product_ID)
                {
                    item.Available_Quantity = item.Available_Quantity - quantity;
                    break;
                }
            }

            db.SaveChanges();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MakeSale.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void frmASale_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                productBindingSource1.DataSource = db.Products.ToList();
            }
                // TODO: This line of code loads data into the 'sPDataSet6.Product' table. You can move, or remove it, as needed.
                //this.productTableAdapter1.Fill(this.sPDataSet6.Product);
                // TODO: This line of code loads data into the 'sPDataSet5.Product' table. You can move, or remove it, as needed.
                //this.productTableAdapter.Fill(this.sPDataSet5.Product);

                if (CountSaleIDs() == 0)
                {
                    txtSaleID.Text = "1";

                }
                else
                {
                    txtSaleID.Text = RetrieveLastSaleID().ToString();
                }

            DataTable t = new DataTable();
            t.Columns.Add("ProductID", typeof(Int32));
            t.Columns.Add("Product Name", typeof(string));
            t.Columns.Add("Product Quantity", typeof(Int32));
            t.Columns.Add("Product Price", typeof(double));
            t.Columns.Add("Total Price", typeof(double));

            dgvSale.DataSource = t;

        }
        List<Sales.SaleLine> SaleLineList = new List<Sales.SaleLine>();
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text != "" && txtPrice.Text != "" && cbxProductDesc.Text != "" && txtQuantity.Text!="")
            {
                Sales.SaleLine newline = new Sales.SaleLine(Convert.ToInt32(txtProdID.Text), cbxProductDesc.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), Convert.ToDouble((Convert.ToInt32(txtQuantity.Text) * Convert.ToDouble(txtPrice.Text))));
                SaleLineList.Add(newline);

                dgvSale.DataSource = null;
                dgvSale.DataSource = SaleLineList;
                //double amount = 0;
                if (SaleLineList.Any())
                {

                    for (int i = 0; i < dgvSale.Rows.Count; i++)
                    {
                        total = total + Convert.ToDouble(dgvSale.Rows[i].Cells[4].Value);

                    }

                    lblSaleIncludVAT.Text = "Sale Total (Included. VAT): R " + total.ToString();
                    lblSaleExludedVAT.Text = "Sale Total (Excluded. VAT): R" + (total - (total * RetreiveVATAmount() / 100)).ToString();
                    //lblSaleExludedVAT.Text = "Sale Total (Excluded. VAT): R"
                    lblVATPercentage.Text = "VAT: R" + (total * RetreiveVATAmount() / 100).ToString();


                    txtPrice.Clear();
                    txtQuantity.Clear();
                    txtProdID.Clear();
                    cbxProductDesc.ResetText();


                }


            }
            else
            {
                MessageBox.Show("Please enter all details.");
            }
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

        private void cbxProductDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var context = new SPEntities())
            {
                if (cbxProductDesc.SelectedItem!=null)
                {
                    int value = Convert.ToInt32(cbxProductDesc.SelectedValue);

                    var ID = context.Products.Where(z => z.Product_ID == value).First();

                    txtProdID.Text = ID.Product_ID.ToString();
                    txtPrice.Text = ID.Sales_Price.ToString();
                    txtQuantity.Text = ID.Available_Quantity.ToString();
                }
                

               // var details = context.Products.Where(x => x.Product_ID == ID.Product_ID).Select(x => x.Sales_Price).First();

                //var details1 = context.Products.Where(y => y.Product_ID == ID).FirstOrDefault();

                //txtProdID.Text = Convert.ToString(value);

                //txtPrice.Text = details.ToString();

            }
        }

        private void cbxProductDesc_TextChanged(object sender, EventArgs e)
        {
            //using (var context = new SPEntities())
            //{
            //    var q = context.Products.Where(x => x.Product_Description == cbxProductDesc.Text);
            //   int ID = q.Select(x => x.Product_ID).First();
            //    txtProdID.Text = Convert.ToString(ID);
            //    var details1 = (from a in db.Products
            //                    where a.Product_ID.Equals(ID)
            //                    select new
            //                    { a.Sales_Price }).ToList();
            //    txtPrice.Text = details1.ToString();

            //}
{ 

            }

        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                SaleLineList.RemoveAt(dgvSale.CurrentCell.RowIndex);
                dgvSale.DataSource = null;
                dgvSale.DataSource = SaleLineList;
                double amount = 0;
                if (SaleLineList.Any())
                {
                    foreach (var item in SaleLineList)
                    {
                        amount = item.Total;
                    }
                }
                   ;



            }
            catch
            {
                //MessageBox.Show("Please select an item to remove");
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtCash.Text == "")
                {
                    if (Convert.ToInt32(txtCash.Text) > 1000)
                    {
                        MessageBox.Show("Invalid Amount. Please insert an amount less than R1000");
                    }
                    else
                    {

                    }
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        int ID = 0;
        public int RetrieveLastSaleID()
        {


            List<Sale> MyList = new List<Sale>();
            List<Sale> ReturnList = new List<Sale>();

            foreach (var item in db.Sales)
            {
                MyList.Add(item);
            }

            ReturnList.Add(MyList.Last());

            foreach (var item in ReturnList)
            {
                ID = item.Sale_Id;
                break;
            }

            return ID;
        }
        string saleID;
        DataSet ds = new DataSet();
        DataTable dtb = new DataTable();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtCash.Text != "")
                {
                    if (Convert.ToDouble(txtCash.Text) >= total)
                    {
                        Sale newsale = new Sale();
                        newsale.Sale_Date = DateTime.Now;
                        newsale.Amount = Convert.ToDecimal(total);

                        db.Sales.Add(newsale);
                        saleID = txtSaleID.Text;
                        foreach (var item in SaleLineList)
                        {
                            if (QuantityOnHand(item.ProductID) >= item.Quantity)
                            {
                                Sales_Order_line sale = new Sales_Order_line();
                                sale.Product_ID = Convert.ToInt32(dgvSale.CurrentRow.Cells[0].Value);
                                //sale.Sale_Id = Convert.ToInt32(txtSaleID.Text);


                                decimal SalesPrice = Convert.ToDecimal(dgvSale.CurrentRow.Cells[3].Value);
                                //var details1 = db.Products.Where(y => y.Product_ID == sale.Product_ID).FirstOrDefault();
                                //sale.Product_ID =  details1.Product_ID;

                                sale.Product_Quantity = Convert.ToInt32(dgvSale.CurrentRow.Cells[2].Value);
                                double change = 0;

                                db.Sales_Order_line.Add(sale);
                                //db.SaveChanges();
                                change = Convert.ToDouble(txtCash.Text) - total;
                                MessageBox.Show("Sale has been succesfully, " + "" + "  Your change is R:" + " " + change);

                                dtb.Columns.Add("ProductID", typeof(Int32));
                                dtb.Columns.Add("Product Name", typeof(string));
                                dtb.Columns.Add("Product Quantity", typeof(Int32));
                                dtb.Columns.Add("Product Price", typeof(double));
                                dtb.Columns.Add("Total Price", typeof(double));

                                foreach (DataGridViewRow dgv in dgvSale.Rows)
                                {
                                    dtb.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
                                }

                                ds.Tables.Add(dtb);
                                ds.WriteXmlSchema("Invoice.xml");
                                btnDelete.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Insufficent quantity available");
                            }
                        }
                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Please enter sufficient funds");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter amount paid");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            Sales.frmReport r = new Sales.frmReport(dtb, ds, saleID);
            r.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
