using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Admin
{
    public partial class frmPunblblishSms : Form
    {
        private string api;
        private string to;
        private string from;
        private string delivery;
        private string message;
        private string response;
        int val;
        public frmPunblblishSms(int x)
        {
            val = x;
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
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColRight"].Value))
                {
                    clientBindingSource.Add((Client)row.DataBoundItem);
                    clientBindingSource1.RemoveAt(row.Index);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    clientBindingSource1.Add((Client)row.DataBoundItem);
                    clientBindingSource.RemoveAt(row.Index);

                }
            }
        }

        private void frmPunblblishSms_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                clientBindingSource.DataSource = db.Clients.ToList();
            }
            var quary = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();


            textBox1.Text = quary.Template_Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Please Select Customers");
            }
            else
            {
                foreach (DataGridViewRow row in this.dataGridView2.Rows)
                {
                    int val = Convert.ToInt32(row.Cells[0].Value);
                    var u = db.Clients.Where(c => c.Client_ID == val).FirstOrDefault();
                    string data = u.Client_Telephone.ToString();

                    try
                    {
                        int ID = Convert.ToInt32(row.Cells[dataGridView2.Columns["Client"].Index].Value);


                       

                        data = data.Remove(0, 1);
                        data = "27" + data;
                        textBox2.Text += "," + data;

                        to = textBox2.Text;
                        to = to.Remove(0, 1);
                        message = textBox1.Text;

                        //creating a dictionary to store all the parameters that needs to be sent
                        Dictionary<string, string> Params = new Dictionary<string, string>();

                        //adding the parameters to the dictionary
                        string api = "J7B3M-efTgKazkXA5wC9lA==";
                        Params.Add("content", message);
                        Params.Add("to", to);

                        response = Api.SendSMS(api, Params);
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Something has gone wrong please ensure that you have a steady internet connection. if the problem persists please contact the administrator.");
                    }
                }
                MessageBox.Show("Message has Successfully Been Sent to Customers");

            }
        }
    }
}

