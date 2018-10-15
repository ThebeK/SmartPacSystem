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

namespace MainSystem.Users
{
    public partial class FrmSearchUser : Form
    {
        string selectedOption;
        public FrmSearchUser(string option)
        {

            
            if (option == "Maintain User")
            {
                selectedOption = "Maintain User";

            }
            InitializeComponent();
        }
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

        public List<object> Get1()
        {
            var details = (from a in db.Active_User

                           join a8 in db.Access_Level on a.Access equals a8.Access_Level_Id

                           //join a11 in db.Users on a.Users_Id equals a11.Users_Id



                           select new
                           {
                               a.Active_User_Id,
                               a.Username,
                               a8.Access_Level_Name
                              


                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }
        public List<object> Get(string name)
        {
            var details = (from a in db.Active_User

                           join a8 in db.Access_Level on a.Access equals a8.Access_Level_Id

                           //join a11 in db.Users on a.Users_Id equals a11.Users_Id


                           where a.Username.Contains(name)
                           select new
                           {
                               a.Active_User_Id,
                               a.Username,
                               a8.Access_Level_Name



                           }).ToList();

            var retrurn = new List<object>();

            foreach (var item in details)
            {
                retrurn.Add(item);

            }
            return retrurn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchUser_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "SearchUser.pdf");
        }

        private void FrmSearchUser_Load(object sender, EventArgs e)
        {
            dgvClientSearch.DataSource = Get1();
        }
        SPEntities db = new SPEntities();
        bool correct;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSale.Text == "")
                {

                    //MessageBox.Show("Error: No search details entered");
                    MessageBox.Show("enter user name");


                }
                else if (txtSearchSale.Text != "")
                {

                    List<Active_User> SearchUser = db.Active_User.Where(o => o.Username.Contains(txtSearchSale.Text)).ToList();


                    if (SearchUser.Count == 0)
                    {
                        //groupBox1.Visible = true;
                        MessageBox.Show("User not found");

                    }

                    else
                    {
                        foreach (var a in SearchUser)
                        {

                            //    dgvEmployees.DataSource = Etype.Select(col => new { col.Employee_Id,col.Employee_Name, col.Employee_Surname, col.Employee_Tax_Number, col.Employee_Id_Number, col.Employee_Address, col.Employee_Cellphone_Number, col.Employee_Account_Number, col.Employee_Email_Address, col.Employee_Type }).ToList();

                            dgvClientSearch.DataSource = Get(txtSearchSale.Text);

                          
                        }
                    }
                }
            }
            catch
            {
            }
            //correct = true;

            //if (txtSearchSale.Text == "")
            //{
            //    MessageBox.Show("User not found");
            //    correct = false;
            //}
            //if (correct == true)
            //{
            //    string username = txtSearchSale.Text;
            //    var query1 = db.Active_User.Where(co => co.Username == username).FirstOrDefault();

            //    if (query1 == null)
            //    {
            //        MessageBox.Show("User Not Found. Re-enter userName");
                    

            //        correct = false;
            //    }
            //    else
            //    {
            //        List<Active_User> SearchUser = db.Active_User.Where(o => o.Username.Contains(txtSearchSale.Text)).ToList();
            //        if(SearchUser.Count==0)
            //        {
            //            MessageBox.Show("Error: No user Found");
            //        }
            //        else
            //        {
            //            foreach (var b in SearchUser)
            //            {
            //                dgvClientSearch.DataSource = SearchUser.Select(col => new { col.Active_User_Id, col.Username, col.Access_Level }).ToList();
            //                dgvClientSearch.Columns[0].HeaderText = "Active User Id";
            //                dgvClientSearch.Columns[0].Width = 100;
            //                dgvClientSearch.Columns[1].HeaderText = "Username";
            //                dgvClientSearch.Columns[1].Width = 150;
            //                dgvClientSearch.Columns[2].HeaderText = "Access Level";
            //                dgvClientSearch.Columns[2].Width = 150;
            //            }
            //        }
            //    }
            //}
        }
        string selectedOptions;
        private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvClientSearch.CurrentRow.Cells[0].Value);
                if (selectedOption == "Maintain User")
                {

                    FrmMaintainUser MAu = new FrmMaintainUser(7);
                    MAu.ShowDialog();
                   // AccessLevel.FrmMaintainAccessLevel ma = new AccessLevel.FrmMaintainAccessLevel(val);
                    //ma.ShowDialog();
                    //this.Dispose();
                    //this.Activate();


                    //this.Dispose();



                }

            }

            catch (NullReferenceException)
            {
                //MessageBox.Show("Please specify your product sheet number search details first");
            }
            //string val = Convert.ToString(dgvAccesSearch.CurrentRow.Cells[0].Value);


        }

        private void dgvClientSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
