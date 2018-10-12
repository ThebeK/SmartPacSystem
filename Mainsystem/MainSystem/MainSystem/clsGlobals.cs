using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    class clsGlobals
    {
        public static User_Role LoggedinUser;
        public static Active_User Userlogin;

        public static User_Role Role;
        public static Access_Level accessL;
        //public static User_Role LoggedinUser;
        //public static Active_User Userlogin;

        //public static User_Role Role;
        //public static AccessLevel accessL;
        public static bool CheckDatabaseExists()
        {
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                SqlConnection tmpConn = new SqlConnection("Server=.;Trusted_Connection=yes");

                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", "SP");


                using (tmpConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        tmpConn.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch 
            {
                result = false;
            }

            return result;
        }
        public static DialogResult ModalPopup(Form Background, Form NewForm)
        {
            //Draws black background for 'Modal' look
            Bitmap bmp = new Bitmap(Background.ClientRectangle.Width, Background.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(Background.PointToScreen(new Point(0, 0)), new Point(0, 0), Background.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, Background.ClientRectangle);
                }
            }

            using (Panel p = new Panel())
            {
                SetDoubleBuffered(p);

                p.Location = new Point(0, 0);
                p.Size = Background.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                Background.Controls.Add(p);
                p.BringToFront();

                //Shows selected form ontop of black background
                DialogResult drValue = NewForm.ShowDialog(Background);

                p.Visible = false;

                return drValue;
            }
        }
        public static void SetDoubleBuffered(Control c)
        {
            //Makes controls flikker less
            if (SystemInformation.TerminalServerSession)
                return;

            PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        public static string ReadFromRegistry(string KeyName)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LoPacTissue");

                if (key != null)
                {
                    return key.GetValue(KeyName).ToString();
                }
            }
            catch { }

            return "";
        }
        public static bool WriteIntoRegistry(string KeyName, object Value)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\LoPacTissue");
                key.SetValue(KeyName, Value);
                key.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsServerConnected()
        {
            using (SqlConnection connection = new SqlConnection("Server=.;Trusted_Connection=yes"))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
