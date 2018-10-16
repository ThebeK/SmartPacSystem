using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class frmAddCity : Form
    {
        public frmAddCity()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        Province NewProv = new Province();
        City NewCity = new City();
        private void frmAddCity_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();

            }
        }

        private void btnAddCty_Click(object sender, EventArgs e)
        {
            try
            {
                NewCity.City_Name = txtctyName.Text;
                NewCity.Province_ID = Convert.ToInt32(cbProvince.SelectedValue.ToString());
               

                db.Cities.Add(NewCity);
                db.SaveChanges();
                MessageBox.Show("City has been added successfully");
                this.Close();

            }
            catch (Exception)
            {

                
            }
           

        }
    }
}
