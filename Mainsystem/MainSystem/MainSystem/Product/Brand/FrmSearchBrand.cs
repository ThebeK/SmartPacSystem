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

namespace MainSystem.Products.Brand
{
    public partial class FrmSearchBrand : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchBrand(string x)
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

                int val = Convert.ToInt32(dgvBrand.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Brand")
                {
                    FrmMaintainBrand ff = new FrmMaintainBrand(val);
                    ff.ShowDialog();

                    this.Activate();
                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                // MessageBox.Show("Please specify your product brand search details first");
            }
            

        }

        private void FrmSearchBrand_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Product_Brand on a.Product_Brand_ID equals a1.Product_Brand_ID

                           select new
                           {
                               a1.Product_Brand_ID,
                               a1.Product_Brand_Name

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Product_Brand_Name == txtSearchBrand.Text)
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchBrand.Text == "")
                {
                    lblSearchBrand.Visible = true;
                    //ssageBox.Show("Error: No search details entered");

                }
                else if (txtSearchBrand.Text != "")
                {

                    List<Product_Brand> Brandtype = db.Product_Brand.Where(o => o.Product_Brand_Name.Contains(txtSearchBrand.Text)).ToList();


                    if (Brandtype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Brand found");

                    }

                    else
                    {
                        foreach (var a in Brandtype)
                        {
                            dgvBrand.DataSource = Brandtype.Select(col => new { col.Product_Brand_ID, col.Product_Brand_Name }).ToList();

                            dgvBrand.Columns[0].HeaderText = "Product_Brand_ID";
                            dgvBrand.Columns[1].HeaderText = "Product_Brand_Name";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }

            catch
            {
            }
        }

        private void FrmSearchBrand_Load(object sender, EventArgs e)
        {
            dgvBrand.DataSource = db.Product_Brand.ToList();
            dgvBrand.Columns[2].Visible = false;
            dgvBrand.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBrand.Columns[1].HeaderText = "Brand Name";
        }

        private void txtSearchBrand_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
