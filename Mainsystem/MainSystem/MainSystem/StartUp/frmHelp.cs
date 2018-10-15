using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.StartUp
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

        private string LastSearchText;
        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                }
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//Recursive Search 
                }
                StartNode = StartNode.NextNode;
            }
        }
        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string searchText = this.textBox1.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            }


            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, treeView1.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 && LastNodeIndex < CurrentNodeMatches.Count)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                this.treeView1.SelectedNode = selectedNode;
                this.treeView1.SelectedNode.Expand();
                this.treeView1.Select();

            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string node = treeView1.SelectedNode.Text;
            if (node == "Users Login")
            {
                Process.Start(@".\" + "Login.pdf");
            }
            else if (node == "Users Logout")
            { Process.Start(@".\" + "Logout.pdf"); }

            else if (node == "Register Users Profile")
            { Process.Start(@".\" + "AddUser.pdf"); }

            else if (node == "Reset Users Profile")
            { Process.Start(@".\" + "ResetUserPassWord.pdf"); }

            else if (node == "Search Users Profile")
            { Process.Start(@".\" + "SearchUser.pdf"); }

            else if (node == "Maintain Users Profile")
            { Process.Start(@".\" + "MaintainUser.pdf"); }

            else if (node == "Create Users Access Level")
            { Process.Start(@".\" + "AddAccessLevel.pdf"); }

            else if (node == "Search Users Access Lever")
            { Process.Start(@".\" + "SearchAccessLevel.pdf"); }

            else if (node == "Maintain Users Access Level")
            { Process.Start(@".\" + "MaintainAccessLevel.pdf"); }

            else if (node == "Capture New Purchase Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Purchase Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Supplier rder")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Users Logout")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Supplier Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Receive Supplier Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Package Client Purchase Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate QR Code")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Load Purchase Order for Delivery")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Delivery Route Plan")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Confirm Successful Delivery")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Credit Return")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Products")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Products")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Products")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Products Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Products Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Products Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Upload Credit Approval Form")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Employees")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Employees")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Employees")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Employees Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Employees Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Employees Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Sign In")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Sign Out")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Make Sale")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Sale")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Refund Sale")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Vehicles")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Vehicles")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Vehicles")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Backup")
            { Process.Start(@".\" + "Backup.pdf"); }

            else if (node == "Restore")
            { Process.Start(@".\" + "Restore.pdf"); }

            else if (node == "Update Company Information")
            { Process.Start(@".\" + "CreateNotificationTemplate.pdf"); }

            else if (node == "Create Notification Template")
            { Process.Start(@".\" + "CreateNotificationTemplate.pdf"); }

            else if (node == "Maintain Notification Template")
            { Process.Start(@".\" + "MaintainNotificationTemplate.pdf"); }

            else if (node == "Publish Notification Template")
            { Process.Start(@".\" + "PublishNotificationTemplate.pdf"); }

            else if (node == "Generate Sales Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Products Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Credit Return Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Outstanding Deliveries Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Purchase Order Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Audit Log Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Employees Report")
            { Process.Start(@".\" + "test.pdf"); }

            else {
                MessageBox.Show("You have not selected a use case you want assistance with");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
