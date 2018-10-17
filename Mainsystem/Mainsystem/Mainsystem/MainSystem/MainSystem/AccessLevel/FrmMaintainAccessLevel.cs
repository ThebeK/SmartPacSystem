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

namespace MainSystem.AccessLevel
{
    public partial class FrmMaintainAccessLevel : Form
    {
        int AccessId;
        public FrmMaintainAccessLevel(string val)
        {
            InitializeComponent();
            AccessId = Convert.ToInt32(val);
        }

        private void FrmMaintainAccessLevel_Load(object sender, EventArgs e)
        { //tips
            
            toolTip1.SetToolTip(this.txtAccessName, "Please enter access name");
            toolTip1.SetToolTip(this.btnDelete, "Click to remove access level");
            toolTip1.SetToolTip(this.btnUpdate, "Click to edit access level");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainAccessLevel.pdf");
        }
    }
}
