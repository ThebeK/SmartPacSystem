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
    public partial class frmSearchPO : Form
    {
        SPEntities db = new SPEntities();
        public frmSearchPO()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Load_Purchase_Order_1().ToList();
        }
        string ponum;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCreditReturn f = new frmCreditReturn(ponum);
            f.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            ponum = r.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.DataSource = db.Load_Purchase_Order().
                    Where(o => o.PO_Number.Contains(textBox1.Text.ToUpper())).ToList();

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("No results found");
                    textBox1.Clear();
                    dataGridView1.DataSource = db.Load_Purchase_Order_1().ToList();
                }
            }
            dataGridView1.DataSource = db.Load_Purchase_Order_1().ToList();
        }
    }
}
