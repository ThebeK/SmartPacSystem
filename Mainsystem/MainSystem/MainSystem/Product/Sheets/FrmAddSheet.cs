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
    
    public partial class FrmAddSheet : Form
    {
        string option;
        public FrmAddSheet(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        bool correct = false;

        public bool ValidateIfSheetExists(string SH)
        {
            bool Check = false;
            foreach (var item in db.Sheets)
            {
                if (item.Number_Of_Sheet == Convert.ToInt32(SH))
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
                Sheet Sheet = new Sheet();

                if (rtxtDescription.Text == "")
                {
                    lblSheet.Visible = true;
                    // MessageBox.Show("Please Enter Product sheet number details");
                    correct = false;
                }
                if (ValidateIfSheetExists(rtxtDescription.Text) == true)
                {
                    MessageBox.Show("Number of Sheets already exists");
                    correct = false;
                }
                if (correct == true)
                {
                    Sheet.Number_Of_Sheet = Convert.ToInt32(rtxtDescription.Text);
                }

                db.Sheets.Add(Sheet);

                db.SaveChanges();

                int Sheet_ID = Sheet.Sheet_ID;
                string ProdT_value = Convert.ToString(Sheet);
                MessageBox.Show("Product Sheets Number Successfully Added");
                this.Close();


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
