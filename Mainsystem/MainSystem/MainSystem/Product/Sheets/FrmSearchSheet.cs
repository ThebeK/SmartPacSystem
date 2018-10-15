using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Products.Sheets
{
    public partial class FrmSearchSheet : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchSheet(string x)
        {
            InitializeComponent();
            option = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            
            try
            {

                int val = Convert.ToInt32(dgvProductSheet.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Sheet Number")
                {
                    FrmMaintainSheet qw = new FrmMaintainSheet(val);
                    qw.ShowDialog();
                    this.Activate();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Please specify your product sheet number search details first");
            }
            // this.Show();
           
        }

        private void FrmSearchSheet_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void FrmSearchSheet_Load(object sender, EventArgs e)
        {
            dgvProductSheet.DataSource = db.Sheets.ToList();
            dgvProductSheet.Columns[2].Visible = false;
            dgvProductSheet.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductSheet.Columns[1].HeaderText = "Sheet_No";
        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Sheets on a.Sheet_ID equals a1.Sheet_ID

                           select new
                           {
                               a.Sheet_ID,
                               a1.Number_Of_Sheet

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Number_Of_Sheet == Convert.ToInt32(txtSearchSheet.Text))
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchSheet.Text == "")
            {
                label2.Visible = true;
                //MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchSheet.Text != "")
            {

                List<Sheet> PStype = db.Sheets.Where(o => o.Number_Of_Sheet.ToString().Contains(txtSearchSheet.Text)).ToList();


                if (PStype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Product Pack Size found");

                }

                else
                {
                    foreach (var a in PStype)
                    {
                        dgvProductSheet.DataSource = PStype.Select(col => new { col.Sheet_ID, col.Number_Of_Sheet }).ToList();

                        dgvProductSheet.Columns[0].HeaderText = "Sheet_ID";
                        dgvProductSheet.Columns[1].HeaderText = "Number_Of_Sheet";


                        //groupBox1.Visible = true;

                    }
                }
            }
        }

        private void txtSearchSheet_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
