using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class FrmBackUp : Form
    {
        public FrmBackUp()
        {
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
            rs.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DbBack_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;
                });
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
        private void button2_Click(object sender, EventArgs e)
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

                        dbServer.KillDatabase(txtDatabase.Text);
                        //dbServer.ConnectionContext.Disconnect();
                        //Disable automatic disconnection.   
                        //dbServer.ConnectionContext.AutoDisconnectMode = AutoDisconnectMode.NoAutoDisconnect;
                        ////Connect to the local, default instance of SQL Server.   
                        //dbServer.ConnectionContext.Connect();
                        ////The actual connection is made when a property is retrieved.   
                        //Console.WriteLine(dbServer.Information.Version);
                        ////Disconnect explicitly.   
                        //dbServer.ConnectionContext.Disconnect();
                        Microsoft.SqlServer.Management.Smo.Restore dbRestore = new Microsoft.SqlServer.Management.Smo.Restore() { Action = RestoreActionType.Database, Database = txtDatabase.Text };

                        dbRestore.Devices.AddDevice(GET_BAK.FileName, DeviceType.File);
                        dbRestore.PercentComplete += DbRestore_PercentComplete;
                        dbRestore.Complete += DbRestore_Complete;

                        dbRestore.SqlRestore(dbServer);

                        MessageBox.Show("Restoration successful");
                        //this.Close();
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@".\" + "BackupRestore.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txtServer.Text/*, txtUsername.Text, txtPassword.Text*/));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = txtDatabase.Text };
                SaveFileDialog dl = new SaveFileDialog();

                dl.Filter = "File Type (*.bak)|*.bak";
                dl.DefaultExt = "bak";
                if (dl.ShowDialog() == DialogResult.OK)
                {

                    dbBackup.Devices.AddDevice(dl.FileName, DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += DbBack_PercentComplete;
                    dbBackup.Complete += DbBack_Complete;
                    dbBackup.SqlBackupAsync(dbServer);

                    MessageBox.Show("Back up successful");
                    //this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {

            if (e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;
                });
            }
        }
    }
}
