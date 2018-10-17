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
    public partial class FrmSearchAccessLevel : Form
    {
        public FrmSearchAccessLevel(string option)
        {
            if (option == "Maintain Access Level")
            {
                selectedOption = "Maintain Access Level";

            }
            InitializeComponent();
        }
        string selectedOption;
        private void btnMaintain_Click(object sender, EventArgs e)
        {

            string val = Convert.ToString(dgvAccesSearch.CurrentRow.Cells[0].Value);



            if (selectedOption == "Maintain Access Level")
            {
                FrmMaintainAccessLevel ma = new FrmMaintainAccessLevel(val);
                    ma.ShowDialog();
               
                this.Dispose();
                


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //if (txtSearchAccess.Text == "")
            //{

            //    MessageBox.Show("Error: No search details entered");

            //}
            //else if (txtSearchAccess.Text != "")
            //{

            //    List<Access_Level> Accesssearch = db.Access_Level.Where(o => o.Access_Level_Name.Contains(textBox1.Text)).ToList();

            //    if (Accesssearch.Count == 0)
            //    {


            //        MessageBox.Show("Error: No access level Found");

            //    }

            //    else
            //    {
            //        foreach (var a in Accesssearch)
            //        {
            //            dgvAccesSearch.DataSource = Accesssearch.Select(col => new { col.Access_Level_Id, col.Access_Level_Name }).ToList();
            //            dgvAccesSearch.Columns[0].HeaderText = "Access Level ID";
            //            dgvAccesSearch.Columns[0].Widths = 100;
            //            dgvAccesSearch.Columns[1].HeaderText = "Access_Level_Name";
            //            dgvAccesSearch.Columns[1].Widths = 150;


            //        }
            //    }
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSearchAccessLevel_Load(object sender, EventArgs e)
        {
            //tips
            toolTip1.SetToolTip(this.txtSearchAccess, "Enter Access Level Name");
           
            toolTip1.SetToolTip(this.btnSearch, "Click to search access level");
            toolTip1.SetToolTip(this.btnMaintain, "Click to delete or update access level");

        }

        private void FrmSearchAccessLevel_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchAccessLevel.pdf");
        }
    }
}
