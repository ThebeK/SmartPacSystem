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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhysicalAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtVatRegNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFaxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddClient.pdf");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewCreditApproval_Click(object sender, EventArgs e)
        {

        }

        private void txtCreditAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateTimeDateOfCommencement_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditSta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtName, "Enter Client Name ");

            toolTip1.SetToolTip(this.txtVatRegNum, "Enter 10 digit Vat Registration number");

            toolTip1.SetToolTip(this.txtTelephone, "Enter 10 digit telephone number");

            toolTip1.SetToolTip(this.txtFaxNumber, "Enter 10 digit fax number number");

            toolTip1.SetToolTip(this.txtEmailAdd, "Enter a valid email containing @");

            toolTip1.SetToolTip(this.txtPhysicalAdd, "Enter address");
            toolTip1.SetToolTip(this.cbxProvince, "Select South African Province");
            toolTip1.SetToolTip(this.cbxCity, "Select South African City");
            toolTip1.SetToolTip(this.txtCreditAmount, "Enter credit amount");
            toolTip1.SetToolTip(this.cbxCreditStatus, "Select valid credit status");
            toolTip1.SetToolTip(this.txtDateTimeDateOfCommencement, "Select date");
            toolTip1.SetToolTip(this.cbxCreditStatus, "Select valid credit status");
            toolTip1.SetToolTip(this.btnBrowse, "Browse to upload credit approval");
            toolTip1.SetToolTip(this.btnViewCreditApproval, "Click to view credit approval uploaded");
            toolTip1.SetToolTip(this.btnAddClient, "Click to add client");

        }
    }
}
