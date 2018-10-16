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
    public partial class frmMaintainCity : Form
    {
        public frmMaintainCity()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void frmMaintainCity_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();
                
            }

        }
    }
}
