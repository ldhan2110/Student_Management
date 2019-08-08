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
        private DataAccess data = new DataAccess();

        public User()
        {

            data.Update_dsHS("Students");
            data.Update_dsHS("Courses");
            data.Update_dsHS("ClassCourses");
            data.Update_dsHS("Scores");
        }

        public bool Check_User(string username, string password)
        {
            return data.Check_User_Password(username, password, out this.type, out Password, out this.Username);
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

        //---------------------------------------------------------------------------------------------------------------------------
        public bool Impor_CSV_DB(string filename, string table)
        {
            if (data.Import_CSV_into_System(filename, table)) return true;
            return false;
        }

        public List<string> Get_Class()
        {
            return data.Get_Class();
        }

        public void Add_Student(string MSSV, string Name, string Gender, string CMND, string Class)
        {
            data.Add_Student(MSSV, Name, Gender, CMND, Class);
        }

        public List<List<string>> Get_Student_of_a_class(string Class)
        {
            return data.Get_Student_of_a_class(Class);
        }

        //---------------------------------------------------------------------------------------------------------------------------
        public List<string> Get_Class_course()
        {
            return data.Get_Class_course();
        }

        public List<List<string>> Get_Courses_of_a_class(string Class)
        {
            return data.Get_Courses_of_a_class(Class);
        }

        //---------------------------------------------------------------------------------------------------------------------------
        public List<string> Get_Course_Class()
        {
            return data.Get_Course_Class();
        }

        public List<List<string>> Get_Student_of_a_Course_class(string Class)
        {
            string[] temp = Class.Split('-');
            return data.Get_Student_of_a_Course_class(temp[0], temp[1]);
        }
        //----------------------------------------------------------------------------------------------------------------------------

        public List<string> Get_Score_Class()
        {
            return data.Get_Score_Class();
        }

        public List<List<string>> Get_Student_of_a_Score_class(string Class)
        {
            string[] temp = Class.Split('-');
            return data.Get_Student_of_a_Score_class(temp[0], temp[1]);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------

        public List<List<string>> Get_Score_of_a_student()
        {

            return data.Get_Score_of_a_student(this.Username);

        }
    }
}
