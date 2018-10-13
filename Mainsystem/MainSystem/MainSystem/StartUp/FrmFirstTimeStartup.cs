using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace MainSystem.StartUp
{
    public partial class FrmFirstTimeStartup : Form
    {
        public FrmFirstTimeStartup()
        {
            InitializeComponent();
        }
        private bool SetupComplete = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if (SetupComplete)
            {
                clsGlobals.WriteIntoRegistry("SetupComplete", "1");
                MessageBox.Show("The setup has been completed. Please use the following details to log into the system:" + Environment.NewLine + Environment.NewLine + "Username:Thabang" + Environment.NewLine + "Password: 1234", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                if (MessageBox.Show("The setup has not been completed, if you close now you wil not be able to log in. Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show("database created successfully");
            }
        }
        private void DbBack_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });

            lbPercentage.Invoke((MethodInvoker)delegate
            {
                lbPercentage.Text = $"{e.Percent}%";
            });

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (clsGlobals.CheckDatabaseExists())
            {
                lblStepTwoResponse.ForeColor = Color.Green;
                lblStepTwoResponse.Text = "The database has been detected. Please click close to continue.";
                llCreateDB.Visible = false;

                SetupComplete = true;
            }
            else
            {
                lblStepTwoResponse.ForeColor = Color.Red;
                lblStepTwoResponse.Text = "The database could not be found, enter SQL details and click on the link below to create it.";
                llCreateDB.Visible = true;
                groupBox1.Visible = true;
            }

            Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SetupComplete)
            {
                clsGlobals.WriteIntoRegistry("SetupComplete", "1");
                MessageBox.Show("The setup has been completed. Please use the following details to log into the system:" + Environment.NewLine + Environment.NewLine + "Username: Thabang" + Environment.NewLine + "Password: xx", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                if (MessageBox.Show("The setup has not been completed, if you close now you wil not be able to log in. Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {


            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });

            lbPercentage.Invoke((MethodInvoker)delegate
            {
                lbPercentage.Text = $"{e.Percent}%";
            });
        }
        private void llCreateDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog GET_BAK = new OpenFileDialog())
            {
                GET_BAK.InitialDirectory = @"C:\";
                GET_BAK.RestoreDirectory = true;
                GET_BAK.Title = "Employee Documents";
                GET_BAK.Multiselect = false;
                GET_BAK.CheckFileExists = true;
                GET_BAK.CheckPathExists = true;
                GET_BAK.DefaultExt = "bak";
                GET_BAK.Filter = "bak File (*.bak)|*.bak";
                GET_BAK.FilterIndex = 1;
                if (GET_BAK.ShowDialog() == DialogResult.OK)
                {



                    progressBar1.Value = 0;

                    try
                    {
                        Server dbServer = new Server(new ServerConnection(txtServer.Text/*, txtUsername.Text, txtPassword.Text*/));
                        Microsoft.SqlServer.Management.Smo.Restore dbRestore = new Microsoft.SqlServer.Management.Smo.Restore() { Action = RestoreActionType.Database, Database = txtDatabase.Text };
                       
                        dbRestore.Devices.AddDevice(GET_BAK.FileName, DeviceType.File);
                        dbRestore.PercentComplete += DbRestore_PercentComplete;
                        dbRestore.Complete += DbRestore_Complete;
                        dbRestore.SqlRestore(dbServer);

                        MessageBox.Show(" Click Close to get Login Details");
                        //this.Close();
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmFirstTimeStartup_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
    }
}
