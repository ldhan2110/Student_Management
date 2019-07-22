using Student_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.BL
{
    class User
    {
        private string type;
        public bool Check_User(string username, string password)
        {
            DataAccess data = new DataAccess();
            return data.Check_User_Password(username, password,out type);
        }
    }
}
