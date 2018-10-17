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

namespace MainSystem.Products.PackSize
{
    public partial class FrmSearchPackSize : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchPackSize(string x)
        {
            InitializeComponent();
            option = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvProductPS.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Pack Size")
                {
                    FrmMaintainPackSize ff = new FrmMaintainPackSize(val);
                    ff.ShowDialog();
                    this.Activate();
                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product pack size search details first");
            }
            
            
        }

        private void FrmSearchPackSize_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void FrmSearchPackSize_Load(object sender, EventArgs e)
        {
            dgvProductPS.DataSource = db.Pack_Size.ToList();
            dgvProductPS.Columns[2].Visible = false;
            dgvProductPS.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductPS.Columns[1].HeaderText = "Pack Size";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchPS.Text == "")
            {
                label1.Visible = true;
                //MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchPS.Text != "")
            {

                List<Pack_Size> PStype = db.Pack_Size.Where(o => o.Pack_Size_Description.ToString().Contains(txtSearchPS.Text)).ToList();


                if (PStype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Product Pack Size found");

                }

                else
                {
                    foreach (var a in PStype)
                    {
                        dgvProductPS.DataSource = PStype.Select(col => new { col.Pack_Size_ID, col.Pack_Size_Description }).ToList();

                        dgvProductPS.Columns[0].HeaderText = "Sheet_ID";
                        dgvProductPS.Columns[1].HeaderText = "Number_Of_Sheet";


                        //groupBox1.Visible = true;

                    }
                }
            }
        }

        private void txtSearchPS_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
