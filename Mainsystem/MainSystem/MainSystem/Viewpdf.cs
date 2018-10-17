using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class Viewpdf : Form
    {
        public Viewpdf()
        {
            InitializeComponent();
        }

        private void Viewpdf_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog Get_PDF = new OpenFileDialog())
            {

                // if (Get_PDF.ShowDialog() == DialogResult.OK)
                //{
                //label1.Text = 
                axAcroPDF1.src = frmAddClient.setvalue;

                //}

            }
        }
    }
}
