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
    public partial class FrmMaintainBrand : Form
    {
        int tempID;
        public FrmMaintainBrand(int x)
        {
            InitializeComponent();
            tempID = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;
        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void FrmMaintainBrand_Load(object sender, EventArgs e)
        {
            var query = db.Product_Brand.Where(co => co.Product_Brand_ID == tempID).First();

            txtBrandDesc.Text = query.Product_Brand_Name; 
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {


            correct = true;
            try
            {
                if (txtBrandDesc.Text == "")
                {
                    lblBrand.Visible = true;

                    //MessageBox.Show("Please Enter a brand Description");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Product_Brand.Where(co => co.Product_Brand_ID == tempID).FirstOrDefault();

                    query.Product_Brand_Name = txtBrandDesc.Text;

                    db.SaveChanges();
                    MessageBox.Show("Product Type Successfully Updated");
                    this.Close();
                }
            }
            catch
            {
                //MessageBox.Show("Product type not updated");
            }
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product brand?", "Delete Product Brand", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Product_Brand Brandtype = new Product_Brand();
                    Brandtype = db.Product_Brand.Find(tempID);

                    db.Product_Brand.Remove(Brandtype);
                    db.SaveChanges();

                    int BType = Convert.ToInt32(Brandtype.Product_Brand_ID);
                    string prodType_Value = Convert.ToString(Brandtype);
                    MessageBox.Show("Product brand Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Product Brand was not deleted, currently in use");

                }
            }
        }
    }
}
