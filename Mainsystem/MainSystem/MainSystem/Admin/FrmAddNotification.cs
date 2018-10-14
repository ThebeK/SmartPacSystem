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

namespace MainSystem.Admin
{
    public partial class FrmAddNotification : Form
    {
        string option;
        public FrmAddNotification()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        bool correct = true;
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

        private void btnMaintain_Click(object sender, EventArgs e)
        {
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
           
          
            //Admin.FrmPublish yy = new Admin.FrmPublish();
            //yy.ShowDialog();
            //this.Show();
            //this.Activate();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void FrmAddNotification_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "AddNotification.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            correct = true;

            Email_Notice_Template newTemplate = new Email_Notice_Template();

            if (txtDescription.Text == "")
            {

                MessageBox.Show("Please enter a Template Description");
                correct = false;
            }

            if (txtText.Text == "")
            {

                MessageBox.Show("Please enter Template Text");
                correct = false;
            }
            if (correct == true)
            {
                newTemplate.Template_Description = txtDescription.Text;
                newTemplate.Template_Text = txtText.Text;


                db.Email_Notice_Template.Add(newTemplate);

                db.SaveChanges();

                int Template_ID = newTemplate.Template_Id;
                string Template_Value = Convert.ToString(newTemplate);



                Audit_Log Current_Audit = new Audit_Log();
                Current_Audit.Table_Name = "Notification Template";
                Current_Audit.Active_User_ID = clsGlobals.Userlogin.Active_User_Id;
                Current_Audit.Date_Time = DateTime.Now;
                db.Audit_Log.Add(Current_Audit);
                db.SaveChanges();
                int Log_ID = Current_Audit.Audit_Log_Id;

                Audit_Create_Delete Current_Create = new Audit_Create_Delete();
                Current_Create.Audit_Log_Id = Log_ID;
                Current_Create.Created = true;
                Current_Create.PK_Row_Effected = Template_ID;
                Current_Create.Value = Template_Value;
                db.Audit_Create_Delete.Add(Current_Create);
                db.SaveChanges();
                MessageBox.Show("Notification template created successfully");
                this.Close();


            }
        }
    }
}
