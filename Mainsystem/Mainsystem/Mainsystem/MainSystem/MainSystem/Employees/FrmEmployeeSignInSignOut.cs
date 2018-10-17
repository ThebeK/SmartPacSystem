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
    public partial class FrmEmployeeSignInSignOut : Form
    {
        public FrmEmployeeSignInSignOut()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            Employees.FrmAddEmployee red = new Employees.FrmAddEmployee();
            red.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employees.FrmSearchEmployee red = new Employees.FrmSearchEmployee();
            red.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "EmployeeSignIn.pdf");
        }

        private void FrmEmployeeSignInSignOut_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbxEmployeeName, "Select Employees Name");
            toolTip1.SetToolTip(this.btnAddProdType, "Click to add employee");
            toolTip1.SetToolTip(this.pictureBox1, "Click to edit employee");
            //
            toolTip1.SetToolTip(this.pictureBox1, "Click to edit employee");
            toolTip1.SetToolTip(this.chbxTimeIN, "Tick for time in");
            toolTip1.SetToolTip(this.chbxTimeOut, "Tick for time out");
            toolTip1.SetToolTip(this.chbxLunchIn, "Tick for lunch time in");
            toolTip1.SetToolTip(this.chbxLunchO, "Tick for lunch time out");


        }
        
    }
}
