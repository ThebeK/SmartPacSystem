using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Reflection;
using MainSystem;



namespace MainSystem
{
    public partial class SmartPacDash : Form
    {
        int userID;
        public SmartPacDash(int x)
        {
            userID = x;
            InitializeComponent();
        }

        public List<Product> ListAllProducts()
        {
            List<Product> list = new List<Product>();
            using (var dbContext = new SPEntities())
            {
                foreach (var item in dbContext.Products)
                {
                    list.Add(item);
                }

            }
            return list;
        }
        public void LoadCalendar()
        {
            if (cmbMonth.SelectedIndex > -1)
            {
                string month = cmbMonth.Text;// should be in the format of Jan, Feb, Mar, Apr, etc...
                int yearofMonth = Convert.ToInt32(nudyear.Value);
                DateTime dateTime = Convert.ToDateTime("01-" + month + "-" + yearofMonth);
                DataRow dr;
                DataTable dt = new DataTable();
                dt.Columns.Add("Monday");
                dt.Columns.Add("Tuesday");
                dt.Columns.Add("Wednesday");
                dt.Columns.Add("Thursday");
                dt.Columns.Add("Friday");
                dt.Columns.Add("Saturday");
                dt.Columns.Add("Sunday");
                dr = dt.NewRow();

                for (int i = 0; i < DateTime.DaysInMonth(dateTime.Year, dateTime.Month); i += 1)
                {
                    if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Monday")
                    {
                        dr["Monday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Tuesday")
                    {
                        dr["Tuesday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Wednesday")
                    {
                        dr["Wednesday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Thursday")
                    {
                        dr["Thursday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Friday")
                    {
                        dr["Friday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Saturday")
                    {
                        dr["Saturday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Sunday")
                    {
                        dr["Sunday"] = i + 1;
                        dt.Rows.Add(dr);
                        dr = dt.NewRow();
                        continue;
                    }

                    if (i == DateTime.DaysInMonth(dateTime.Year, dateTime.Month) - 1)
                    {
                        dt.Rows.Add(dr);
                        dr = dt.NewRow();
                    }
                }

                dgvCalender.DataSource = dt;

                foreach (DataGridViewRow dgvr in dgvCalender.Rows)
                    dgvr.Height = (dgvCalender.ClientRectangle.Height - dgvCalender.ColumnHeadersHeight) / dgvCalender.Rows.Count;

                dgvCalender.PerformLayout();

                var schedules = db1.Client_Purchase_Order.Where(hvs => hvs.Order_Date.Value.Month == dateTime.Month && hvs.Order_Date.Value.Year == yearofMonth).ToList();

                if (schedules.Count > 0)
                {
                    foreach (Client_Purchase_Order hv in schedules)
                    {
                        int r = 0;
                        bool found = false;

                        for (r = 0; r < dgvCalender.Rows.Count; r++)
                        {
                            int c = 0;
                            for (c = 0; c < dgvCalender.Columns.Count; c++)
                            {
                                if (dgvCalender[c, r].Value.ToString() == hv.Order_Date.Value.Day.ToString())
                                {
                                    found = true;
                                    dgvCalender[c, r].Style.BackColor = Color.DarkRed;
                                    dgvCalender[c, r].Style.ForeColor = Color.White;
                                    break;
                                }
                            }
                            if (found)
                                break;
                        }
                    }
                }



            }
        }

        private void DvgCalanderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudyear_ValueChanged(object sender, EventArgs e)
        {
            LoadCalendar();
            dgvCalender.BringToFront();
            
            // dgvDetails.DataSource = null;
        }
        SPEntities db1 = new SPEntities();
        private void SmartPacDash_Load(object sender, EventArgs e)
        {
            LoadCalendar();
            timer1.Start();
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            //var user = db1.Users.Where(x => x.Users_Id == userID).First();
            //example
            //         label3.Text = user.Users_Name.ToString();
            //label4.Text = user.us.User_Type_Description.ToString();\

            try
            {
                int count = 0;
                count++;
                chart1.Series["Sufficient Products"].Points.Clear();
                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                chart1.ChartAreas[0].AxisX.Title = "Product";
                chart1.ChartAreas[0].AxisY.Title = "Available Quantity";

                foreach (var item in ListAllProducts())
                {
                    if (item.Available_Quantity <= 5)
                    {
                        chart1.Series["Sufficient Products"].Label = "#VALY";
                        chart1.Series["Sufficient Products"].LabelForeColor = Color.White;
                        chart1.Series["Sufficient Products"]["LabelStyle"] = "Bottom";
                        int n = chart1.Series["Sufficient Products"].Points.AddXY(item.Product_Description, item.Available_Quantity);
                        chart1.Series["Sufficient Products"].Points[n].Color = System.Drawing.Color.Orange;
                        chart1.Series["Sufficient Products"].IsValueShownAsLabel = true;
                    }
                    else if (item.Available_Quantity > 5)
                    {
                        chart1.Series["Sufficient Products"].Label = "#VALY";
                        chart1.Series["Sufficient Products"].LabelForeColor = Color.White;
                        chart1.Series["Sufficient Products"]["LabelStyle"] = "Bottom";
                        int n = chart1.Series["Sufficient Products"].Points.AddXY(item.Product_Description, item.Available_Quantity);
                        chart1.Series["Sufficient Products"].Points[n].Color = System.Drawing.Color.LightBlue;
                        chart1.Series["Sufficient Products"].IsValueShownAsLabel = true;
                    }
                }

                chart1.Update();
                chart1.Invalidate();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }


        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCalendar();
            dgvCalender.BringToFront();
        }

        private void DvgCalanderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

             if (dgvCalender.SelectedCells.Count > 0)
            {
                if (!string.IsNullOrEmpty(dgvCalender.SelectedCells[0].Value.ToString()))
                {
                    int Day = Convert.ToInt32(dgvCalender.SelectedCells[0].Value);

                    DateTime dt = new DateTime(Convert.ToInt32(nudyear.Value), (cmbMonth.SelectedIndex + 1), Day);

                    lblSelectedDate.Text = dt.ToString("dd MMMM yyyy");

                    var schedules = from hvs in db1.Client_Purchase_Order
                                    join a in db1.Clients on hvs.Client_ID equals a.Client_ID

                                    where hvs.Order_Date.Value.Month == (cmbMonth.SelectedIndex + 1)
                                    && hvs.Order_Date.Value.Year == nudyear.Value
                                    && hvs.Order_Date.Value.Day == Day
                                    select new
                                    {

                                        ClientID = hvs.Client_Purchase_Id,

                                        Client = a.Client_Name,
                                        Order_Date = hvs.Order_Date,
                                        Purcharse_Order_Number = hvs.PO_Number,
                                    };


                    dgvDetails.DataSource = schedules.ToList();
                    dgvDetails.Columns[0].Visible = false;
                    dgvDetails.BringToFront();
                }
                else
                {
                    dgvDetails.DataSource = null;
                }
            }
            else
            {
                dgvDetails.DataSource = null;
            }
        }
            

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateEmployeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.FrmAddEmployee formE = new Employees.FrmAddEmployee();
            formE.ShowDialog();
        }

        private void maintainEmplpyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addEmployeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void maintainProductTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicles.FrmAddVehicle formV = new Vehicles.FrmAddVehicle("Maintain Vehicle");
            formV.ShowDialog();
        }

        private void addProductTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] FileData;
            string FName;

            using (SaveFileDialog save_Document = new SaveFileDialog())
            {

                string pdfDoc = @"UserManual_compile.pdf";
                if (File.Exists(pdfDoc))
                {
                    //this.axAcroPDF1.src = pdfDoc;
                    //axAcroPDF1.LoadFile(pdfDoc);

                    save_Document.InitialDirectory = @"C:\";
                    save_Document.Title = "User Manual";
                    save_Document.Filter = "PDF Files (*.pdf)|*.pdf";
                    save_Document.DefaultExt = "pdf";
                    save_Document.AddExtension = true;
                    save_Document.FileName = "User Manual";


                    if (save_Document.ShowDialog() == DialogResult.OK)
                    {
                        FName = @"UserManual_compile.pdf";
                        FileData = File.ReadAllBytes(FName);
                        File.WriteAllBytes(save_Document.FileName, FileData);
                    }

                    MessageBox.Show("File not Saved");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartUp.frmHelp myForm = new StartUp.frmHelp();
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maintainProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void maintainProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void maintainVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SmartPacDash_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
