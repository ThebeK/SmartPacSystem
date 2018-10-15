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

namespace MainSystem.Products.Widths
{
    public partial class FrmSearchWidth : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchWidth(string x)
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

                int val = Convert.ToInt32(dgvWidth.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Width")
                {
                    FrmMaintainWidth dd = new FrmMaintainWidth(val);
                    dd.ShowDialog();
                   

                    this.Close();

                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product pack size search details first");
            }
            // this.Show();
            this.Activate();
        }

        private void FrmSearchWidth_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.Widths on a.Width_ID equals a1.Width_ID

                           select new
                           {
                               a.Width_ID,
                               a1.Width_Size,
                               a1.Width_Measurement_Unit

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Width_Size == Convert.ToInt32(txtSearchWidth.Text))
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }

        private void FrmSearchWidth_Load(object sender, EventArgs e)
        {
            dgvWidth.DataSource = db.Widths.ToList();
            dgvWidth.Columns[3].Visible = false;
            dgvWidth.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvWidth.Columns[2].HeaderText = "Unit";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchWidth.Text == "")
                {
                    lblWidth.Visible = true;
                    //MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchWidth.Text != "")
                {
                    //FIX
                    List<Width> PStype = db.Widths.Where(o => o.Width_Size.ToString().Contains(txtSearchWidth.Text.ToLower())).ToList();


                    if (PStype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Product Width found");

                    }

                    else
                    {
                        foreach (var a in PStype)
                        {
                            dgvWidth.DataSource = PStype.Select(col => new { col.Width_ID, col.Width_Measurement_Unit, col.Width_Size }).ToList();

                            dgvWidth.Columns[0].HeaderText = "Width_ID";
                            dgvWidth.Columns[1].HeaderText = "Width_Measurement_Unit";
                            dgvWidth.Columns[2].HeaderText = "Width_Size";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }
            catch { }
        }

        private void txtSearchWidth_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
