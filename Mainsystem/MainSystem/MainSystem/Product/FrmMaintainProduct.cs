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
using System.IO;

namespace MainSystem.Products
{
    public partial class FrmMaintainProduct : Form
    {
        int tempID;
        public FrmMaintainProduct(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        bool correct = false;

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            Products.FrmAddProductType qq = new Products.FrmAddProductType("Maintain Product T");
            qq.ShowDialog();
            cbxprodT.DataSource = db.Product_Type.Select(x => x.Product_Type_Name).ToList();
            // this.Show();
            this.Activate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Products.FrmSearchProductType qq = new Products.FrmSearchProductType("Maintain Product T");
            qq.ShowDialog();
            cbxprodT.DataSource = db.Product_Type.Select(x => x.Product_Type_Name).ToList();
            //  this.Show();
            this.Activate();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmAddBrand wq = new Products.Brand.FrmAddBrand("Maintain Product Brand");
            wq.ShowDialog();
            cbxbrand.DataSource = db.Product_Brand.Select(x => x.Product_Brand_Name).ToList();
            //   this.Show();
            this.Activate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmSearchBrand wq = new Products.Brand.FrmSearchBrand("Maintain Product Brand");
            wq.ShowDialog();
            cbxbrand.DataSource = db.Product_Brand.Select(x => x.Product_Brand_Name).ToList();
            // this.Show();
            this.Activate();
        }

        private void btnAddPackSize_Click(object sender, EventArgs e)
        {
            Products.PackSize.FrmAddPackSize wq = new Products.PackSize.FrmAddPackSize("Maintain Product Pack Size");
            wq.ShowDialog();
            cbxPackSize.DataSource = db.Pack_Size.Select(x => x.Pack_Size_Description).ToList();
            //this.Show();
            this.Activate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Products.PackSize.FrmSearchPackSize wq = new Products.PackSize.FrmSearchPackSize("Maintain Product Pack Size");
            wq.ShowDialog();
            cbxPackSize.DataSource = db.Pack_Size.Select(x => x.Pack_Size_Description).ToList();
            // this.Show();
            this.Activate();
        }

        private void btnAddSheetNumber_Click(object sender, EventArgs e)
        {
            Products.Sheets.FrmAddSheet wq = new Products.Sheets.FrmAddSheet("Maintain Product Sheets Number");
            wq.ShowDialog();
            cbxSheet.DataSource = db.Sheets.Select(x => x.Number_Of_Sheet).ToList();
            //   this.Show();
            this.Activate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Products.Sheets.FrmSearchSheet wq = new Products.Sheets.FrmSearchSheet("Maintain Product Sheet Number");
            wq.ShowDialog();
            cbxSheet.DataSource = db.Sheets.Select(x => x.Number_Of_Sheet).ToList();
            // this.Show();
            this.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products.Widths.FrmAddWidth wq = new Products.Widths.FrmAddWidth("Maintain Product Width");
            wq.ShowDialog();
            comboBox1.DataSource = db.Widths.Select(x => x.Width_Size).ToList();
            cbxWidth.DataSource = db.Widths.Select(x => x.Width_Measurement_Unit).ToList();
            //this.Show();
            this.Activate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Products.Widths.FrmSearchWidth wq = new Products.Widths.FrmSearchWidth("Maintain Product Width");
            wq.ShowDialog();
            comboBox1.DataSource = db.Widths.Select(x => x.Width_Size).ToList();
            cbxWidth.DataSource = db.Widths.Select(x => x.Width_Measurement_Unit).ToList();
            //this.Show();
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products.Length.FrmAddLength wq = new Products.Length.FrmAddLength("Maintain Product Length");
            wq.ShowDialog();
            cbxLengths2.DataSource = db.pLengths.Select(x => x.Length_Size).ToList();
            cbxLength.DataSource = db.pLengths.Select(x => x.Length_Measurement_Unit).ToList();
          //  this.Show();
            this.Activate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Products.Length.FrmSearchLength wq = new Products.Length.FrmSearchLength("Maintain Product Length");
            wq.ShowDialog();
            cbxLengths2.DataSource = db.pLengths.Select(x => x.Length_Size).ToList();
            cbxLength.DataSource = db.pLengths.Select(x => x.Length_Measurement_Unit).ToList();
            this.Show();
            this.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainProduct.pdf");
        }

        private void FrmMaintainProduct_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtDescription, "Products Name");
            toolTip1.SetToolTip(this.txtQuantity, "Number of Products");
            toolTip1.SetToolTip(this.cbxbrand, "Select Products Brand");
            toolTip1.SetToolTip(this.cbxLength, "Select Products Length");
            toolTip1.SetToolTip(this.cbxPackSize, "Select Number of packs");
            toolTip1.SetToolTip(this.cbxprodT, "Select product type");
            toolTip1.SetToolTip(this.cbxWidth, "Select Widths size");
            toolTip1.SetToolTip(this.cbxSheet, "Select Sheets");
            toolTip1.SetToolTip(this.btnUpdate, "Click to edit product");
            toolTip1.SetToolTip(this.btnDelete, "Click to delete product");
            var query = db.Products.Where(co => co.Product_ID == tempID).First();

            txtDescription.Text = query.Product_Description;
            txtQuantity.Text = Convert.ToString(query.Available_Quantity);
            txtPrice.Text = Convert.ToString(query.Sales_Price);

            txtImageName.Text = query.Image;

            //var query1 = db.Sales_Unit_Price.Where(co => co.Product_ID == query.Product_ID).First();
            txtPrice.Text = (query.Sales_Price).ToString();


            var ProductType = db.Product_Type.ToList();
            
            productTypeBindingSource.DataSource = ProductType;

            var Brands = db.Product_Brand.ToList();
            
            productBrandBindingSource.DataSource = Brands;

            var Plys = db.Plies.ToList();
            
            plyBindingSource.DataSource = Plys;

            var Widths = db.Widths.ToList();
            
            widthBindingSource.DataSource = Widths;


            var lengths = db.pLengths.Select(x => x.Length_Size).ToList();
            
            pLengthBindingSource.DataSource = lengths;

            var lengthss = db.pLengths.ToList();
            
            pLengthBindingSource.DataSource = lengthss;

            var Widthss = db.Widths.ToList();
           
            widthBindingSource.DataSource = Widthss;

            var PackSizes = db.Pack_Size.ToList();
            
            packSizeBindingSource.DataSource = PackSizes;

            var Sheets = db.Sheets.ToList();
          
            sheetBindingSource.DataSource = Sheets;

            

            try
            {
           
                //pbxImage.Image = System.Drawing.Image.FromFile(query.Image);
            }
            catch (FormatException)
            {
                //lblImageWarn.Text = "There was a problem with Uploading your image, Please try again";                
                pbxImage.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs Event)
        {

            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtImageName_KeyPress(object sender, KeyPressEventArgs Event)
        {

            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            correct = true;
            try
 { 
            if (txtDescription.Text == "" || txtQuantity.Text=="" || cbxprodT.Items == null || cbxbrand.Items == null || cbxPly.Items == null || cbxPackSize.Items == null || cbxSheet.Items == null || cbxLength.Items == null || cbxWidth.Items == null)
            {

                MessageBox.Show("Please Enter all fields on the product Form");
                correct = false;
            }
            if (txtDescription.Text == "")
            {
                lblProdDescr.Visible = true;
                correct = false;
            }
           
                if (correct == true)
                {
                    var query0 = db.Products.Where(co => co.Product_ID == tempID).First();
                    query0.Product_Description = txtDescription.Text;

                    var query = db.Products.Where(co => co.Product_ID == tempID).First();

                    int new1 = Convert.ToInt32(cbxbrand.SelectedValue);
                    var query2 = db.Product_Brand.Where(co => co.Product_Brand_ID ==new1).First();
                    query.Product_Brand_ID = query2.Product_Brand_ID;

                    int new2 = Convert.ToInt32(cbxprodT.SelectedValue);
                    var query3 = db.Product_Type.Where(co => co.Product_Type_ID == new2).First();
                    query.Product_Type_ID = query3.Product_Type_ID;

                    int new3 = Convert.ToInt32(cbxPackSize.SelectedValue);
                    var query4 = db.Pack_Size.Where(co => co.Pack_Size_ID == new3).First();
                    query.Pack_Size_ID = query4.Pack_Size_ID;

                    int new4 = Convert.ToInt32(cbxLength.SelectedValue);
                    var query5 = db.pLengths.Where(co => co.Length_ID == new4).First();
                    query.Length_ID = Convert.ToInt32(query5.Length_ID);

                    int new5 = Convert.ToInt32(cbxWidth.SelectedValue);
                    var query6 = db.Widths.Where(co => co.Width_ID == new5).First();
                    query.Width_ID = query6.Width_ID;

                    int value = Convert.ToInt32(cbxPly.Text);
                    var query7 = db.Plies.Where(co => co.Number_Of_Ply == (value)).First();
                    query.Ply_ID = query7.Ply_ID;

                    int val2 = Convert.ToInt32(cbxSheet.Text);
                    var query8 = db.Sheets.Where(co => co.Number_Of_Sheet == val2).First();
                    query.Sheet_ID = query8.Sheet_ID;

                    query.Sales_Price = Convert.ToDecimal(txtPrice.Text);
                    query.Image = txtImage.Text;
                    
                    
                    db.SaveChanges();
                   // db.SaveChangesAsync();
                    
                 MessageBox.Show("Product Successfully Updated");
                     this.Close();
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product?", "Delete Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Product prod2 = new Product();
                    prod2 = db.Products.Find(tempID);

                    db.Products.Remove(prod2);
                    db.SaveChanges();

                    int prodID = prod2.Product_ID;
                    string prodValue = Convert.ToString(prod2);
                    MessageBox.Show("Product Successfully Deleted");
                    this.Close();

                }
                catch 
                {
                    

                }
            }
            }
        MemoryStream stream;
        bool PictureAdded;
        private void btnBrowse_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = @"C:\Users\Thabang Monyamane\Desktop\SmartPacWeb\SmartPacWeb\Image\Lopac";


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    stream = new MemoryStream();
                    img.Save(stream, img.RawFormat);
                    PictureAdded = true;
                    pbxImage.Image = img;
                    txtImage.Text = openFileDialog1.FileName;
                }
                else
                {
                    PictureAdded = false;
                    pbxImage.Image = null;
                }


            }


            catch
            {
                MessageBox.Show("Picture format invalid");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
