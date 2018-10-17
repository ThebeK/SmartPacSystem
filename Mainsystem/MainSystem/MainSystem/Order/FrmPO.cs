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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net.Mail;
using System.Windows.Forms;


namespace MainSystem.Order
{
    public partial class FrmPO : Form
    {
        SPEntities db = new SPEntities();
        int polid;
        Client_Purchase_Order newPO;
        Client_Purchase_Order xPO;
        Client_Purchase_Order_Line pol;
        decimal pa = Decimal.Round(0, 2);
        decimal ca = Decimal.Round(0, 2);
        ReportDocument repdoc = new ReportDocument();
        string pdfFile = AppDomain.CurrentDomain.BaseDirectory+"Invoices\\invoice.pdf";
        public FrmPO()
        {
            InitializeComponent();
            clientBindingSource.DataSource = db.Clients.ToList();
            productBindingSource.DataSource = db.Products.ToList();
            comboBox1.SelectedIndex = -1;
            cbxClient.SelectedIndex = -1;
            var q1 = db.Company_Information.Select(ci => ci.VAT_Percentage).FirstOrDefault();
            lblVATRate.Text = "Total VAT @" + q1 + "%: R";
            btnRemove.Enabled = false;
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
        private void FrmPO_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtAccNum, "Enter Account Number");
            toolTip1.SetToolTip(this.txtCreditApprovalAmount, "Enter valid amount");
            toolTip1.SetToolTip(this.txtCreditBalance, "Enter correct credit balance");
            toolTip1.SetToolTip(this.txtGrossTotalVE, "gross total excluding VAT");
            toolTip1.SetToolTip(this.txtGrossTotalVI, "gross total including VAT");
            toolTip1.SetToolTip(this.txtQuantity, "Enter Quantity for purchase");
            toolTip1.SetToolTip(this.txtGrossTotalVI, "Enter Total");
            toolTip1.SetToolTip(this.txtVAT, "View VAT");
            toolTip1.SetToolTip(this.rbtnDelNo, "Select for no delivery");
            toolTip1.SetToolTip(this.rbtnDelYes, "Select for delivery");
            toolTip1.SetToolTip(this.button2, "Click to Add");
            toolTip1.SetToolTip(this.btnConfirm, "Click to Confirm");

            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(Int32));
            t.Columns.Add("Product", typeof(string));
            t.Columns.Add("Quantity", typeof(Int32));
            t.Columns.Add("Unit Price", typeof(decimal));
            t.Columns.Add("Purchase Order Number", typeof(string));
            t.Columns.Add("Subtotal", typeof(decimal));

            dataGridView1.DataSource = t;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                if (cbxClient.SelectedItem != null)
                {
                    int clid = Convert.ToInt32(cbxClient.SelectedValue);
                    var q = db.Clients.Where(c => c.Client_ID == clid).FirstOrDefault();
                    txtAccNum.Text = q.CL_Number.ToString();
                    var q2 = db.Credit_Approval.Where(ca => ca.Credit_Approval_ID == q.Credit_Approval_ID).FirstOrDefault();

                    txtCreditApprovalAmount.Text = q2.Credit_Approval_Amount.ToString();

                    var q1 = db.Client_Purchase_Order.Where(po => po.Client_ID == clid).ToList();
                    txtCreditBalance.Text = (Convert.ToDecimal(txtCreditApprovalAmount.Text) - Convert.ToDecimal(q1.Sum(g => g.Gross_Amount))).ToString();

                    newPO = new Client_Purchase_Order()
                    {
                        Order_Date = DateTime.Today,
                        Payment_Terms_ID = 1,
                        Client_ID = Convert.ToInt32(cbxClient.SelectedValue),

                    };
                    db.Client_Purchase_Order.Add(newPO);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (newPO != null)
                {
                    int prid = Convert.ToInt32(comboBox1.SelectedValue);
                    var q = db.Products.Where(p => p.Product_ID == prid).FirstOrDefault();


                    var q1 = db.Client_Purchase_Order_Line.Where(cpol => cpol.Product_ID == prid && cpol.Client_Purchase_Id == newPO.Client_Purchase_Id).FirstOrDefault();

                    if (pol == null)
                    {
                        pol = new Client_Purchase_Order_Line()
                        {
                            Client_Purchase_Id = newPO.Client_Purchase_Id,
                            Product_ID = Convert.ToInt32(comboBox1.SelectedValue),
                            Quantity = Convert.ToInt32(txtQuantity.Text),

                        };
                        db.Client_Purchase_Order_Line.Add(pol);

                        db.SaveChanges();
                        var q3 = db.Client_Purchase_Order.Where(x => x.Client_Purchase_Id == newPO.Client_Purchase_Id).First();
                        dataGridView1.DataSource = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).ToList();

                        var q2 = db.Company_Information.Select(ci => ci.VAT_Percentage).First();
                        txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) + pa).ToString();
                        txtGrossTotalVI.Text = Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)).ToString();
                        txtGrossTotalVE.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).
                            Sum(pol => pol.Subtotal)) * (1 - (q2 / 100)), 2).ToString();

                        txtVAT.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)) * (q2 / 100), 2).ToString();
                        ca = Convert.ToDecimal(txtGrossTotalVI.Text);
                        txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) - ca).ToString();
                        pa = ca;


                    }
                    else
                    {
                        var q3 = db.Client_Purchase_Order.Where(x => x.Client_Purchase_Id == newPO.Client_Purchase_Id).First();
                        if (q1 == null)
                        {
                            pol = new Client_Purchase_Order_Line()
                            {
                                Client_Purchase_Id = newPO.Client_Purchase_Id,
                                Product_ID = Convert.ToInt32(comboBox1.SelectedValue),
                                Quantity = Convert.ToInt32(txtQuantity.Text),

                            };
                            db.Client_Purchase_Order_Line.Add(pol);

                            db.SaveChanges();
                            dataGridView1.DataSource = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).ToList();

                            var q2 = db.Company_Information.Select(ci => ci.VAT_Percentage).FirstOrDefault();
                            txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) + pa).ToString();
                            txtGrossTotalVI.Text = Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)).ToString();
                            txtGrossTotalVE.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).
                                Sum(pol => pol.Subtotal)) * (1 - (q2 / 100)), 2).ToString();

                            txtVAT.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)) * (q2 / 100), 2).ToString();
                            ca = Convert.ToDecimal(txtGrossTotalVI.Text);
                            txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) - ca).ToString();
                            pa = ca;


                        }
                        else
                        {
                            var q4 = db.Client_Purchase_Order_Line.Where(cpol => cpol.Client_Purchase_Id == newPO.Client_Purchase_Id && cpol.Client_Purchase_Order_Line_ID == q1.Client_Purchase_Order_Line_ID).
                                FirstOrDefault();
                            q4.Quantity += Convert.ToInt32(txtQuantity.Text);

                            db.SaveChanges();
                            dataGridView1.DataSource = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).ToList();
                            var q2 = db.Company_Information.Select(ci => ci.VAT_Percentage).FirstOrDefault();
                            txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) + pa).ToString();
                            txtGrossTotalVI.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)), 2).ToString();
                            txtGrossTotalVE.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).
                                Sum(pol => pol.Subtotal)) * (1 - (q2 / 100)), 2).ToString();

                            txtVAT.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)) * (q2 / 100), 2).ToString();
                            ca = Convert.ToDecimal(txtGrossTotalVI.Text);
                            txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) - ca).ToString();
                            pa = ca;


                        }
                    }





                }
                else if (xPO != null)
                {
                    int prid = Convert.ToInt32(comboBox1.SelectedValue);



                    pol = new Client_Purchase_Order_Line()
                    {
                        Client_Purchase_Id = newPO.Client_Purchase_Id,
                        Product_ID = Convert.ToInt32(comboBox1.SelectedValue),
                        Quantity = Convert.ToInt32(txtQuantity.Text),

                    };
                    db.Client_Purchase_Order_Line.Add(pol);



                }
                else
                {
                    MessageBox.Show("Please select a client");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong!,Please try again " + ex.ToString());
            }
            groupBox3.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {

                    db.Client_Purchase_Order_Line.
                    Remove(db.Client_Purchase_Order_Line.Where(pol => pol.Client_Purchase_Order_Line_ID == polid).
                    FirstOrDefault() as Client_Purchase_Order_Line);

                    db.SaveChanges();
                    var q3 = db.Client_Purchase_Order.Where(x => x.Client_Purchase_Id == newPO.Client_Purchase_Id).First();
                    dataGridView1.DataSource = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).ToList();
                    //CalculateSubtotal();
                    var q1 = db.Company_Information.Select(ci => ci.VAT_Percentage).FirstOrDefault();
                    txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) + pa).ToString();
                    txtGrossTotalVI.Text = Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)).ToString();
                    txtGrossTotalVE.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)) * (1 - (q1 / 100)), 2).ToString();

                    txtVAT.Text = Decimal.Round(Convert.ToDecimal(db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == q3.PO_Number).Sum(pol => pol.Subtotal)) * (q1 / 100), 2).ToString();
                    ca = Convert.ToDecimal(txtGrossTotalVI.Text);
                    txtCreditBalance.Text = (Convert.ToDecimal(txtCreditBalance.Text) - ca).ToString();
                    pa = ca;
                    btnRemove.Enabled = false;

                }
                catch (Exception)
                {


                }
                
            }
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbtnDelYes != null)
                {
                    newPO.Gross_Amount = Convert.ToDecimal(txtGrossTotalVI.Text);
                    newPO.Purchase_Order_Status_ID = 1;
                    newPO.Dispatch_Type_Id = 1;
                }
                else if (rbtnDelNo != null)
                {
                    newPO.Gross_Amount = Convert.ToDecimal(txtGrossTotalVI.Text);
                    newPO.Purchase_Order_Status_ID = 1;
                    newPO.Dispatch_Type_Id = 2;
                }
                dt.Columns.Add("ID", typeof(Int32));
                dt.Columns.Add("Product", typeof(string));
                dt.Columns.Add("Quantity", typeof(Int32));
                dt.Columns.Add("Unit Price", typeof(decimal));
                dt.Columns.Add("Purchase Order Number", typeof(string));
                dt.Columns.Add("Subtotal", typeof(decimal));

                foreach(DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
                }
                ds.Tables.Add(dt);
                ds.WriteXmlSchema("POInvoice.xml");

                db.SaveChanges();

                tabControl1.SelectedIndex = 1;
                //repdoc.Load(AppDomain.CurrentDomain.BaseDirectory + "\\rpts\\PurchaseOrderInvoiceCrystalReport1.rpt");
                
                //repdoc.SetParameterValue( newPO.Client_Purchase_Id,"@poid");
                //crystalReportViewer1.ReportSource = repdoc;
                //crystalReportViewer1.Refresh();

            }
            catch (Exception)
            {


            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
            polid = Convert.ToInt32(r.Cells[0].Value.ToString());
            btnRemove.Enabled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                
                ExportOptions ExpOpts;
                DiskFileDestinationOptions DFDO = new DiskFileDestinationOptions();
                PdfFormatOptions PFO = new PdfFormatOptions();
                DFDO.DiskFileName = pdfFile;
                ExpOpts = repdoc.ExportOptions;

                ExpOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                ExpOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
                ExpOpts.DestinationOptions = DFDO;
                ExpOpts.FormatOptions = PFO;
                repdoc.Export();
                SendMail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("infolopac@gmail.com");
                mail.To.Add("u16101163@tuks.co.za");
                mail.Subject = "Test Mail - 1";
                mail.Body = "mail with attachment";

                Attachment attachment;
                attachment = new Attachment(pdfFile);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("infolopac@gmail.com", "infolopac1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void FrmPO_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseOrderCrystalReport21_InitReport(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            POInvoiceCrystalReport1Latest po = new POInvoiceCrystalReport1Latest();
            po.SetDataSource(ds);
            crystalReportViewer1.ReportSource = po; 
        }
    }
}
