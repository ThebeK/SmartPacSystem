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

namespace MainSystem.Products.PackSize
{
    public partial class FrmAddPackSize : Form
    {
        string option;
        public FrmAddPackSize(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;

        public bool ValidateIfPackSizeExists(string PS)
        {
            bool Check = false;
            foreach (var item in db.Pack_Size)
            {
                if (item.Pack_Size_Description == PS)
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
                if (ValidateIfPackSizeExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Pack Size exists");
                    correct = false;
                }
                correct = true;
                Pack_Size packS = new Pack_Size();

                if (rtxtDescription.Text == "")
                {
                    lblPackSize.Visible = true;

                    //MessageBox.Show("Please Enter Product pack size details");
                    correct = false;
                }

                if (correct == true)
                {
                    packS.Pack_Size_Description = rtxtDescription.Text;
                    db.Pack_Size.Add(packS);

                    db.SaveChanges();

                    int Pack_Size_ID = packS.Pack_Size_ID;
                    string ProdT_value = Convert.ToString(packS);
                    MessageBox.Show("Product Pack Size Successfully Added");
                    this.Close();

                }



            }
            catch 
            {
               
            }

        }

        private void rtxtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
