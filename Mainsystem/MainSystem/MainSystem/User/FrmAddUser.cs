﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Users
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser(string option)
        {
            if (option == "Maintain Access Level")
            {
                selectedOption = "Maintain Access Level";

            }
            InitializeComponent();
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
            this.Hide();
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            AccessLevel.FrmAddAccessLevel rt = new AccessLevel.FrmAddAccessLevel();
            rt.ShowDialog();
            this.Show();
            this.Activate();
        }
        string selectedOption;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {

                string val = Convert.ToString(cbAccessLevelName.SelectedValue);
                if (selectedOption == "Maintain Access Level")
                {

                    AccessLevel.FrmMaintainAccessLevel MAS = new AccessLevel.FrmMaintainAccessLevel(val);
                    MAS.ShowDialog();
                    //AccessLevel.FrmMaintainAccessLevel ma = new AccessLevel.FrmMaintainAccessLevel(val);
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

        } 

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter all fields");
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(txtConfirmPassword.Text)));
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SP;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("insert into Active_User(Username,pass, Access)values(@User_Name,@Password,@access)", con);

                    cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", hash);
                    cmd.Parameters.AddWithValue("@access", (cbAccessLevelName.SelectedValue));


                    con.Open();
                    //var q = db.Access_L.Where(u => u.Access_Level_Name == cbAccessLevelName.Text).FirstOrDefault();
                    //int Aid = Convert.ToInt32(q.Access_Level_Id.ToString());
                    //NewUser.Access = Aid;


                    //db.Active_User.Add(NewUser);





                    string check = @"(Select count(*) from Active_User where Username='" + txtUsername.Text + "')";
                    SqlCommand cmda = new SqlCommand(check, con);
                    int count = (int)cmda.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("A user with that username already exists");

                    }
                    else
                    {

                        try
                        {


                            //int description = 0;
                            //var AccessL = db.Access_L.Where(emp => emp.Access_Level_Name == cbAccessLevelName.Text).Select(u => u.Access_Level_Id).FirstOrDefault();
                            //description = AccessL;
                            //NewUser.Access = AccessL;
                            //NewAccess.Access_Level_Id = description;
                            //NewUser.Access = NewAccess.Access_Level_Id;

                            cmd.ExecuteNonQuery();
                            //db.Active_User.Add(NewUser);
                            //int myUser = NewUser.Active_User_Id;

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("" + ex);
                        }

                        Active_User newuser = new Active_User();

                        MessageBox.Show("User successfully registered!");
                        this.Hide();
                        this.Close();
                        //Audit Log
                        int accessidz = newuser.Active_User_Id;
                        string user_Value = Convert.ToString(newuser);

                        Audit_Log Current_Audit6 = new Audit_Log();
                        Current_Audit6.Table_Name = "User";
                        // Current_Audit3.Users_Id = Globals.Users_Id;
                        Current_Audit6.Date_Time = DateTime.Now;
                        db.Audit_Log.Add(Current_Audit6);
                        db.SaveChanges();
                        int Log_ID6 = Current_Audit6.Audit_Log_Id;


                        Audit_Create_Delete Current_Create6 = new Audit_Create_Delete();
                        Current_Create6.Audit_Log_Id = Log_ID6;
                        Current_Create6.Created = true;
                        Current_Create6.PK_Row_Effected = accessidz;
                        Current_Create6.Value = user_Value;
                        db.Audit_Create_Delete.Add(Current_Create6);
                        db.SaveChanges();
                        this.Close();
                        this.Hide();

                    }

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {

                    }
                    else
                    {
                        MessageBox.Show("An Error:" + ex.Message);
                    }
                }

            }

            else if (txtPassword.Text != txtConfirmPassword.Text)
            {

                MessageBox.Show("Password and confirm Password fields do not match");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddUserProfile.pdf");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {

                accessLevelBindingSource1.DataSource = db.Access_Level.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
