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
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        //    userBindingSource.DataSource = db.Users.ToList();
            titleBindingSource.DataSource = db.Titles.ToList();
            employeeTypeBindingSource.DataSource = db.Employee_Type.ToList();
        }

        SPEntities db = new SPEntities();
        
        Image myImage;
        Employee emp = new Employee();

        public bool ValidateIfEmployeeExists(string Cellnumber)
        {
            bool Check = false;
            foreach (var item in db.Employees)
            {
                if (item.Employee_Cellphone_Number == Cellnumber)
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }
        bool correct = false;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddEmployee.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPDataSet4.Employee_Type' table. You can move, or remove it, as needed.
            //this.employee_TypeTableAdapter.Fill(this.sPDataSet4.Employee_Type);
            // TODO: This line of code loads data into the 'sPDataSet3.Title' table. You can move, or remove it, as needed.
            //this.titleTableAdapter.Fill(this.sPDataSet3.Title);
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
            toolTip1.SetToolTip(this.btnTakePicture, "Click to take picture");
            toolTip1.SetToolTip(this.btnAddEmployee, "Click to add employee");

            //var EmployeeType = db.Employee_Type.Select(x => x.Employees_Type_Description).ToList();
            //cbxEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbxEmployeeType.DisplayMember = "Employees_Type_Descriptione";
            //cbxEmployeeType.ValueMember = "Employees_Type_ID";
            //cbxEmployeeType.DataSource = EmployeeType;

            //var Title = db.Titles.Select(x => x.Title_Description).ToList();
            //cbxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbxTitle.DisplayMember = "Title_Description";
            //cbxTitle.ValueMember = "Title_Id";
            //cbxTitle.DataSource = Title;



        }
        public void PassImage(Image Img)
        {
            myImage = Img;
            pictureBox1.Image = myImage;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {

            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            correct = true;
            Employee emp = new Employee();

            try
            {
                if (ValidateIfEmployeeExists(txtContactNumber.Text) == true)
                {
                    MessageBox.Show("Employee contact number exists");
                }
                if (txtEName.Text == "" || txtAccountNum.Text == "" || txtContactNumber.Text == "" || (txtEmailAddress.Text == "") || txtESurname.Text == "" || txtID.Text == "" || pictureBox1==null)
                {


                    MessageBox.Show("Please Enter all fields on the employee Form");
                    correct = false;
                }
                if (pictureBox1.Image == null)
                {
                    lblPicture.Visible = true;
                    lblPicture.Text = "Please insert the employee's ID photo by making use of the Browse button";
                    pictureBox1.Visible = true;
                   
                }

                else if (pictureBox1.Image != null)
                {
                    lblPicture.Visible = false;
                    pictureBox1.Visible = false;

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

                if (cbxEmployeeType.ValueMember == "")
                {
                    lblEmployeetype.Visible = true;
                }
                else if (txtEmailAddress.Text.Contains("@") == true && correct == true)
                {
                    byte[] binaryPic = new byte[100000];
                    binaryPic = imageToByteArray(pi.Image);


                    emp.Employee_Id = 0;
                    emp.Employee_Name = txtEName.Text;
                    emp.Employee_Surname = txtESurname.Text;
                    emp.Employee_Address = txtAddress.Text;
                    emp.Employee_Id_Number = Convert.ToInt64(txtID.Text);
                    emp.Employee_Account_Number = Convert.ToDecimal(txtContactNumber.Text);
                    emp.Employee_Name = txtEName.Text;
                    //Employee_Type et = cbxEmployeeType.SelectedValue as Employee_Type;
                    
                    emp.Employee_Type_ID = Convert.ToInt32(cbxEmployeeType.SelectedValue);
                    emp.Employee_Cellphone_Number = txtContactNumber.Text;
                    emp.Employee_Email_Address = txtEmailAddress.Text;
                    emp.Employee_Tax_Number = txtTaxumber.Text;
                    //User us = cbxUser.SelectedValue as User;
                    //emp.Users_Id = Convert.ToInt32(cbxUser.SelectedValue);
                    //Title title = cbxTitle.SelectedValue as Title;
                    emp.Title_Id = Convert.ToInt32(cbxTitle.SelectedValue);
                    emp.Employee_Image = binaryPic;


                    db.Employees.Add(emp);
                    db.SaveChanges();
                    MessageBox.Show("Employee Added Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please insert valid email address");
                }
            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Employee not added");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            frmCamera ff = new frmCamera(this);
            ff.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEName_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
        }

        private void txtESurname_KeyPress(object sender, KeyPressEventArgs Event)
        {
            if (!char.IsControl(Event.KeyChar) && char.IsDigit(Event.KeyChar))
            {
                Event.Handled = true;
            }
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

        private void txtTaxumber_KeyPress(object sender, KeyPressEventArgs Event)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
