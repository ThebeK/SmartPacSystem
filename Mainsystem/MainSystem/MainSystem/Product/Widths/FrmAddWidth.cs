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

namespace MainSystem.Products.Widths
{
    public partial class FrmAddWidth : Form
    {
        string option;
        public FrmAddWidth(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;
        public bool ValidateIfWidthExists(string Wid)
        {
            bool Check = false;
            foreach (var item in db.Widths)
            {
                if (item.Width_Size == Convert.ToInt32(Wid))
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
                if (ValidateIfWidthExists(WidthDescription.Text) == true)
                {
                    MessageBox.Show("Widths already exists");
                    correct = false;
                }
                correct = true;
                Width PWidth = new Width();

                if (WidthDescription.Text == "")
                {
                    lblWidth.Visible = true;

                    //MessageBox.Show("Please Enter Product Widths");
                    correct = false;
                }
                if (txtMeasurement.Text == "")
                {
                    lblUnit.Visible = true;
                }


                if (correct == true)
                {
                    PWidth.Width_Size = Convert.ToInt32(WidthDescription.Text);
                    PWidth.Width_Measurement_Unit = txtMeasurement.Text;
                    db.Widths.Add(PWidth);

                    db.SaveChanges();

                    int Width_ID = PWidth.Width_ID;
                    string Width_value = Convert.ToString(PWidth);
                    MessageBox.Show("Product Widths Successfully Added");
                    this.Close();
                }

                


            }
            catch 
            {
                
            }
        }

        private void WidthDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtMeasurement_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
