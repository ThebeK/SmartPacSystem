using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainSystem
{
    public partial class frmAddClient : Form
    {
        private System.Threading.Timer mTimer;
        private int mDialogCount;
        private EventHandler handler;
        public frmAddClient()
        {
            InitializeComponent();
        }
        public SPEntities db = new SPEntities();
        byte[] FileData;
        string FName;
        public sealed class UserActivityMonitor
        {
            /// <summary>Determines the time of the last user activity (any mouse activity or key press).</summary>
            /// <returns>The time of the last user activity.</returns>

            public DateTime LastActivity => DateTime.Now - this.InactivityPeriod;

            /// <summary>The amount of time for which the user has been inactive (no mouse activity or key press).</summary>

            public TimeSpan InactivityPeriod
            {
                get
                {
                    var lastInputInfo = new LastInputInfo();
                    lastInputInfo.CbSize = Marshal.SizeOf(lastInputInfo);
                    GetLastInputInfo(ref lastInputInfo);
                    uint elapsedMilliseconds = (uint)Environment.TickCount - lastInputInfo.DwTime;
                    elapsedMilliseconds = Math.Min(elapsedMilliseconds, int.MaxValue);
                    return TimeSpan.FromMilliseconds(elapsedMilliseconds);
                }
            }

            public async Task WaitForInactivity(TimeSpan inactivityThreshold, TimeSpan checkInterval, CancellationToken cancel)
            {
                while (true)
                {
                    await Task.Delay(checkInterval, cancel);

                    if (InactivityPeriod > inactivityThreshold)
                        return;
                }
            }

            // ReSharper disable UnaccessedField.Local
            /// <summary>Struct used by Windows API function GetLastInputInfo()</summary>

            struct LastInputInfo
            {
#pragma warning disable 649
                public int CbSize;
                public uint DwTime;
               #pragma warning restore 649
            }

            // ReSharper restore UnaccessedField.Local

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool GetLastInputInfo(ref LastInputInfo plii);
        }
        readonly UserActivityMonitor _monitor = new UserActivityMonitor();

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await _monitor.WaitForInactivity(TimeSpan.FromMinutes(2), TimeSpan.FromSeconds(5), CancellationToken.None);
            MessageBox.Show("You have been inactive for sometime, please Login again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmLogin rs = new frmLogin();
            this.Hide();
            rs.ShowDialog();
            this.Close();
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
            Viewpdf vp = new Viewpdf();
            vp.ShowDialog();
            
            
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
        
        public static string setvalue = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog Get_PDF = new OpenFileDialog())
                {
                    Get_PDF.InitialDirectory = @"C:\";
                    Get_PDF.RestoreDirectory = true;
                    Get_PDF.Title = "Employee Documents";
                    Get_PDF.Multiselect = false;
                    Get_PDF.CheckFileExists = true;
                    Get_PDF.CheckPathExists = true;
                    Get_PDF.DefaultExt = "pdf";
                    Get_PDF.Filter = "PDF File (*.pdf)|*.pdf";
                    Get_PDF.FilterIndex = 1;
                    if (Get_PDF.ShowDialog() == DialogResult.OK)
                    {

                        FName = Get_PDF.FileName;
                        FileData = File.ReadAllBytes(FName);
                        File.ReadAllBytes(FName);
                        txtFilePath.Text = Get_PDF.FileName;
                        MessageBox.Show("Browse was successful");
                        setvalue = Get_PDF.FileName;
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Whoops, something went wrong, please try again");
            }
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
            Client NewCllient = new Client();
            Credit_Approval NewCA = new Credit_Approval();
            Credit_Approval Credit_Approval_Form = new Credit_Approval();
            City newCity = new City();
            Credit_Status crStatus = new Credit_Status();
            Client_Account_Status cAS = new Client_Account_Status();
            Province NewProv = new Province();
            if (txtName.Text == "" || txtVatRegNum.Text == "" || txtTelephone.Text == "" || txtFaxNumber.Text == "" || txtEmailAdd.Text == "" || txtPhysicalAdd.Text == "")
            {
                MessageBox.Show("Please enter all fields!");
            }


            string path = AppDomain.CurrentDomain.BaseDirectory + "..\\Lopac\\Images\\";
            try
            {


                //  NewCA.Credit_Approval_Form = Convert.ToString(txtFilePath.Text);
                // txtFilePath.Text = Convert.ToBase64String(NewCA.Credit_Approval_Form);
                //  NewCA.Credit_Approval_Form = Encoding.ASCII.GetBytes(txtFilePath.Text);
                NewCA.Credit_Status_ID = Convert.ToInt32(cbxCreditStatus.SelectedValue);
                NewCA.Credit_Approval_Amount = Convert.ToInt32(txtCreditAmount.Text);
                NewCA.Date_Of_Commencement = txtDateTimeDateOfCommencement.Value.Date;
                db.Credit_Approval.Add(NewCA);


                NewCllient.Client_Name = txtName.Text;
                NewCllient.Client_VAT_Reg_Number = txtVatRegNum.Text;
                NewCllient.Client_Telephone = "+27" + txtTelephone.Text;
                NewCllient.Client_Fax_Number = txtFaxNumber.Text;
                NewCllient.Client_Email_Address = txtEmailAdd.Text;
                NewCllient.Physical_Address = txtPhysicalAdd.Text;

                NewCllient.Province_Id = Convert.ToInt32(cbxProvince.SelectedValue.ToString());
                NewCllient.City_Id = Convert.ToInt32(cbxCity.SelectedValue);
                NewCllient.Account_Status_ID = Convert.ToInt32(cbxAccountStatus.SelectedValue);

                NewCllient.Credit_Approval_ID = Convert.ToInt32(cbxCreditStatus.SelectedValue);

                NewCllient.Credit_Approval_ID = NewCA.Credit_Approval_ID;

                db.Clients.Add(NewCllient);


                db.SaveChanges();

                MessageBox.Show("Client Has been Added succesfully");


                //Audit Log
                int Client_Id = NewCllient.Client_ID;
                string client_Value = Convert.ToString(NewCllient);

                Audit_Log Current_Audit3 = new Audit_Log();
                Current_Audit3.Table_Name = "Client";
                // Current_Audit3.Users_Id = Globals.Users_Id;
                Current_Audit3.Date_Time = DateTime.Now;
                db.Audit_Log.Add(Current_Audit3);
                db.SaveChanges();
                int Log_ID3 = Current_Audit3.Audit_Log_Id;


                Audit_Create_Delete Current_Create3 = new Audit_Create_Delete();
                Current_Create3.Audit_Log_Id = Log_ID3;
                Current_Create3.Created = true;
                Current_Create3.PK_Row_Effected = Client_Id;
                Current_Create3.Value = client_Value;
                db.Audit_Create_Delete.Add(Current_Create3);
                db.SaveChanges();
                this.Close();
                this.Hide();
                //MessageBox.Show("Are you sure you want to add this client ?", "confirmation", MessageBoxButtons.YesNo);
                //MessageBox.Show("Client details have been added successfully");
                //MessageBox.Show("Client already exists on the system");
                //MessageBox.Show("Please fill in all required fields");
                //MessageBox.Show("Please select a client");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Whoops, Something went wrong. Please try again" + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddCity f = new frmAddCity();
            f.ShowDialog();
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
             using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                clientAccountStatusBindingSource.DataSource = db.Client_Account_Status.ToList();
                creditStatusBindingSource.DataSource = db.Credit_Status.ToList();
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
