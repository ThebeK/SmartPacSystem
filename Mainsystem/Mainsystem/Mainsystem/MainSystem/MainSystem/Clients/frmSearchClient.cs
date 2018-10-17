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

namespace MainSystem
{
    public partial class frmSearchClient : Form
    {
        public frmSearchClient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            frmMaintainClient ff = new frmMaintainClient();
            ff.ShowDialog();
        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtSearchclient, "Enter client name");
            toolTip1.SetToolTip(this.btnSearch, "Click to search client");
            toolTip1.SetToolTip(this.btnMaintain, "Click to edit or remove client");

        }

        private void txtSearchSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSearchClient_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchClient.pdf");
        }
    }
}
