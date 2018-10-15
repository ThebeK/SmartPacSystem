using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainSystem;

namespace MainSystem
{
    public partial class frmView : Form
    {
        SPEntities db = new SPEntities();
        public frmView()
        {
            InitializeComponent();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            dgvPO.DataSource = db.Load_Purchase_Order().ToList();
            //clientBindingSource.DataSource = db.Clients.ToList();
            productBindingSource.DataSource = db.Products.ToList();
            dataGridView1.DataSource = db.Load_Supplier_Order().ToList();
            dataGridView4.DataSource = db.Credit_Return.ToList();
            //cbxClientName.SelectedIndex = -1;
            //gbxClientInformation.Enabled = false;

            //btnPOLRemove.Enabled = false;
            //btnPOCancel.Enabled = false;
            //btnPODelete.Enabled = false;
            //btnPOUpdate.Enabled = false;
            //btnPOLAdd.Enabled = false;
            dgvPOL.Enabled = false;



        }
        private void Form1_Load(object sender, EventArgs e)
        {




        }
        private void CalculateSubtotal()
        {

            foreach (DataGridViewRow r in dgvPOL.Rows)
            {
                r.Cells[dgvPOL.Columns["subtotal"].Index].Value = Convert.ToInt32(r.Cells[dgvPOL.Columns["quantity"].Index].Value) *
                    Convert.ToDouble(r.Cells[dgvPOL.Columns["order_price"].Index].Value);

            }

        }
        DataGridViewRow r = new DataGridViewRow();
        //private decimal CalculateGrossAmount()
        //{
        //    decimal grossAmount = 0;

        //    //foreach (DataGridViewRow r in dgvPOL.Rows)
        //    //{
        //    //    if (r.IsNewRow == false)
        //    //    {
        //    //        int prid = Convert.ToInt32(r.Cells[2].Value);
        //    //        var q = db.Order_Unit_Price.Where(op => op.Product_ID == prid).FirstOrDefault();
        //    //        Decimal price = Convert.ToDecimal(q.Order_Price);
        //    //        grossAmount += Convert.ToInt32(r.Cells[dgvPOL.Columns["quantity"].Index].Value) * price;

        //    //    }


        //    //}
            
            
            
        //    return grossAmount;
        //}

        private void btnPOAdd_Click(object sender, EventArgs e)
        {




        }
        int i;
        Client_Purchase_Order newPO;
        Client_Purchase_Order xPO;
        Client_Purchase_Order_Line newPOL;
        Client_Purchase_Order_Line xPOL;

        //private void cbxClientName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgvPOL.Enabled = true;

        //    if (cbxClientName.SelectedItem != null)
        //    {
        //        string cName = cbxClientName.Text;
        //        var q = db.Clients.Where(c => c.Client_Name == cName).FirstOrDefault();
        //        txtAccNum.Text = q.CL_Number.ToString();
        //        var r = db.Clients.
        //            Join(db.Credit_Approval, c => c.Credit_Approval_ID, ca => ca.Credit_Approval_ID,
        //            (c, ca) => new { Client = c, Credit_Approval = ca }).FirstOrDefault();
        //        txtCreditApprovalAmount.Text = r.Credit_Approval.Credit_Approval_Amount.ToString();


        //        newPO=new Client_Purchase_Order()
        //        {
        //            Order_Date = DateTime.Today,
        //            Payment_Terms_ID = 1,
        //            Client_ID = Convert.ToInt32(cbxClientName.SelectedValue),

        //        };
        //        db.Client_Purchase_Order.Add(newPO);
        //        //db.SaveChanges();
        //        dgvPOL.Focus();

        //        i = 0;
        //        DataGridViewRow v = this.dgvPOL.Rows[i];
        //        while (v.Cells[2].Value != null && v.Cells[3].Value != null)
        //        {
        //            btnPOLAdd.Enabled = true;
        //        }
        //        loadPurchaseOrderResultBindingSource.DataSource=db.Load_Purchase_Order().ToList();
        //        loadPurcaseOrderLineResultBindingSource.DataSource=db.Load_Purcase_Order_Line().ToList();

        //    }


        int polid;
        int poid;
        private void btnPOLRemove_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to remove this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    db.Client_Purchase_Order_Line.
                    Remove(db.Client_Purchase_Order_Line.Where(pol => pol.Client_Purchase_Order_Line_ID == polid).
                    FirstOrDefault() as Client_Purchase_Order_Line);

                    db.SaveChanges();
                    loadPurcaseOrderLineResultBindingSource.DataSource = db.GetPOL(poid).ToList();
                    CalculateSubtotal();
                    //decimal sum = 0;
                    //xPO = db.Client_Purchase_Order.Single(p => p.Client_Purchase_Id == poid);
                    //foreach (DataGridViewRow ar in dgvPOL.Rows)
                    //{
                    //    sum += (Convert.ToInt32(ar.Cells[dgvPOL.Columns["quantity"].Index].Value) *
                    //Convert.ToDecimal(ar.Cells[dgvPOL.Columns["order_price"].Index].Value));
                    //}
                    //xPO.Gross_Amount = sum;
                    if (r.IsNewRow == false)
                    {
                        decimal grossAmount = Convert.ToDecimal(db.GetPOL(newPO.Client_Purchase_Id).Sum(pol => pol.Subtotal));
                    }
                    //db.Client_Purchase_Order.a(xpo);
                    db.SaveChanges();
                    dgvPO.DataSource = db.Load_Purchase_Order().ToList();
                    //dgvPO.Refresh(); 
                    // btnPOLRemove.Enabled = false;



                }
                catch (Exception)
                {

                    MessageBox.Show("Table is empty. There are no records to be removed.");
                }


            }



        }

        private void dgvPOL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dgvPOL_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow r = this.dgvPOL.Rows[e.RowIndex];
            polid = Convert.ToInt32(r.Cells[0].Value.ToString());
            //btnPOLRemove.Enabled = true;


        }
        private void dgvPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = this.dgvPO.Rows[e.RowIndex];
                string ponum = r.Cells[0].Value.ToString();
                var q = db.Client_Purchase_Order.Where(c => c.PO_Number == ponum).FirstOrDefault();
                poid = Convert.ToInt32(q.Client_Purchase_Id.ToString());
                dgvPOL.Refresh();
                loadPurcaseOrderLineResultBindingSource.DataSource = db.GetPOL(poid);

                CalculateSubtotal();
                //btnPOCancel.Enabled = true;
                //btnPODelete.Enabled = true;
                //btnPOUpdate.Enabled = true;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
            }



        }

        private void btnPODelete_Click(object sender, EventArgs e)
        {

        }
        bool add = false;
        bool update = false;
        private void btnPOLAdd_Click(object sender, EventArgs e)
        {

            if (newPO != null)
            {
                DataGridViewRow r = dgvPOL.Rows[i];

                int prid = Convert.ToInt32(r.Cells[2].Value);
                


                newPOL = new Client_Purchase_Order_Line()
                {
                    Client_Purchase_Id = newPO.Client_Purchase_Id,
                    Product_ID = Convert.ToInt32(r.Cells[2].Value),
                    Quantity = Convert.ToInt32(r.Cells[3].Value),
                    
                };
                db.Client_Purchase_Order_Line.Add(newPOL);
                //loadPurcaseOrderLineResultBindingSource.DataSource = db.Client_Purchase_Order_Line;
                CalculateSubtotal();
                //int poid = Convert.ToInt32(pol.Client_Purchase_Id);
                ++i;
                //btnPOLAdd.Enabled = false;
                dgvPOL.Enabled = true;
                add = true;
            }
            else if (xPO != null)
            {
                DataGridViewRow r = dgvPOL.Rows[i];

                int prid = Convert.ToInt32(r.Cells[2].Value);
                


                newPOL = new Client_Purchase_Order_Line()
                {
                    Client_Purchase_Id = xPO.Client_Purchase_Id,
                    Product_ID = Convert.ToInt32(r.Cells[2].Value),
                    Quantity = Convert.ToInt32(r.Cells[3].Value),
                    
                };
                db.Client_Purchase_Order_Line.Add(newPOL);
                //loadPurcaseOrderLineResultBindingSource.DataSource = db.Client_Purchase_Order_Line;
                CalculateSubtotal();
                //int poid = Convert.ToInt32(pol.Client_Purchase_Id);
                ++i;
                // btnPOLAdd.Enabled = false;
                dgvPOL.Enabled = true;
                update = true;
            }


        }

        private void btnPOLSave_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                newPO.Gross_Amount = Convert.ToDecimal(db.GetPOL(newPO.Client_Purchase_Id).Sum(pol => pol.Subtotal)); ;
                newPO.Purchase_Order_Status_ID = 1;
                if (MessageBox.Show("Would you like to have your order delivered", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    newPO.Dispatch_Type_Id = 1;
                }
                else
                {
                    newPO.Dispatch_Type_Id = 2;
                }
                db.Client_Purchase_Order.Add(newPO);
                newPO = null;
            }
            else if (update == true)
            {
                xPO.Gross_Amount = Convert.ToDecimal(db.GetPOL(newPO.Client_Purchase_Id).Sum(pol => pol.Subtotal)); ;


                //db.Client_Purchase_Order.Add(newPO);
                xPO = null;
            }


            db.SaveChanges();
            dgvPOL.Refresh();
            dgvPO.Refresh();

            //dgvPOL.DataSource = db.GetPOL(pol.Client_Purchase_Id).ToList();
            CalculateSubtotal();
            //CalculateGrossAmount();

        }

        private void dgvPOL_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void dgvPOL_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (newPO != null || xPO != null)
            {
                DataGridViewRow r = this.dgvPOL.Rows[e.RowIndex];
                if (r.Cells[2].Value != null && r.Cells[3].Value != null && r.IsNewRow == false)
                {
                    //btnPOLAdd.Enabled = true;
                    dgvPOL.Enabled = false;
                }
            }
        }

        private void btnPOUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnPOLUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnPODelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this item?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    db.Client_Purchase_Order.
                    Remove(db.Client_Purchase_Order.Where(po => po.Client_Purchase_Id == poid).
                    FirstOrDefault() as Client_Purchase_Order);
                    db.SaveChanges();
                    dgvPO.DataSource = db.Load_Purchase_Order().ToList();
                    CalculateSubtotal();
                    //btnPOLRemove.Enabled = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Table is empty. There are no records to be removed." + ex);
                }


            }
        }

        private void btnPOAdd_Click_1(object sender, EventArgs e)
        {
            //btnPOAdd.Enabled = false;
            //btnPOCancel.Enabled = false;
            //btnPODelete.Enabled = false;
            //btnPOUpdate.Enabled = false;
            //gbxClientInformation.Enabled = true;
            //cbxClientName.Focus();
            loadPurcaseOrderLineResultBindingSource.DataSource = db.Load_Purcase_Order_Line().ToList();
        }

        private void btnPOUpdate_Click_1(object sender, EventArgs e)
        {
            dgvPOL.Enabled = true;
            loadPurcaseOrderLineResultBindingSource.DataSource = db.GetPOL(poid).ToList();
            xPO = db.Client_Purchase_Order.Single(po => po.Client_Purchase_Id == poid);
            if (dgvPOL != null)
            {
                i = dgvPOL.RowCount - 1;
            }
            else
            {
                i = 0;
            }
        }

        private void txtAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPO.DataSource = db.Load_Purchase_Order().Where(o => o.PO_Number.Contains(txtSearch.Text.ToUpper())).ToList();
            if (dgvPO.RowCount==0)
            {
                MessageBox.Show("No results found");
                txtSearch.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
            string sonum = r.Cells[0].Value.ToString();
            var q = db.Supplier_Order.Where(c => c.SO_Number == sonum).FirstOrDefault();
            int soid = Convert.ToInt32(q.Supplier_Order_Id.ToString());
            getSOLResultBindingSource.DataSource = db.GetSOL(soid);
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = this.dataGridView4.Rows[e.RowIndex];
            string crnum = r.Cells[0].Value.ToString();
            try
            {
                var q = db.Credit_Return.Where(c => c.CR_Number == crnum).FirstOrDefault();
                int crid = Convert.ToInt32(q.Credit_Return_Id.ToString());

                dataGridView3.DataSource = db.Get_Credit_Return_Line(crid);
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong!,Please try again");
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Load_Supplier_Order().Where(o => o.SO_Number.Contains(textBox1.Text.ToUpper())).ToList();
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No results found");
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView4.DataSource = db.Credit_Return.Where(o => o.CR_Number.Contains(textBox2.Text.ToUpper())).ToList();
            if (dataGridView4.RowCount == 0)
            {
                MessageBox.Show("No results found");
                textBox2.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}