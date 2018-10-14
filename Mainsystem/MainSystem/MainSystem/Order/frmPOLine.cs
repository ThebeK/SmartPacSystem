using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Order
{
    public partial class frmPOLine : Form
    {
        SPEntities db = new SPEntities();
        public frmPOLine(string ponum)
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Load_Purcase_Order_Line().Where(x => x.Purhcase_Order_Number == ponum).ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
