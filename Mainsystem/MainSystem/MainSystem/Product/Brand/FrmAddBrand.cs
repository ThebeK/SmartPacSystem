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
    public partial class FrmAddBrand : Form
    {
        string option;
        public FrmAddBrand(string x)
        {
            option = x;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        bool correct = false;

        public bool ValidateIfBrandExists(string brandNAME)
        {
            bool Check = false;
            foreach (var item in db.Product_Brand)
            {
                if (item.Product_Brand_Name == brandNAME)
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                correct = true;
                Product_Brand prodB = new Product_Brand();
                if (ValidateIfBrandExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Product Brand exists");
                }
                if (rtxtDescription.Text == "")
                {
                    lblBrandDes.Visible = true;
                    //essageBox.Show("Please Enter brand details");
                    correct = false;
                }

                if (correct == true)
                {
                    prodB.Product_Brand_Name = rtxtDescription.Text;
                    MessageBox.Show("Product Successfully Added");
                    db.Product_Brand.Add(prodB);

                    db.SaveChanges();

                    int Product_Type_ID = prodB.Product_Brand_ID;
                    string ProdT_value = Convert.ToString(prodB);
                    //MessageBox.Show("Product Successfully Added");
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Please enter valid details");
                }



            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Product Type Not Added");
            }
        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
