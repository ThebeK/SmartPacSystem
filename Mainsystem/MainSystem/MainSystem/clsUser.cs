using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSystem
{
    class clsUser
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }

        public clsUser(int id, string name, string password)
        {
            User_Id = id;
            User_Name = name;
            Password = password;

        }

    }
}
