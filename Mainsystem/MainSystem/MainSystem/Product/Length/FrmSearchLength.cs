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

namespace MainSystem.Products.Length
{
    public partial class FrmSearchLength : Form
    {
        SPEntities db = new SPEntities();
        string option;
        public FrmSearchLength(string x)
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

                int val = Convert.ToInt32(dgvLength.CurrentRow.Cells[0].Value);

                if (option == "Maintain Product Length")
                {//FIX
                    FrmMaintainLength form1 = new FrmMaintainLength(val);
                    form1.ShowDialog();
                    this.Activate();
                    this.Close();


                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your product length search details first");
            }
            
        }

        private void FrmSearchLength_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddProduct.pdf");
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
        public List<object> Get()
        {
            var details = (from a in db.Products
                           join a1 in db.pLengths on a.Length_ID equals a1.Length_ID

                           select new
                           {
                               a.Length_ID,
                               a1.Length_Size,
                               a1.Length_Measurement_Unit

                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                if (item.Length_Size == Convert.ToInt32(txtSearchLength.Text))
                {
                    retrurn.Add(item);
                }
            }
            return retrurn;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchLength.Text == "")
                {
                    lblSearch.Visible = true;
                    //MessageBox.Show("Error: No search details entered");

                }
                else if (txtSearchLength.Text != "")
                {
                    //FIX
                    List<pLength> PStype = db.pLengths.Where(o => o.Length_Size.ToString().Contains(txtSearchLength.Text.ToLower())).ToList();


                    if (PStype.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("No Product Length found");

                    }

                    else
                    {
                        foreach (var a in PStype)
                        {
                            dgvLength.DataSource = PStype.Select(col => new { col.Length_ID, col.Length_Measurement_Unit, col.Length_Size }).ToList();

                            dgvLength.Columns[0].HeaderText = "Length_ID";
                            dgvLength.Columns[1].HeaderText = "Length_Measurement_Unit";
                            dgvLength.Columns[2].HeaderText = "Length_Size";


                            //groupBox1.Visible = true;

                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void FrmSearchLength_Load(object sender, EventArgs e)
        {
            dgvLength.DataSource = db.pLengths.ToList();
            dgvLength.Columns[3].Visible = false;
            dgvLength.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLength.Columns[2].HeaderText = "Unit";
        }

        private void txtSearchLength_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }
    }
}
