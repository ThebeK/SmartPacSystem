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

namespace MainSystem
{
    public partial class frmAddProduct : Form
    {
        SPEntities db = new SPEntities();
        MemoryStream stream;
        bool PictureAdded;
        public frmAddProduct()
        {
            InitializeComponent();
            productBrandBindingSource.DataSource = db.Product_Brand.ToList();
            sheetBindingSource.DataSource = db.Sheets.ToList();
            widthBindingSource.DataSource = db.Widths.ToList();
            pLengthBindingSource.DataSource = db.pLengths.ToList();
            plyBindingSource.DataSource = db.Plies.ToList();
            packSizeBindingSource.DataSource = db.Pack_Size.ToList();
            productTypeBindingSource.DataSource = db.Product_Type.ToList();
        }
        bool correct = false;
        public bool ValidateIfProductExists(string prodd)
        {
            bool Check = false;
            foreach (var item in db.Products)
            {
                if (item.Product_Description == prodd)
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

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            Products.FrmAddProductType qq = new Products.FrmAddProductType("Maintain Product T");
            qq.ShowDialog();
            cbxprodT.DataSource = db.Product_Type.Select(x => x.Product_Type_Name).ToList();
            //  this.Show();
            this.Activate();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Products.FrmSearchProductType qq = new Products.FrmSearchProductType("Maintain Product T");
            qq.ShowDialog();
            cbxprodT.DataSource = db.Product_Type.Select(x => x.Product_Type_Name).ToList();
            // this.Show();
            this.Activate();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmAddBrand wq = new Products.Brand.FrmAddBrand("Maintain Product Brand");
            wq.ShowDialog();
            cbxbrand.DataSource = db.Product_Brand.Select(x => x.Product_Brand_Name).ToList();
            //  this.Show();
            this.Activate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Products.Brand.FrmSearchBrand wq = new Products.Brand.FrmSearchBrand("Maintain Product Brand");
            wq.ShowDialog();
            cbxbrand.DataSource = db.Product_Brand.Select(x => x.Product_Brand_Name).ToList();
            //  this.Show();
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products.Length.FrmAddLength wq = new Products.Length.FrmAddLength("Maintain Product Length");
            wq.ShowDialog();
            cbxLengths2.DataSource = db.pLengths.Select(x => x.Length_Size).ToList();
            cbxLength.DataSource = db.pLengths.Select(x => x.Length_Measurement_Unit).ToList();
            // this.Show();
            this.Activate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Products.Length.FrmSearchLength wq = new Products.Length.FrmSearchLength("Maintain Product Length");
            wq.ShowDialog();
            cbxLengths2.DataSource = db.pLengths.Select(x => x.Length_Size).ToList();
            cbxLength.DataSource = db.pLengths.Select(x => x.Length_Measurement_Unit).ToList();
            //   this.Show();
            this.Activate();
        }

        private void btnAddPackSize_Click(object sender, EventArgs e)
        {
            Products.PackSize.FrmAddPackSize wq = new Products.PackSize.FrmAddPackSize("Maintain Product Pack Size");
            wq.ShowDialog();
            cbxPackSize.DataSource = db.Pack_Size.Select(x => x.Pack_Size_Description).ToList();
            // this.Show();
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
            //  this.Show();
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
            //  this.Show();
            this.Activate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Products.Widths.FrmSearchWidth wq = new Products.Widths.FrmSearchWidth("Maintain Product Width");
            wq.ShowDialog();
            comboBox1.DataSource = db.Widths.Select(x => x.Width_Size).ToList();
            cbxWidth.DataSource = db.Widths.Select(x => x.Width_Measurement_Unit).ToList();
            // this.Show();
            this.Activate();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPDataSet.Width' table. You can move, or remove it, as needed.
            this.widthTableAdapter.Fill(this.sPDataSet.Width);
            // TODO: This line of code loads data into the 'sPDataSet.pLength' table. You can move, or remove it, as needed.
            this.pLengthTableAdapter.Fill(this.sPDataSet.pLength);
            // TODO: This line of code loads data into the 'sPDataSet.Sheet' table. You can move, or remove it, as needed.
            this.sheetTableAdapter.Fill(this.sPDataSet.Sheet);
            // TODO: This line of code loads data into the 'sPDataSet.Pack_Size' table. You can move, or remove it, as needed.
            this.pack_SizeTableAdapter.Fill(this.sPDataSet.Pack_Size);
            // TODO: This line of code loads data into the 'sPDataSet.Ply' table. You can move, or remove it, as needed.
            this.plyTableAdapter.Fill(this.sPDataSet.Ply);
            // TODO: This line of code loads data into the 'sPDataSet1.Product_Brand' table. You can move, or remove it, as needed.
            this.product_BrandTableAdapter.Fill(this.sPDataSet1.Product_Brand);
            // TODO: This line of code loads data into the 'sPDataSet.Product_Type' table. You can move, or remove it, as needed.
            this.product_TypeTableAdapter.Fill(this.sPDataSet.Product_Type);
            toolTip1.SetToolTip(this.txtDescription, "Products Name");
            toolTip1.SetToolTip(this.txtQuantity, "Number of Products");
            toolTip1.SetToolTip(this.cbxbrand, "Select Products Brand");
            toolTip1.SetToolTip(this.cbxLength, "Select Products Length");
            toolTip1.SetToolTip(this.cbxPackSize, "Select Number of packs");
            toolTip1.SetToolTip(this.cbxprodT, "Select product type");
            toolTip1.SetToolTip(this.cbxWidth, "Select Widths size");
            toolTip1.SetToolTip(this.cbxSheet, "Select Sheets");
            toolTip1.SetToolTip(this.btnAdd, "Click to add product");


            cbxprodT.Visible = true;
            cbxprodT.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public List<object> Get()
        {
            var details = (from a in db.Products

                           join a2 in db.Product_Type on a.Product_Type_ID equals a2.Product_Type_ID

                           where a.Product_Description.ToUpper().Contains("")
                           select new
                           {
                               a2.Product_Type_Name

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;

        }
        public int RetrieveLastProductID()
        {
            int ID = 0;

            List<Product> MyList = new List<Product>();
            List<Product> ReturnList = new List<Product>();

            foreach (var item in db.Products)
            {
                MyList.Add(item);
            }

            ReturnList.Add(MyList.Last());

            foreach (var item in ReturnList)
            {
                ID = item.Product_ID;
                break;
            }

            return ID;
        }
        //public int RetrieveLastImageID()
        //{
        //    int ID = 0;

        //    List<Product> MyList = new List<Product>();
        //    List<Product> ReturnList = new List<Product>();

        //    foreach (var item in db.Products)
        //    {
        //        MyList.Add(item);
        //    }

        //    ReturnList.Add(MyList.Last());

        //    foreach (var item in ReturnList)
        //    {
        //        ID = item.;
        //        break;
        //    }

        //    return ID;
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //{
                //    if (ValidateIfProductExists(txtDescription.Text) == true)
                //    {
                //        MessageBox.Show("Product exists");
                //    }


                correct = true;
                Product prod = new Product();
                //Sales_Unit_Price Price = new Sales_Unit_Price();
                Product Image = new Product();
                if (txtDescription.Text == "" || txtQuantity.Text == "0" || cbxprodT.Items == null || cbxbrand.Items == null ||txtPrice.Text==null|| cbxPly.Items == null || cbxPackSize.Items == null || cbxSheet.Items == null || cbxLength.Items == null || cbxWidth.Items == null)
                {

                    MessageBox.Show("Please Enter all fields on the product Form");
                    correct = false;
                }

                if (txtDescription.Text == "")
                {
                    //lblProdWarning.ForeColor = Color.Red;
                    lblProdDescr.Visible = true;
                    correct = false;
                }

                if (txtQuantity.Text == "0")
                {
                    lblavailQuan.ForeColor = Color.Red;
                    lblavailQuan.Text = "Invalid Quantity";
                    correct = false;
                }

                if (correct == true)
                {
                    if (PictureAdded == true)
                    {
                       // Image.Image_Name = txtImageName.Text;
                       


                        prod.Product_Brand_ID = Convert.ToInt32(cbxbrand.SelectedValue);
                        prod.Length_ID = Convert.ToInt32(cbxLength.SelectedValue);
                        prod.Pack_Size_ID = Convert.ToInt32(cbxPackSize.SelectedValue);
                        prod.Sheet_ID = Convert.ToInt32(cbxSheet.SelectedValue);
                        prod.Ply_ID = Convert.ToInt32(cbxPly.SelectedValue);
                        prod.Product_Type_ID = Convert.ToInt32(cbxprodT.SelectedValue);
                        prod.Available_Quantity = Convert.ToInt32(txtQuantity.Text);
                        prod.Product_Description = txtDescription.Text;
                        prod.Width_ID = Convert.ToInt32(cbxWidth.SelectedValue);
                        prod.Sales_Price = Convert.ToDecimal(txtPrice.Text);
                        string fileName = Path.GetFileName(txtImage.Text);
                        prod.Image = "../Image/Lopac/"+fileName;

                        db.Products.Add(prod);
                        db.SaveChanges();

                    }
                    else
                    {
                        prod.Product_Brand_ID = Convert.ToInt32(cbxbrand.SelectedValue);
                        prod.Length_ID = Convert.ToInt32(cbxLength.SelectedValue);
                        prod.Pack_Size_ID = Convert.ToInt32(cbxPackSize.SelectedValue);
                        prod.Sheet_ID = Convert.ToInt32(cbxSheet.SelectedValue);
                        prod.Ply_ID = Convert.ToInt32(cbxPly.SelectedValue);
                        prod.Product_Type_ID = Convert.ToInt32(cbxprodT.SelectedValue);
                        prod.Available_Quantity = Convert.ToInt32(txtQuantity.Text);
                        prod.Product_Description = txtDescription.Text;
                        prod.Width_ID = Convert.ToInt32(cbxWidth.SelectedValue);
                        prod.Sales_Price = Convert.ToDecimal(txtPrice.Text);
                        db.Products.Add(prod);
                        db.SaveChanges();


                    }

                   
                    MessageBox.Show("Product Successfully added");
                }


            }

            catch (NullReferenceException )
            {
                MessageBox.Show("Product Added");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)

        {
            string path= AppDomain.CurrentDomain.BaseDirectory + "..\\Lopac\\Images\\";
            try
            {
                
                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(opendlg.FileName);
                    stream = new MemoryStream();
                    img.Save(stream, img.RawFormat);
                    PictureAdded = true;
                    pbxImage.Image = img;
                    txtImage.Text = opendlg.FileName;
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
