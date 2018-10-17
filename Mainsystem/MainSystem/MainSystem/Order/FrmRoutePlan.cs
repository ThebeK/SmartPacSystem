using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainSystem;

namespace MainSystem
{
    public partial class frmRoutePlan : Form
    {
        SPEntities db = new SPEntities();
        public frmRoutePlan()
        {
            InitializeComponent();
            
        }

        private void frmRoutePlan_Load(object sender, EventArgs e)
        {
            
            comboBox1.DataSource = db.Cities.ToList();
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = db.Provinces.ToList();
            comboBox2.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(comboBox1.SelectedValue);
            int pid = Convert.ToInt32(comboBox2.SelectedValue);
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.DataSource = db.GetAddress(null, cid).Select(g=>g.Physical_Address+", "+g.City_Name+", "+g.Province_Name).ToList();
            }
            else if (comboBox1.SelectedIndex != -1)
            {
                listBox1.DataSource = db.GetAddress(pid, null).Select(g => g.Physical_Address + ", " + g.City_Name + ", " + g.Province_Name).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string address = listBox1.Text;
            //address1 = address.Replace(" ", "+");
            //address2 
            //webBrowser1.Navigate(new Uri("http://www.google.com/maps/place/" + address + "/"+ address2));
        }
    }
}
