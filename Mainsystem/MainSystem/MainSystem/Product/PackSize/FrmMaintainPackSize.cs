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
    public partial class FrmMaintainPackSize : Form
    {
        int tempID;
        public FrmMaintainPackSize(int x)
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

        private void btnUpdateSheet_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtProductSheetDesc.Text == "")
                {
                    lblPackSi.Visible = true;
                    //MessageBox.Show("Please Enter a product pack size");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Pack_Size.Where(co => co.Pack_Size_ID == tempID).FirstOrDefault();

                    query.Pack_Size_Description = txtProductSheetDesc.Text;

                    db.SaveChanges();
                    MessageBox.Show("Product Pack Size Successfully Updated");
                    this.Close();
                }
            }
            catch
            {
               
            }
        }

        private void FrmMaintainPackSize_Load(object sender, EventArgs e)
        {
            var query = db.Pack_Size.Where(co => co.Pack_Size_ID == tempID).FirstOrDefault();

            txtProductSheetDesc.Text = query.Pack_Size_Description;
        }

        private void btnDeleteSheet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product Pack Size?", "Delete Product Pack Size", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Pack_Size prodT2 = new Pack_Size();
                    prodT2 = db.Pack_Size.Find(tempID);

                    db.Pack_Size.Remove(prodT2);
                    db.SaveChanges();

                    int packSize = prodT2.Pack_Size_ID;
                    string Pack_Size_Value = Convert.ToString(prodT2);
                    MessageBox.Show("Pack Size Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Pack Size deleted, Pack size is in use");

                }
            }
        }

        private void txtProductSheetDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
