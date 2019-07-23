using Student_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.BL
{
   public class User
    {
        public string Username;
        private string Password;
        public string type;

        public bool Check_User(string username, string password)
        {
            DataAccess data = new DataAccess();
            return data.Check_User_Password(username, password,out this.type,out Password,out  this.Username);
        }

        public bool Check_User(string password)
        {
            if (password == Password) return true;
            return false;
        }

        public bool Check_Type(char c)
        {
            if (type.Contains(c)) return true;
            return false;
        }

        public void Reload_User(string pass)
        {
            Password = pass;
        }

        public void Log_out()
        {
            Username = null;
            Password = null;
            type = null;
        }
    }
}
