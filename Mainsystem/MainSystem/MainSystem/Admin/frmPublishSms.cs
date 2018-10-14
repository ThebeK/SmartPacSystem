using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Admin
{
    public partial class frmPublishSms : Form
    {
        private string api;
        private string to;
        private string from;
        private string delivery;
        private string message;
        private string response;
        int val;
        public frmPublishSms(int x)
        {
            val = x;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    clientBindingSource1.Add((Client)row.DataBoundItem);
                    clientBindingSource.RemoveAt(row.Index);

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (Convert.ToBoolean(row.Cells["SelectRemove"].Value))
                {
                    clientBindingSource.Add((Client)row.DataBoundItem);
                    clientBindingSource1.RemoveAt(row.Index);

                }
            }
        }

        private void frmPublishSms_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = false;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            using (SPEntities db = new SPEntities())
            {
                clientBindingSource.DataSource = db.Clients.ToList();
            }

            var quary = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();
            txt_message.Text = quary.Template_Text;


        }

        private void btnSendSms_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Please Select Customers");
            }
            else
            {
                foreach (DataGridViewRow row in this.dataGridView2.Rows)
                {
                    int val = Convert.ToInt32(row.Cells[dataGridView2.Columns["Client"].Index].Value);

                   // int val = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                    var u = db.Clients.Where(c => c.Client_ID == val).FirstOrDefault();
                    string data = u.Client_Telephone.ToString();
                    data = data.Remove(0, 1);
                    data = "27" + data;
                    txt_to.Text += "," + data;

                   
                }

                //assigning text boxes to private variables
                to = txt_to.Text;
                to = to.Remove(0, 1);
                message = txt_message.Text;

                //creating a dictionary to store all the parameters that needs to be sent
                Dictionary<string, string> Params = new Dictionary<string, string>();

                //adding the parameters to the dictionary
                string api = "J7B3M-efTgKazkXA5wC9lA==";
                Params.Add("content", message);
                Params.Add("to", to);
                try
                {
                    response = Api.SendSMS(api, Params);
                    MessageBox.Show("Message has Successfully Been Sent to Customers");
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Something has gone wrong please ensure that you have a steady internet connection. if the problem persists please contact the administrator.");
                }
            }
        }
    }
}
