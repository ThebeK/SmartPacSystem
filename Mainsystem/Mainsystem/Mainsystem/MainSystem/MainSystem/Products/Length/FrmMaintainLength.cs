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
    public partial class FrmMaintainLength : Form
    {
        int tempID;
        public FrmMaintainLength(int x)
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

        private void FrmMaintainLength_Load(object sender, EventArgs e)
        {
            var query = db.pLengths.Where(co => co.Length_ID == tempID).FirstOrDefault();

            txtWidthDesc.Text = query.Length_Size.ToString();
            txtUnit.Text = query.Length_Measurement_Unit;
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtWidthDesc.Text == "")
                {
                    lblLength.Visible = true;
                    correct = false;
                }
                if (txtUnit.Text == "")
                {
                    lblUnit.Visible = true;
                    correct = false;

                }

                if (txtWidthDesc.Text == "" || txtUnit.Text == "")
                {
                    lblLength.Visible = true;
                    lblUnit.Visible = true;

                    //MessageBox.Show("Please Enter a product length");
                    correct = false;
                }



                if (txtWidthDesc.Text != "" && txtUnit.Text != "")
                {

                    var query = db.pLengths.Where(co => co.Length_ID == tempID).FirstOrDefault();

                    query.Length_Size = Convert.ToInt32(txtWidthDesc.Text);
                    query.Length_Measurement_Unit = txtUnit.Text;

                    db.SaveChanges();
                    MessageBox.Show("Product Length Successfully Updated");
                    this.Close();
                }
            }
            catch
            {
                
            }
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product Length?", "Delete Product Length", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    pLength Emt2 = new pLength();
                    Emt2 = db.pLengths.Find(tempID);

                    db.pLengths.Remove(Emt2);
                    db.SaveChanges();

                    int length = Convert.ToInt32(Emt2.Length_ID);
                    string Length_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Length Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Length was not deleted, Currently in use");

                }
            }
        }

        private void txtWidthDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
