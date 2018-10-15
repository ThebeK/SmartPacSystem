using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Employees
{
    public partial class FrmMaintainEmployee : Form
    {
        int tempID;
        public FrmMaintainEmployee(int x)
        {
            tempID = x;
            InitializeComponent();
            employeeTypeBindingSource.DataSource = db.Employee_Type.ToList();
        }
        SPEntities db = new SPEntities();
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
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Image myImage;
        public void PassImage(Image Img)
        {
            myImage = Img;
            pictureBox1.Image = myImage;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "MaintainEmployeeType.pdf");
        }

        private void FrmMaintainEmployee_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtEName, "Enter Employees First Name");
            toolTip1.SetToolTip(this.txtESurname, "Enter Employees Last Name");
            toolTip1.SetToolTip(this.txtAddress, "Enter Employees Address");
            toolTip1.SetToolTip(this.txtID, "Enter Employees 13 digit ID");
            toolTip1.SetToolTip(this.txtAccountNum, "Enter 13 digit Account Number");
            toolTip1.SetToolTip(this.txtTaxumber, "Enter 10 digit tax number");
            toolTip1.SetToolTip(this.cbxEmployeeType, "Select Employees Role");
            toolTip1.SetToolTip(this.txtContactNumber, "Enter 10 digit telephone number");
            toolTip1.SetToolTip(this.txtAddress, "Enter Employees address containing @");
            toolTip1.SetToolTip(this.cbxTitle, "Select Employees suffix");
            toolTip1.SetToolTip(this.btnRetakePic, "Click to take picture");
            toolTip1.SetToolTip(this.btnUpdateEmployee, "Click to edit employee");
            toolTip1.SetToolTip(this.btnDeleteEmployee, "Click to remove employee");



            var query = db.Employees.Where(co => co.Employee_Id == tempID).First();

            txtEName.Text = query.Employee_Name;
            //txtEmployeeTypes.Text = query.Employees_Type1;

          
            txtESurname.Text = query.Employee_Surname;
            txtAddress.Text = query.Employee_Address;
            txtID.Text = Convert.ToString(query.Employee_Id_Number);
            txtAccountNum.Text = query.Employee_Account_Number.ToString();
            txtContactNumber.Text = Convert.ToString(query.Employee_Account_Number);
            txtEName.Text = query.Employee_Name;
     
            var query1 = db.Employee_Type.Where(co => co.Employee_Type_ID == query.Employee_Type_ID).First();
            cbxEmployeeType.Text = Convert.ToString(query1.Employees_Type_Description);
            txtContactNumber.Text = query.Employee_Cellphone_Number;
            txtEmailAddress.Text = query.Employee_Email_Address;
            txtTaxumber.Text = query.Employee_Tax_Number;

            var query3 = db.Titles.Where(co => co.Title_Id == query.Title_Id).First();
            cbxTitle.Text = Convert.ToString(query3.Title_Description);


            var EmployeeType = db.Employee_Type.ToList();
            //cbxEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbxEmployeeType.DisplayMember = "Employee_Type_Description";
            //cbxEmployeeType.ValueMember = "Employee_Type_ID";
            cbxEmployeeType.DataSource = EmployeeType;



            var titlea = db.Titles.ToList();
            //cbxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbxTitle.DisplayMember = "Title_Description";
            //cbxTitle.ValueMember = "Title_ID";
            cbxTitle.DataSource = titlea;



        }
        bool correct = false;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnRetakePic_Click(object sender, EventArgs e)
        {
            FrmMaintainCamera ff = new FrmMaintainCamera(this);
            ff.ShowDialog();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            correct = true;

            try
            {
                if (txtEName.Text == "" || txtAccountNum.Text == "" || txtContactNumber.Text == "" || txtEmailAddress.Text == "" || txtESurname.Text == "" || txtID.Text == "" || cbxEmployeeType.SelectedValue == null)
                {

                    MessageBox.Show("Please Enter all fields on the employee Form");
                    correct = false;
                }
                if (txtEName.Text == "")
                {
                    lblName.Visible = true;

                }
                if (txtESurname.Text == "")
                {
                    lblSurname.Visible = true;
                }
                if (txtAddress.Text == "")
                {
                    lblAddress.Visible = true;
                }
                if (txtID.Text == "")
                {
                    lblidentityNumber.Visible = true;
                }
                if (txtAccountNum.Text == "")
                {
                    lblAccountNumber.Visible = true;
                }
                if (txtTaxumber.Text == "")
                {
                    lblTaxN.Visible = true;
                }
                if (txtContactNumber.Text == "")
                {
                    lblContact.Visible = true;
                }

                if (txtEmailAddress.Text.Contains("@") == false || txtEmailAddress.Text == "")
                {
                    lblEmailAddress.Visible = true;
                }
                if (pi.Image == null)
                {
                    lblPicture.Visible = true;
                    lblPicture.Text = "Please upload a valid ID picture";
                   
                   
                }

                if (txtEmailAddress.Text.Contains("@") == true && correct == true)
                {
                    //byte[] binaryPic = new byte[100000];
                    //binaryPic = imageToByteArray(pi.Image);

                    var query = db.Employees.Where(co => co.Employee_Id == tempID).First();
                    //query.Employee_Id = 0;
                    query.Employee_Name = txtEName.Text;
                    query.Employee_Surname = txtESurname.Text;
                    query.Employee_Address = txtAddress.Text;
                    query.Employee_Id_Number = Convert.ToDecimal(txtID.Text);
                    query.Employee_Account_Number = Convert.ToDecimal(txtAccountNum.Text);
                    query.Employee_Name = txtEName.Text;
                    
                  
                    query.Employee_Type_ID = Convert.ToInt32(cbxEmployeeType.SelectedValue); 
                    query.Employee_Cellphone_Number = txtContactNumber.Text;
                    query.Employee_Email_Address = txtEmailAddress.Text;
                    query.Employee_Tax_Number = txtTaxumber.Text;
                   // Title us = cbxTitle.SelectedIndex as Title;
                     query.Title_Id = Convert.ToInt32(cbxTitle.SelectedValue);
                    query.Employee_Image = imageToByteArray(pi.Image);
                    //pictureBox1.Image = byteArrayToImage(emp.Profile_Picture);


                    db.SaveChanges();
                    MessageBox.Show("Employee Successfully Updated");
                    this.Close();
                }
            }




            catch (NullReferenceException)
            {
                //MessageBox.Show("Employee not updated");
            }
        }
       

        private void txtEName_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtTaxumber_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Employee ?", "Delete Employee ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Employee Emt2 = new Employee();
                    Emt2 = db.Employees.Find(tempID);

                    db.Employees.Remove(Emt2);
                    db.SaveChanges();

                    int id = Emt2.Employee_Id;
                    string employee_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Employee Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Employee was not deleted");

                }
                
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtAccountNum_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && !char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
