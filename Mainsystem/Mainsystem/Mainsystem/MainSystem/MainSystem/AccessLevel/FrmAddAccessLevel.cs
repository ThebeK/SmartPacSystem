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
    public partial class FrmAddAccessLevel : Form
    {
        public FrmAddAccessLevel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAddAccessLevel_Load(object sender, EventArgs e)
        {   //tips
            toolTip1.SetToolTip(this.txtAccessName, "Enter Access Level Name");
            toolTip1.SetToolTip(this.btnAdd, "Click to Add");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddAccessLevel.pdf");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
