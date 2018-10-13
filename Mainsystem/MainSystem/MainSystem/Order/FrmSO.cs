using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net.Mail;


namespace MainSystem
{
    public partial class frmSO : Form
    {
        public frmSO()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        Supplier_Order newSO;
        Supplier_Order_Line newSOL;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void addNewSO()
        {
              newSO = new Supplier_Order()
                {
                    Supplier_Order_Date = DateTime.Today,
                    Supplier_Order_Status_ID = 1,
                    Supplier_Id = 1
                };
                db.Supplier_Order.Add(newSO);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (newSO != null)
            {
                int prid = Convert.ToInt32(comboBox2.SelectedValue);
                var q = db.Products.Where(p => p.Product_ID == prid).FirstOrDefault();
                var q1 = db.Supplier_Order_Line.Where(sol => sol.Product_ID == prid && sol.Supplier_Order_Id == newSO.Supplier_Order_Id).FirstOrDefault();
                if (newSOL == null)
                {
                    newSOL = new Supplier_Order_Line()
                    {
                        Supplier_Order_Id = newSO.Supplier_Order_Id,
                        Product_ID = Convert.ToInt32(comboBox2.SelectedValue),
                        Quantity = Convert.ToInt32(numericUpDown1.Value)
                    };
                    db.Supplier_Order_Line.Add(newSOL);
                    db.SaveChanges();
                    var q2 = db.Supplier_Order.Where(x => x.Supplier_Order_Id == newSO.Supplier_Order_Id).First();
                    dataGridView1.DataSource = db.GetSOL(newSO.Supplier_Order_Id).Where(x => x.SO_Number == q2.SO_Number).ToList();

                }
                else
                {
                    var q3 = db.Supplier_Order.Where(x => x.Supplier_Order_Id == newSO.Supplier_Order_Id).First();
                    if (q1 == null)
                    {
                        newSOL = new Supplier_Order_Line()
                        {
                            Supplier_Order_Id = newSO.Supplier_Order_Id,
                            Product_ID = Convert.ToInt32(comboBox2.SelectedValue),
                            Quantity = Convert.ToInt32(numericUpDown1.Value)
                        };
                        db.Supplier_Order_Line.Add(newSOL);
                        //q.Available_Quantity -= Convert.ToInt32(numericUpDown1.Value);
                        db.SaveChanges();
                        dataGridView1.DataSource = db.GetSOL(newSO.Supplier_Order_Id).Where(x => x.SO_Number == q3.SO_Number).ToList();
                    }
                    else
                    {
                        var q4 = db.Supplier_Order_Line.Where(sol => sol.Supplier_Order_Id == newSO.Supplier_Order_Id && sol.Supplier_Order_Line_ID == q1.Supplier_Order_Line_ID).
                                    FirstOrDefault();
                        q4.Quantity += Convert.ToInt32(numericUpDown1.Value);
                        //q.Available_Quantity -= Convert.ToInt32(numericUpDown1.Value);
                        db.SaveChanges();
                        dataGridView1.DataSource = db.GetSOL(newSO.Supplier_Order_Id).Where(x => x.SO_Number == q3.SO_Number).ToList();
                    }
                }
            }
        }

        private void frmSO_Load(object sender, EventArgs e)
        {
            
            groupBox4.Enabled = false;
            numericUpDown1.Enabled = false;
            button2.Enabled = false;
            productBindingSource.DataSource=db.Products.ToList();
            comboBox2.SelectedIndex = -1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            numericUpDown1.Enabled = true;
            
                addNewSO();
                button2.Enabled = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var q1 = db.Client_Purchase_Order.Where(c => c.Supplier_Order_Id == null)
                .Select(c => c.Client_Purchase_Id).ToList();

                var q = db.Client_Purchase_Order_Line.OrderBy(c => c.Product_ID).GroupBy(c => c.Product_ID).
                   Select(s => new { Client_Purchase_Order_Line = s.Key, totalquantity = s.Sum(r => r.Quantity), }).ToList();
                var q2 = db.GetTotalQty().ToList();

                if (MessageBox.Show("Are you sure you want to place order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (q2.FirstOrDefault() != null)
                    {
                        addNewSO();

                        foreach (var item in q2)
                        {
                            newSOL = new Supplier_Order_Line()
                            {
                                Supplier_Order_Id = newSO.Supplier_Order_Id,
                                Product_ID = item.Product_ID,
                                Quantity = Convert.ToInt32(item.Total_Quantity)
                            };
                            db.Supplier_Order_Line.Add(newSOL);

                        }
                        foreach (var item in q1)
                        {
                            Client_Purchase_Order xpo = db.Client_Purchase_Order.Single(po => po.Client_Purchase_Id == item);
                            xpo.Supplier_Order_Id = newSO.Supplier_Order_Id;
                        }
                        db.SaveChanges();
                        dataGridView1.DataSource = db.GetSOL(newSO.Supplier_Order_Id).ToList();
                    }
                    else
                    {
                        MessageBox.Show("There are no client orders to be added");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        ReportDocument repdoc = new ReportDocument();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 1;
                repdoc.Load("D:\\DesktopApp_2\\SONote.rpt");
                repdoc.SetParameterValue("@soid", newSO.Supplier_Order_Id);
                crystalReportViewer1.ReportSource = repdoc;
            }
            catch (Exception)
            {

               
            }
            
        }
        string pdfFile = "D:\\DesktopApp_2\\bin\\Debug\\Supplier Order Notes\\SONote.pdf";

        private void button6_Click(object sender, EventArgs e)
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
    }
}
