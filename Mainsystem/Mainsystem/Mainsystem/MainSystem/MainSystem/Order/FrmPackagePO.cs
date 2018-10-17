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
    public partial class FrmPackagePO : Form
    {
        public FrmPackagePO()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPackagePO_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnGenerateQR, "Click to make QR");
            toolTip1.SetToolTip(this.btnContinue, "Click to go to next tab");
        }
    }
}
