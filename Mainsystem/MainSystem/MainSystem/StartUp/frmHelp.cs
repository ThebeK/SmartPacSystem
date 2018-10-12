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
            if (node == "User Login")
            {
                Process.Start(@".\" + "UserManual_compile.pdf");
            }
            else if (node == "User Logout")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Register User Profile")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Reset User Profile")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search User Profile")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain User Profile")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Create User Access Level")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search User Access Lever")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain User Access Level")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Capture New Purchase Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Purchase Order")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Supplier rder")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "User Logout")
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

            else if (node == "Add New Product")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Product")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Product")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Product Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Product Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Product Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Client")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Upload Credit Approval Form")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Employee")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Employee")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Employee")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Add New Employee Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Employee Type")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Employee Type")
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

            else if (node == "Add New Vehicle")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Search Vehicle")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Vehicle")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Backup")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Restore")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Update Company Information")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Create Notification Template")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Maintain Notification Template")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Publish Notification Template")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Sales Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Product Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Credit Return Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Outstanding Deliveries Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Purchase Order Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Audit Log Report")
            { Process.Start(@".\" + "test.pdf"); }

            else if (node == "Generate Employee Report")
            { Process.Start(@".\" + "test.pdf"); }

            else {
                MessageBox.Show("You have not selected a use case you want assistance with");
            }
        }
    }
}
