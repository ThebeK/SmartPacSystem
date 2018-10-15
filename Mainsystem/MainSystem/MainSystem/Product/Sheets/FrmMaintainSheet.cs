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

namespace MainSystem.Products.Sheets
{
    public partial class FrmMaintainSheet : Form
    {
        int tempID;
        public FrmMaintainSheet(int x)
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

        private void FrmMaintainSheet_Load(object sender, EventArgs e)
        {
            var query = db.Sheets.Where(co => co.Sheet_ID == tempID).FirstOrDefault();

            txtProductTypeDesc.Text = query.Number_Of_Sheet.ToString();

        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            correct = true;
            try
            {
                if (txtProductTypeDesc.Text == "")
                {
                    lblSheet.Visible = true;
                    //MessageBox.Show("Please Enter a product sheet number");
                    correct = false;
                }


                if (correct == true)
                {

                    var query = db.Sheets.Where(co => co.Sheet_ID == tempID).FirstOrDefault();

                    query.Number_Of_Sheet = Convert.ToInt32(txtProductTypeDesc.Text);

                    db.SaveChanges();
                    MessageBox.Show("Product Sheet Number Successfully Updated");
                    this.Close();
                }
            }
            catch 
            {
                //MessageBox.Show("Sheet Number not updated, c");
            }
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Sheet Number?", "Delete Product Sheet Number", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Sheet prodT2 = new Sheet();
                    prodT2 = db.Sheets.Find(tempID);

                    db.Sheets.Remove(prodT2);
                    db.SaveChanges();

                    int Sheets = prodT2.Sheet_ID;
                    string sheet_Value = Convert.ToString(prodT2);
                    MessageBox.Show("Product Sheet Successfully Deleted");
                    this.Close();

                }
                catch 
                {
                    MessageBox.Show("Error: Sheet was not deleted, currently in use");

                }
            }
        }

        private void txtProductTypeDesc_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
