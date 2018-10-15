using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Sales
{
    public partial class frmReport : Form
    {
        private DataSet ds1;
        private DataTable dt1;
        private string saleID1;

        public frmReport()
        {
            
        }

        public frmReport(DataTable dt, DataSet ds, string saleID)
        {
            this.dt1 = dt;
            this.ds1 = ds;
            this.saleID1 = saleID;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //crys rep = new crys();
            //rep.SetDataSource(ds1);
            //rep.SetParameterValue("Sale ID", saleID1);
            //crystalReportViewer1.ReportSource = rep;
        }
    }
}
