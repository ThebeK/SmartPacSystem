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
    public partial class frmReceiveSO : Form
    {
        
        
        public frmReceiveSO()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReceiveSO_Load(object sender, EventArgs e)
        {
            
            
            
            
        }
        SPEntities db = new SPEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = false;
                frmScanQR scanQR = new frmScanQR();
                scanQR.Dock = DockStyle.Fill;
                scanQR.BringToFront();
                scanQR.ShowDialog();
                textBox1.Text = scanQR.DecodeID;
                var q = db.Supplier_Order.Where(so => so.SO_Number == textBox1.Text).FirstOrDefault();
                dataGridView1.DataSource = db.GetSOL(q.Supplier_Order_Id).ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        Supplier_Backorder newBO = new Supplier_Backorder();
        
        Backorder_Line newBOL; 
        private void button5_Click(object sender, EventArgs e)
        {


            //newBOL = new Backorder_Line()
            //{
            //    Quantity_Received = Convert.ToInt32(textBox3.Text),
            //    Supplier_Order_Line_ID = Convert.ToInt32(textBox2.Text),
            //    Supplier_Backorder_ID = newBO.Supplier_Backorder_Id
            //};
            //db.Backorder_Line.Add(newBOL);
            //db.SaveChanges();
            //dataGridView2.DataSource = db.GetBOL(newBO.Supplier_Backorder_Id).ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchSO f = new frmSearchSO();
            f.ShowDialog();
            textBox1.Text = frmSearchSO.sonum;
            f.Close();
            var q = db.Supplier_Order.Where(so => so.SO_Number == textBox1.Text).FirstOrDefault();
            dataGridView1.DataSource = db.GetSOL(q.Supplier_Order_Id).ToList();

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow r = this.dataGridView2.Rows[e.RowIndex];

            //textBox2.Text = r.Cells[0].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

                




            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 1;
            List<SOSummary> mylist = new List<SOSummary>();
            DataGridViewRow row = new DataGridViewRow();
            dataGridView3.Rows.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                if (Convert.ToInt32(dataGridView1.Rows[i].Cells["received"].Value) == 1)
                {
                    row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }

                    dataGridView2.Rows.Add(row);
                    dataGridView2.AllowUserToAddRows = false;
                    dataGridView2.Refresh();



                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells["received"].Value) == 0)
                {
                    row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }

                    dataGridView3.Rows.Add(row);

                    dataGridView3.AllowUserToAddRows = false;
                    dataGridView3.Refresh();
                    
                }




            }
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                string product = r.Cells[1].Value.ToString();
                var q = db.Getpoduct().Where(x => x.Product_Description == product).First();
                //int w = Convert.ToInt32(q.Available_Quantity);

                q.Available_Quantity += Convert.ToInt32(r.Cells[2].Value);
                db.Products.Where(x => x.Product_ID == q.Product_ID).First().Available_Quantity += q.Available_Quantity;
                db.SaveChanges();


            }
            if (dataGridView2.RowCount==dataGridView1.RowCount)
            {
                var q1 = db.Supplier_Order.Where(x => x.SO_Number == textBox1.Text).First();
                q1.Supplier_Order_Status_ID = 2;
                db.SaveChanges();
            }
            

        }
    }
}
