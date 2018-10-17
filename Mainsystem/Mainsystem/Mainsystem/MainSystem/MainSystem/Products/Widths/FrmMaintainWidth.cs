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
    public partial class FrmMaintainWidth : Form
    {
        int tempID;
        public FrmMaintainWidth(int x)
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

        private void FrmMaintainWidth_Load(object sender, EventArgs e)
        {
            var query = db.Widths.Where(co => co.Width_ID == tempID).FirstOrDefault();

            txtWidthDesc.Text = query.Width_Size.ToString();
            txtUnit.Text = query.Width_Measurement_Unit;
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtWidthDesc.Text == "")
                {
                    lblWidth.Visible = true;
                    correct = false;
                }
                if (txtUnit.Text == "")
                {
                    lblUnit.Visible = true;
                    correct = false;
                }
                if (txtWidthDesc.Text == "" && txtUnit.Text == "")
                {

                    MessageBox.Show("Please Enter a product width");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Widths.Where(co => co.Width_ID == tempID).FirstOrDefault();

                    query.Width_Size = Convert.ToInt32(txtWidthDesc.Text);
                    query.Width_Measurement_Unit = txtUnit.Text;

                    db.SaveChanges();
                    MessageBox.Show("Product Width Successfully Updated");
                    this.Close();
                }
            }
            catch
            {

            }
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product ?", "Delete Product ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Width Emt2 = new Width();
                    Emt2 = db.Widths.Find(tempID);

                    db.Widths.Remove(Emt2);
                    db.SaveChanges();

                    int length = Convert.ToInt32(Emt2.Width_ID);
                    string Length_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Product Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: product was not deleted,currently in use");

                }
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtWidthDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {

            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
