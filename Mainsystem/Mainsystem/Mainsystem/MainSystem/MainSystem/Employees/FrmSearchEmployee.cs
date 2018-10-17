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

namespace MainSystem.Employees
{
    public partial class FrmSearchEmployee : Form
    {
        public FrmSearchEmployee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            Employees.FrmMaintainEmployee fe = new Employees.FrmMaintainEmployee();
            fe.ShowDialog();
        }

        private void FrmSearchEmployee_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchEmployee.pdf");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtSeachEmployee, "Enter Employees Name");
            toolTip1.SetToolTip(this.btnMaintain, "Click to edit or delete employee");
            toolTip1.SetToolTip(this.btnSearch, "Click to search for employee");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
