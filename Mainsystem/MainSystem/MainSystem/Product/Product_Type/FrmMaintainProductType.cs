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
    public partial class FrmMaintainProductType : Form
    {
        SPEntities db = new SPEntities();
        int tempID;
        public FrmMaintainProductType(int x)
        {
            InitializeComponent();
            tempID = x;
        }
        bool correct = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainProductType.pdf");
        }

        private void txtProductTypeDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void FrmMaintainProductType_Load(object sender, EventArgs e)
        {
            var query = db.Product_Type.Where(co => co.Product_Type_ID == tempID).FirstOrDefault();

            txtProductTypeDesc.Text = query.Product_Type_Name;
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {

            correct = true;
            try
            {
                if (txtProductTypeDesc.Text == "")
                {
                    lblProdType.Visible = false;
                    //MessageBox.Show("Please Enter a product type Description");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Product_Type.Where(co => co.Product_Type_ID == tempID).FirstOrDefault();

                    query.Product_Type_Name = txtProductTypeDesc.Text;

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

            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product Type?", "Delete Product Type", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Product_Type prodT2 = new Product_Type();
                    prodT2 = db.Product_Type.Find(tempID);

                    db.Product_Type.Remove(prodT2);
                    db.SaveChanges();

                    int prodType = prodT2.Product_Type_ID;
                    string prodType_Value = Convert.ToString(prodT2);
                    MessageBox.Show("Product Type Successfully Deleted");
                    this.Close();

                }
                catch 
                {
                    MessageBox.Show("Error: Product Type was not deleted, currently in use");

                }
            }
        }
    }
}
