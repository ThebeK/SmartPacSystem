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
using MainSystem;

namespace MainSystem
{
    public partial class frmCreditReturn : Form
    {
        SPEntities db = new SPEntities();
        Credit_Return newCR;
        Credit_Return_Line newCRL;
        int polid;
        int poid;
        int crid;
        string PO;
        public frmCreditReturn(string PO_num)
        {
            InitializeComponent();
            PO = PO_num;
            //dataGridView1.DataSource = db.Load_Purcase_Order_Line();
            reasonForReturnBindingSource.DataSource = db.Reason_For_Return.ToList();
            
        }
        private void CalculateSubtotal()
        {

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                decimal subtotal = Convert.ToInt32(r.Cells[dataGridView1.Columns["quantity"].Index].Value) *
                   Convert.ToDecimal(r.Cells[dataGridView1.Columns["order_price"].Index].Value);
                r.Cells[dataGridView1.Columns["subtotal"].Index].Value = subtotal;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var q = db.Client_Purchase_Order.Where(po => po.PO_Number == textBox1.Text).FirstOrDefault();
            //    poid = Convert.ToInt32(q.Client_Purchase_Id);
            //    dataGridView1.DataSource = db.GetPOL(poid).ToList();
            //    CalculateSubtotal();
            //}
            //catch (Exception)
            //{

                
            //}
            
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                var q = db.Client_Purchase_Order_Line.Where(op => op.Client_Purchase_Order_Line_ID == polid).FirstOrDefault();
                int prid = Convert.ToInt32(q.Product_ID.ToString());
                var q1 = db.Products.Where(op => op.Product_ID == prid).FirstOrDefault();

                newCRL = new Credit_Return_Line()
                {
                    Client_Purchase_Order_Line_ID = polid,
                    Quantity_Returned = Convert.ToInt32(textBox7.Text),
                    Reason_For_Return_ID = Convert.ToInt32(comboBox1.SelectedValue),
                    Credit_Return_ID = newCR.Credit_Return_Id,
                    Credit_Return_Amount = Convert.ToDecimal(q1.Order_Price.ToString()) * Convert.ToInt32(textBox7.Text)
                };
                
                db.Credit_Return_Line.Add(newCRL);
                db.SaveChanges();
               dataGridView2.DataSource = db.Get_Credit_Return_Line(newCR.Credit_Return_Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
            polid = Convert.ToInt32(r.Cells[0].Value.ToString());
            
        }
        ReportDocument repdoc = new ReportDocument();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 1;
            dataGridView3.DataSource = db.Load_Credit_Return().ToList();
            
            //try
            //{
            //    repdoc.Load("D:\\DesktopApp_2\\Credit Note.rpt");
            //    repdoc.SetParameterValue("@crnum", newCR.Credit_Return_Id);
            //    crystalReportViewer1.ReportSource = repdoc;
            //}
            //catch (Exception)
            //{

                
            //}
            
            
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            try
            {
                DataGridViewRow r = this.dataGridView3.Rows[e.RowIndex];
                string crnum = r.Cells[0].Value.ToString();
                var q = db.Credit_Return.Where(c => c.CR_Number == crnum).FirstOrDefault();
                crid = Convert.ToInt32(q.Credit_Return_Id.ToString());

                dataGridView4.DataSource = db.Get_Credit_Return_Line(crid);
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong!,Please try again");
            }
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                newCR = new Credit_Return()
                {
                    Credit_Return_Date = DateTime.Today,
                    Received_By = textBox3.Text,
                    Returned_By = textBox2.Text
                };
                db.Credit_Return.Add(newCR);
                var q = db.Client_Purchase_Order.Where(po => po.PO_Number == PO).FirstOrDefault();
                poid = Convert.ToInt32(q.Client_Purchase_Id);
                dataGridView1.DataSource = db.GetPOL(poid).ToList();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
