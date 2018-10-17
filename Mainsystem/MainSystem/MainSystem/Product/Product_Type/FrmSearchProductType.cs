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

namespace MainSystem.Products
{
    public partial class FrmSearchProductType : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchProductType(string x)
        {
            InitializeComponent();
            option = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchProductType_Leave(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Product_Brand on a.Product_Brand_ID equals a1.Product_Brand_ID
                           join a2 in db.Product_Type on a.Product_Type_ID equals a2.Product_Type_ID
                           join a3 in db.Plies on a.Ply_ID equals a3.Ply_ID
                           select new
                           {
                               a.Product_ID,
                               a1.Product_Brand_Name

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Product_ID == Convert.ToInt32(txtSearchSale.Text))
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchSale.Text == "")
            {
                label3.Visible = true;
                //MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchSale.Text != "")
            {

                List<Product_Type> Ptype = db.Product_Type.Where(o => o.Product_Type_Name.Contains(txtSearchSale.Text)).ToList();


                if (Ptype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Product type found");

                }

                else
                {
                    foreach (var a in Ptype)
                    {
                        dgvClientSearch.DataSource = Ptype.Select(col => new { col.Product_Type_ID, col.Product_Type_Name }).ToList();

                        dgvClientSearch.Columns[0].HeaderText = "Product_Type_ID";
                        dgvClientSearch.Columns[1].HeaderText = "Product_Type_Description";


                        //groupBox1.Visible = true;

                    }
                }
            }
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvClientSearch.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product T")
                {
                    FrmMaintainProductType form1 = new FrmMaintainProductType(val);
                    form1.ShowDialog();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Please specify your product type search details first");
            }
        }

        private void FrmSearchProductType_Load(object sender, EventArgs e)
        {
            dgvClientSearch.DataSource = db.Product_Type.ToList();
            dgvClientSearch.Columns[2].Visible = false;
            dgvClientSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClientSearch.Columns[1].HeaderText = "Product Type Name";
        }

        private void txtSearchSale_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
