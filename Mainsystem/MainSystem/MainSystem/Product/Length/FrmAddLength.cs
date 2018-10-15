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

namespace MainSystem.Products.Length
{
    public partial class FrmAddLength : Form
    {
        string option;
        public FrmAddLength(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;
        public bool ValidateIfLengthExists(string Lengthh)
        {
            bool Check = false;
            foreach (var item in db.pLengths)
            {
                if (item.Length_Size == Convert.ToInt32(Lengthh))
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
                if (ValidateIfLengthExists(txtLengthDescription.Text) == true)
                {
                    MessageBox.Show("Product Length exists");
                    correct = false;
                }


                correct = true;
                pLength PL = new pLength();

                if (txtLengthDescription.Text == "")
                {
                    lblLength.Visible = true;
                    //MessageBox.Show("Please Enter Product Widths");
                    correct = false;
                }

                if (txtMeasurement.Text == "")
                {
                    lblUnit.Visible = true;
                    correct = false;
                }

                if (correct == true)
                {
                    PL.Length_Size = Convert.ToInt32(txtLengthDescription.Text);
                    PL.Length_Measurement_Unit = txtMeasurement.Text;
                    db.pLengths.Add(PL);

                    db.SaveChanges();

                    int Length_ID = PL.Length_ID;
                    string Length_value = Convert.ToString(PL);
                    MessageBox.Show("Product Length Successfully Added");
                    this.Close();
                }




            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product Length Added");
            }
        }

        private void txtLengthDescription_KeyPress(object sender, KeyPressEventArgs Event)
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
