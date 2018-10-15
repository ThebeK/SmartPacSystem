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
    public partial class FrmAddProductType : Form
    {
        string option;
        public FrmAddProductType(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;
        public bool ValidateIfProductTypeExists(string proddT)
        {
            bool Check = false;
            foreach (var item in db.Product_Type)
            {
                if (item.Product_Type_Name == proddT)
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
            Process.Start(@".\" + "AddProductType.pdf");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                correct = true;
                Product_Type prodT = new Product_Type();
                frmAddProduct frm = new frmAddProduct();

                if (ValidateIfProductTypeExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Product Type exists");
                    correct = false;
                }
                if (rtxtDescription.Text == "")
                {
                    lblProdDesc.Visible = true;

                    //MessageBox.Show("Please Enter Product type details");
                    correct = false;
                }

                if (correct == true)
                {
                    prodT.Product_Type_Name = rtxtDescription.Text;
               

                db.Product_Type.Add(prodT);

                db.SaveChanges();

                int Product_Type_ID = prodT.Product_Type_ID;
                string ProdT_value = Convert.ToString(prodT);
                MessageBox.Show("Product Successfully Added");
                this.Close();
 }

            }
            catch 
            {
               
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
