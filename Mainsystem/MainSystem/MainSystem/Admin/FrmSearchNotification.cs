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
    public partial class FrmSearchNotification : Form
    {
        string option;
        public FrmSearchNotification(string x)
        {
            option = x;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin.FrmAddNotification f = new Admin.FrmAddNotification();
            f.ShowDialog();
            dataGridView1.DataSource = db.Email_Notice_Template.ToList();
        }

        private void FrmSearchNotification_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var r = db.Email_Notice_Template.ToList();
            groupBox1.Visible = true;

            dataGridView1.DataSource = r.Select(col => new { col.Template_Id, col.Template_Description, col.Template_Text }).ToList();
            dataGridView1.Columns[0].HeaderText = "Template ID";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Template Description";
            dataGridView1.Columns[1].Width = 360;
            dataGridView1.Columns[2].HeaderText = "Template Text";
            dataGridView1.Columns[2].Width = 800;

            if (option == "Search Template")
            {
                // btnSelect.Visible = false;

            }
            dataGridView1.Refresh();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Notification")
            {
                Admin.FrmMaintainNotification myform = new Admin.FrmMaintainNotification(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();


            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Notification")
            {
                FrmPublishEmail myform = new FrmPublishEmail(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
            }

        }

        private void btnSendsms_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Notification")
            {
                //frmPublishSms myform = new frmPublishSms(val);
                //myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
            }
        }
    }
}
