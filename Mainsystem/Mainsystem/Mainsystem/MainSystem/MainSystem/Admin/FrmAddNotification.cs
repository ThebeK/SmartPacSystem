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

namespace MainSystem.Admin
{
    public partial class FrmAddNotification : Form
    {
        public FrmAddNotification()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            Admin.FrmMaintainNotification yy = new Admin.FrmMaintainNotification();
            yy.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            Admin.FrmPublish yy = new Admin.FrmPublish();
            yy.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void FrmAddNotification_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddNotification.pdf");
        }
    }
}
