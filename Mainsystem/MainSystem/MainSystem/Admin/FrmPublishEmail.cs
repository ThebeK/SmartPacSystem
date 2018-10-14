using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MainSystem.Admin
{
    public partial class FrmPublishEmail : Form
    {
        int val;
        public FrmPublishEmail(int x)
        {
            val = x;
            InitializeComponent();
        }
        string textContent = "";
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

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "Publish.pdf");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPublish_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = false;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            
            using (SPEntities db = new SPEntities())
            {
                clientBindingSource8.DataSource = db.Clients.ToList();
            }



            txtFrom.Text = db.Company_Information.Select(co => co.Company_Name).FirstOrDefault();

            var comp = db.Company_Information.FirstOrDefault();

            var quary = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();


            txtSubjectLine.Text = quary.Template_Description;

            listBox1.Items.Add("");
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(quary.Template_Text);
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(Environment.NewLine);

            listBox2.Items.Add("Kind Regards");
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add("Lopac Tissues");
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add("Contact Number: " + comp.Telephone_Number);
            listBox2.Items.Add("Email: " + comp.Email_Address);

        }

        private void btndd_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    clientBindingSource9.Add((Client)row.DataBoundItem);
                    clientBindingSource8.RemoveAt(row.Index);

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColRight"].Value))
                {
                    clientBindingSource8.Add((Client)row.DataBoundItem);
                    clientBindingSource9.RemoveAt(row.Index);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.RowCount < 1)
            {
                MessageBox.Show("Please Add atleast one client");
            }
            else
            {

                int cusID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                textContent = "";
                foreach (string a in listBox1.Items)
                {
                    textContent += a;
                }
                foreach (string a in listBox2.Items)
                {
                    textContent += a;
                }

                DialogResult dialogResult = MessageBox.Show("Would you like to Publish marketing material?", "Publish Marketing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

                    try
                    {
                        foreach (DataGridViewRow row in this.dataGridView2.Rows)
                        {

                            int ID = Convert.ToInt32(row.Cells[dataGridView2.Columns["Client"].Index].Value);





                            var body = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();
                            var email = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Email_Address).FirstOrDefault();
                            var cust = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Name).FirstOrDefault();
                            string contents = textContent;
                            string title = txtSubjectLine.Text;

                            try
                            {
                                MailMessage mail = new MailMessage();
                                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                string custEmail = email.ToString();
                                //MessageBox.Show(custEmail);

                                mail.From = new MailAddress("infolopac@gmail.com");
                                mail.To.Add(custEmail);
                                mail.Subject = title;
                                //MessageBox.Show(listBox1.Text);
                                mail.Body = "Good Day " + cust.ToString() + " " + textContent;


                                SmtpServer.Port = 587;
                                SmtpServer.UseDefaultCredentials = false;
                                SmtpServer.Credentials = new System.Net.NetworkCredential("infolopac@gmail.com", "infolopac1");
                                SmtpServer.EnableSsl = true;

                                SmtpServer.Send(mail);
                                MessageBox.Show("Notification has been sent to Client(s)");


                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Mail has not been sent, please check your internet connection");

                            }

                        }
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }
        }
    }
}
            

