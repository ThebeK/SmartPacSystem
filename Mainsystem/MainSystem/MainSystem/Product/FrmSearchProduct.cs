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
    public partial class FrmSearchProduct : Form
    {
        string option;
        public FrmSearchProduct(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities db = new SPEntities();
        public List<object> Get1()
        {
            var details = (from a in db.Products
                           join a1 in db.Product_Brand on a.Product_Brand_ID equals a1.Product_Brand_ID
                           join a2 in db.Product_Type on a.Product_Type_ID equals a2.Product_Type_ID
                           join a3 in db.Plies on a.Ply_ID equals a3.Ply_ID
                           join a4 in db.Sheets on a.Sheet_ID equals a4.Sheet_ID
                           join a5 in db.Pack_Size on a.Pack_Size_ID equals a5.Pack_Size_ID
                           join a6 in db.pLengths on a.Length_ID equals a6.Length_ID
                           join a7 in db.pLengths on a.Length_ID equals a7.Length_ID
                           join a8 in db.Widths on a.Width_ID equals a8.Width_ID
                           join a9 in db.Widths on a.Width_ID equals a9.Width_ID
                           // join a10 in db.Sales_Unit_Price on a.Product_ID equals a10.Product_ID

                          // where a.Product_Description.ToUpper().Contains(desc)
                           select new
                           {
                               a.Product_ID,
                               a.Product_Description,
                               a1.Product_Brand_Name,
                               a2.Product_Type_Name,
                               a3.Number_Of_Ply,
                               a4.Number_Of_Sheet,
                               a5.Pack_Size_Description,
                               a6.Length_Size,
                               a7.Length_Measurement_Unit,
                               a8.Width_Size,
                               a9.Width_Measurement_Unit,
                               a.Sales_Price,
                               a.Image


                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }
        public List<object> Get(string desc)
        {
            var details = (from a in db.Products
                           join a1 in db.Product_Brand on a.Product_Brand_ID equals a1.Product_Brand_ID
                           join a2 in db.Product_Type on a.Product_Type_ID equals a2.Product_Type_ID
                           join a3 in db.Plies on a.Ply_ID equals a3.Ply_ID
                           join a4 in db.Sheets on a.Sheet_ID equals a4.Sheet_ID
                           join a5 in db.Pack_Size on a.Pack_Size_ID equals a5.Pack_Size_ID
                           join a6 in db.pLengths on a.Length_ID equals a6.Length_ID
                           join a7 in db.pLengths on a.Length_ID equals a7.Length_ID
                           join a8 in db.Widths on a.Width_ID equals a8.Width_ID
                           join a9 in db.Widths on a.Width_ID equals a9.Width_ID
                          // join a10 in db.Sales_Unit_Price on a.Product_ID equals a10.Product_ID

                           where a.Product_Description.Contains(desc)
                           select new
                           {
                               a.Product_ID,
                               a.Product_Description,
                               a1.Product_Brand_Name,
                               a2.Product_Type_Name,
                               a3.Number_Of_Ply,
                               a4.Number_Of_Sheet,
                               a5.Pack_Size_Description,
                               a6.Length_Size,
                               a7.Length_Measurement_Unit,
                               a8.Width_Size,
                               a9.Width_Measurement_Unit,
                               a.Sales_Price,
                               a.Image


                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchProduct_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainProduct.pdf");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSearchSale.Text == "")
                {
                    label3.Visible = true;
                }

                List<Product> Ptype = db.Products.Where(o => o.Product_Description.Contains(txtSearchSale.Text)).ToList();


                if (Ptype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No product found");

                }

                else
                {
                    foreach (var a in Ptype)
                    {

                       //dgvClientSearch.DataSource = Ptype.Select(col => new { col.Product_ID, col.Product_Description, col.Available_Quantity,col.Sales_Price, col.Image, col.Product_Type_ID, col.Product_Brand_ID, col.Ply_ID, col.Pack_Size_ID, col.Sheet_ID, col.Length_ID, col.Width_ID }).ToList();

                       dgvClientSearch.DataSource = Get(txtSearchSale.Text);
                }
            }
            }

            catch
            {
            }
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
          dgvClientSearch.DataSource = Get1();
            dgvClientSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvClientSearch.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product")
                {
                    FrmMaintainProduct form1 = new FrmMaintainProduct(val);
                    form1.ShowDialog();

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Please specify your product type search details first");
            }
           
        }

        private void txtSearchSale_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
