using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Order
{
    public partial class frmSupplierOrder : Form
    {
        SPEntities db = new SPEntities();

        public static string sonum;
        
        public frmSupplierOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Load_Supplier_Order().Where(x => x.Supplier_Order_Status_Description == "Placed").ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Credit_Return.Where(o => o.CR_Number.Contains(textBox1.Text.ToUpper())).ToList();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
            
            sonum = r.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
