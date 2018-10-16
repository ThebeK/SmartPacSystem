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


namespace MainSystem { 
    public partial class frmMaintainClient : Form
    {
        int ClientID;
        string ID;
        public frmMaintainClient(string client, string x)
        {
            ID = x;
            ClientID = Convert.ToInt32(client);
            InitializeComponent();
            SPEntities db = new SPEntities();
            Credit_Approval NewCA = new Credit_Approval();
            Credit_Return NewReturn = new Credit_Return();
            Province NewProv = new Province();
            Client newClient = new Client();
            byte[] FileData;
            string FName;
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
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainClient.pdf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool correct;
        private void button2_Click(object sender, EventArgs e)
        {
            correct = true;

            if (txtName.Text == "" || txtVatRegNum.Text == "" || txtTelephone.Text == "" || txtFaxNumber.Text == "" || txtEmailAdd.Text == "" || txtPhysicalAdd.Text == "")
            {
                MessageBox.Show("Please enter all fields!");
                correct = false;
            }

            DialogResult dialogResult = MessageBox.Show("Would you like to update the client Information ?", "Update Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                if (correct == true)
                {
                    try
                    {
                        if (correct == true)
                        {
                            var query = db.Clients.Where(co => co.Client_ID == ClientID).FirstOrDefault();
                            var query1 = db.Provinces.Where(co => co.Province_Id == query.Province_Id).FirstOrDefault();
                            var query2 = db.Cities.Where(co => co.City_Id == query.City_Id).FirstOrDefault();
                            var query3 = db.Credit_Approval.Where(co => co.Credit_Approval_ID == query.Credit_Approval_ID).FirstOrDefault();
                            var query4 = db.Credit_Status.Where(co => co.Credit_Status_ID == query3.Credit_Approval_ID).FirstOrDefault();
                            var query5 = db.Client_Account_Status.Where(co => co.Account_Status_ID == query3.Credit_Approval_ID).FirstOrDefault();

                            Client NewCllient = new Client();
                            Credit_Approval NewCA = new Credit_Approval();
                            City newCity = new City();
                            Credit_Status crStatus = new Credit_Status();
                            Client_Account_Status cAS = new Client_Account_Status();
                            Province NewProv = new Province();

                            NewCllient = db.Clients.Where(co => co.Client_ID == ClientID).FirstOrDefault();
                            NewCA = db.Credit_Approval.Where(co => co.Credit_Approval_ID == query3.Credit_Approval_ID).FirstOrDefault();
                            newCity = db.Cities.Where(co => co.City_Id == query.City_Id).FirstOrDefault();
                            crStatus = db.Credit_Status.Where(co => co.Credit_Status_ID == query.Credit_Approval_ID).FirstOrDefault();
                            cAS = db.Client_Account_Status.Where(co => co.Account_Status_ID == query.Credit_Approval_ID).FirstOrDefault();


                            query.Client_Name = txtName.Text;
                            query.Client_VAT_Reg_Number = txtVatRegNum.Text;
                            query.Client_Telephone = "+27" + txtTelephone.Text;
                            query.Client_Fax_Number = txtFaxNumber.Text;
                            query.Physical_Address = txtPhysicalAdd.Text;
                            query.Client_Email_Address = txtEmailAdd.Text;

                            query1.Province_Name = cbxProvince.Text;
                            query2.City_Name = cbxCity.Text;
                            query3.Credit_Approval_Amount = Convert.ToDecimal(txtCreditAmount.Text);

                            if (query3.Credit_Status_ID == null)
                            {
                                cbxCreditStatus.SelectedIndex = -1;
                            }
                            else
                            {
                                query4.Credit_Status_Description = cbxCreditStatus.Text;

                            }
                            NewCA.Credit_Approval_ID = crStatus.Credit_Status_ID;
                            query5.Account_Status_Description = comboBox5.Text;

                            query3.Credit_Approval_Form = FileData;

                            //query3.Credit_Approval_Form = Encoding.ASCII.GetBytes(txtFilePath.Text);

                            db.SaveChanges();
                            MessageBox.Show("Client Has been updated succesfully");
                            this.Close();

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error has occured, and template was not updated successfully" + ex);
                    }
                }
        }
                    

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMaintainClient_Load(object sender, EventArgs e)
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
            toolTip1.SetToolTip(this.btnDeleteClient, "Click to remove client");
            toolTip1.SetToolTip(this.btnUpdateClient, "Click to edit client");
            toolTip1.SetToolTip(this.btnDownload, "Click to obtain credit approval");
            Credit_Approval NewCA = new Credit_Approval();
            try
            {

                NewCA = db.Credit_Approval.Find(Convert.ToInt32(ClientID));

                int Approvalid;
                Approvalid = Convert.ToInt32(NewCA.Credit_Approval_ID);
                Credit_Approval ret = db.Credit_Approval.Find(Approvalid);

                txtFilePath.Text = Convert.ToString(ret.Credit_Approval_Form);





                var query = db.Clients.Where(co => co.Client_ID == ClientID).FirstOrDefault();
                var query1 = db.Provinces.Where(co => co.Province_Id == query.Province_Id).FirstOrDefault();
                var query2 = db.Cities.Where(co => co.City_Id == query.City_Id).FirstOrDefault();
                var query3 = db.Credit_Approval.Where(co => co.Credit_Approval_ID == query.Credit_Approval_ID).FirstOrDefault();
                var query4 = db.Credit_Status.Where(co => co.Credit_Status_ID == query3.Credit_Status_ID).FirstOrDefault();
                var query5 = db.Client_Account_Status.Where(co => co.Account_Status_ID == query.Account_Status_ID).FirstOrDefault();


                //var qu = db.Provinces.Select(x => x.Province_Name).ToList();
                //txtProvince.DataSource = qu;
                //txtProvince.DropDownStyle = ComboBoxStyle.DropDownList;

                //var qu1 = db.Cities.Select(x => x.City_Name).ToList();
                //txtCity.DataSource = qu1;
                //txtCity.DropDownStyle = ComboBoxStyle.DropDownList;

                //var qu2 = db.Credit_Status.Select(x => x.Credit_Status_Description).ToList();
                //txtCreditSta.DataSource = qu2;
                //txtCreditSta.DropDownStyle = ComboBoxStyle.DropDownList;


                //var qu3 = db.Client_Account_Status.Select(x => x.Account_Status_Description).ToList();
                //txtAccountStatus.DataSource = qu3;
                //txtAccountStatus.DropDownStyle = ComboBoxStyle.DropDownList;




                txtName.Text = query.Client_Name;
                txtVatRegNum.Text = query.Client_VAT_Reg_Number;
                txtTelephone.Text = query.Client_Telephone;
                txtFaxNumber.Text = query.Client_Fax_Number;
                txtEmailAdd.Text = query.Client_Email_Address;
                txtPhysicalAdd.Text = query.Physical_Address;

                cbxProvince.Text = query1.Province_Name;
                cbxCity.Text = query2.City_Name;
                if (query3.Credit_Status_ID == null)
                {
                    cbxCreditStatus.SelectedIndex = -1;
                }
                else
                {
                    cbxCreditStatus.Text = query4.Credit_Status_Description;
                }

                if (query3.Credit_Approval_Form == null)
                {
                    txtFilePath.Text = "";
                    btnDownload.Visible = false;
                }
                else
                {
                    txtFilePath.Text = Convert.ToBase64String(query3.Credit_Approval_Form);
                    btnDownload.Visible = true;
                }

                comboBox5.Text = query5.Account_Status_Description;

                txtCreditAmount.Text = Convert.ToString(query3.Credit_Approval_Amount);


                txtDateTimeDateOfCommencement.MinDate = Convert.ToDateTime(query3.Date_Of_Commencement);
                comboBox5.Text = Convert.ToString(query.Client_Account_Status);

                txtFilePath.Text = Convert.ToString(query3.Credit_Approval_Form);


                //      NewCA = db.Credit_Approval.Find(Convert.ToInt32(CAid));
                int CreditAppid;
                CreditAppid = Convert.ToInt32(NewCA.Credit_Approval_ID);
                //if (NewCA.Credit_Approval_Form == null)
                //{
                //    btnDownload.Visible = false;
                //}





                using (SPEntities db = new SPEntities())
                {
                    provinceBindingSource.DataSource = db.Provinces.ToList();
                    cityBindingSource.DataSource = db.Cities.ToList();
                    clientAccountStatusBindingSource.DataSource = db.Client_Account_Status.ToList();
                    creditStatusBindingSource.DataSource = db.Credit_Status.ToList();
                }


            }
            catch
            {

            }
            }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                using (SaveFileDialog save_Document = new SaveFileDialog())
                {
                    string path = txtFilePath.Text;

                    save_Document.InitialDirectory = @"C:\";
                    save_Document.Title = "Client Documents";
                    save_Document.Filter = "PDF Files (.pdf)|.pdf";
                    save_Document.DefaultExt = "pdf";
                    save_Document.AddExtension = false;

                    if (save_Document.ShowDialog() == DialogResult.OK)
                    {
                        
                        var q1 = db.Clients.Where(x => x.Client_ID == ClientID).First();
                        var q = db.Credit_Approval.Where(co => co.Credit_Approval_ID == q1.Credit_Approval_ID).FirstOrDefault();

                        byte[] input = q.Credit_Approval_Form;
                        string result = System.Text.Encoding.UTF8.GetString(input);

                        File.WriteAllBytes(save_Document.FileName, input);
                        MessageBox.Show("FIle Downloaded Successfully");
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this customer?", "Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //db = new Model2();
                    //var query = db.Customers.Where(w => w.Customer_ID.ToString() == txtUserID.Text).FirstOrDefault();

                    Client client = new Client();
                    client = db.Clients.Find(Convert.ToInt32(ClientID));

                    db.Clients.Remove(client);
                    db.SaveChanges();
                    MessageBox.Show("Customer Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Customer was not deleted");
                    //throw;
                }
            }
        }

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
                     
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Whoops, something went wrong, please try again");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddCity f = new frmAddCity();
            f.ShowDialog(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
