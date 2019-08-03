using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;

namespace Student_Management.DAL
{
    class DataAccess
    {
        private OleDbConnection cnn = new OleDbConnection();
        private DataSet dsHS = new DataSet();

        public DataAccess()
        {
            cnn.ConnectionString = "Provider=SQLNCLI11;Server=DESKTOP-NGVBILI\\SQLEXPRESS;Database=University;Trusted_Connection=yes";

        }

        public bool Check_User_Password(string username, string password, out string type, out string Password, out string Username)
        {
            cnn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Users", cnn);
            DataSet dsUser = new DataSet();
            da.Fill(dsUser, "Users");


            for (int i = 0; i < dsUser.Tables["Users"].Rows.Count; i++)
            {
                if (username == dsUser.Tables["Users"].Rows[i][0].ToString() && password == dsUser.Tables["Users"].Rows[i][1].ToString())
                {
                    Username = dsUser.Tables["Users"].Rows[i][0].ToString();
                    Password = dsUser.Tables["Users"].Rows[i][1].ToString();
                    type = dsUser.Tables["Users"].Rows[i][2].ToString();
                    cnn.Close();
                    return true;
                }
            }
            Password = null;
            type = null;
            Username = null;
            cnn.Close();
            return false;
        }

        public bool Update_User(string username, string password, string type)
        {
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE Users SET Password = ? WHERE Username = ?";

            cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = password;

            cmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = username;

            cmd.ExecuteNonQuery();
            cnn.Close();
            return true;
        }


        public void Update_dsHS(string table)
        {
            cnn.Open();
            string command = "SELECT * FROM " + table;
            OleDbDataAdapter da = new OleDbDataAdapter(command, cnn);
            da.Fill(dsHS, table);
            cnn.Close();
        }
        //------------------------------------------------------------------------------------------------------------------------


        public List<string> Get_Class()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < dsHS.Tables["Students"].Rows.Count; i++)
            {
                DataRow current = dsHS.Tables["Students"].Rows[i];
                if (!result.Contains(current[5]))
                    result.Add(current[5].ToString());
            }
            return result;
        }

        public bool Import_CSV_into_System(string filename, string table)
        {
            DataTable importedData = new DataTable();
            string header = null;

            using (StreamReader sr = new StreamReader(filename))
            {
                string Class = sr.ReadLine();
                string CourseID = "";
                
                if (string.IsNullOrEmpty(header))
                {
                    header = sr.ReadLine();
                }
                string[] headerColumns = header.Split(',');
                if (table == "Students" && headerColumns.Length != 5) return false;
                else if (table == "Courses" && headerColumns.Length != 4) return false;
                else if (table == "Scores" && headerColumns.Length != 7) return false;

                if (table == "Scores")
                {
                    string[] temp = Class.Split('-');
                    Class = temp[0];
                    CourseID = temp[1];
                }
                foreach (string headerColumn in headerColumns)
                {

                    if (headerColumn == "STT") continue;
                    importedData.Columns.Add(headerColumn);
                }

                if (table == "Scores")
                {
                    importedData.Columns.Add("MãMôn");
                }

                importedData.Columns.Add("Class");


                while (!sr.EndOfStream)
                {
                    sr.Read(new char[2], 0, 2);
                    string line;
                    if (table != "Scores")
                        line = sr.ReadLine() + ',' + Class;
                    else
                        line = sr.ReadLine() + ',' + CourseID + ',' + Class;
                    if (string.IsNullOrEmpty(line)) continue;
                    string[] fields = line.Split(',');
                    DataRow importedRow = importedData.NewRow();

                    for (int i = 0; i < fields.Count(); i++)
                    {

                        importedRow[i] = fields[i];

                    }
                    importedData.Rows.Add(importedRow);
                }
            }

            using (SqlConnection dbConnection = new SqlConnection("Data Source=DESKTOP-NGVBILI\\SQLEXPRESS;Initial Catalog=University;Integrated Security=SSPI;"))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    s.DestinationTableName = table;
                    foreach (var column in importedData.Columns)
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    s.WriteToServer(importedData);
                }
                dbConnection.Close();
            }

            Update_dsHS(table);
            if (table == "Courses") Update_ClassCourses();
            return true;
        }

        public void Add_Student(string MSSV, string Name, string Gender, string CMND, string Class)
        {

            cnn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO Students VALUES (?,?,?,?,?)";

            cmd.Parameters.Add("@MSSV", OleDbType.VarWChar).Value = MSSV;
            cmd.Parameters.Add("@Name", OleDbType.VarWChar).Value = Name;
            cmd.Parameters.Add("@Gender", OleDbType.VarWChar).Value = Gender;
            cmd.Parameters.Add("@CMND", OleDbType.VarWChar).Value = CMND;
            cmd.Parameters.Add("@Class", OleDbType.VarWChar).Value = Class;

            cmd.ExecuteNonQuery();
            cnn.Close();
            Update_dsHS("Students");
        }

        public List<List<string>> Get_Student_of_a_class(string Class)
        {
            List<List<string>> student = new List<List<string>>();
            for (int i = 0; i < dsHS.Tables["Students"].Rows.Count; i++)
            {

                List<string> temp0 = new List<string>();
                DataRow temp = dsHS.Tables["Students"].Rows[i];
                if (temp[5].ToString() == Class)
                {
                    temp0.Add(temp[0].ToString());
                    temp0.Add(temp[1].ToString());
                    temp0.Add(temp[2].ToString());
                    temp0.Add(temp[3].ToString());
                    temp0.Add(temp[4].ToString());
                    temp0.Add(temp[5].ToString());
                    student.Add(temp0);
                }
            }
            return student;
        }

        //------------------------------------------------------------------------------------------------------------------------

        public List<List<string>> Get_Courses_of_a_class(string Class)
        {
            List<List<string>> course = new List<List<string>>();
            for (int i = 0; i < dsHS.Tables["Courses"].Rows.Count; i++)
            {

                List<string> temp0 = new List<string>();
                DataRow temp = dsHS.Tables["Courses"].Rows[i];
                if (temp[4].ToString() == Class)
                {
                    temp0.Add(temp[0].ToString());
                    temp0.Add(temp[1].ToString());
                    temp0.Add(temp[2].ToString());
                    temp0.Add(temp[3].ToString());
                    temp0.Add(temp[4].ToString());

                    course.Add(temp0);
                }
            }
            return course;
        }

        public List<string> Get_Class_course()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < dsHS.Tables["Courses"].Rows.Count; i++)
            {
                DataRow current = dsHS.Tables["Courses"].Rows[i];
                if (!result.Contains(current[4]))
                    result.Add(current[4].ToString());
            }
            return result;
        }

        //------------------------------------------------------------------------------------------------------------------------
        private void Update_ClassCourses()
        {
            cnn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT e.MSSV,f.MãMôn,f.Class FROM Students e JOIN Courses f ON e.Class = f.Class", cnn);
            da.Fill(dsHS, "ClassCourses");
            cnn.Close();


            using (SqlConnection dbConnection = new SqlConnection("Data Source=DESKTOP-NGVBILI\\SQLEXPRESS;Initial Catalog=University;Integrated Security=SSPI;"))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    s.DestinationTableName = "ClassCourses";
                    foreach (var column in dsHS.Tables["ClassCourses"].Columns)
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    s.WriteToServer(dsHS.Tables["ClassCourses"]);
                }
                dbConnection.Close();
            };
        }

        public List<string> Get_Course_Class()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < dsHS.Tables["ClassCourses"].Rows.Count; i++)
            {
                StringBuilder s = new StringBuilder();
                DataRow current = dsHS.Tables["ClassCourses"].Rows[i];
                s.Insert(0, current[3].ToString() + "-" + current[2].ToString());
                if (!result.Contains(s.ToString()))
                {
                    result.Add(s.ToString());
                }
            }
            return result;
        }

        public List<List<string>> Get_Student_of_a_Course_class(string Class, string Course)
        {
            List<List<string>> student = new List<List<string>>();
            for (int i = 0; i < dsHS.Tables["ClassCourses"].Rows.Count; i++)
            {
                List<string> temp0 = new List<string>();
                DataRow temp = dsHS.Tables["ClassCourses"].Rows[i];
                if (temp[3].ToString() == Class && temp[2].ToString() == Course)
                {
                    for (int j = 0; j < dsHS.Tables["Students"].Rows.Count; j++)
                    {
                        DataRow temp1 = dsHS.Tables["Students"].Rows[j];
                        if (temp1[1].ToString() == temp[1].ToString())
                        {
                            temp0.Add(temp1[1].ToString());
                            temp0.Add(temp1[2].ToString());
                            temp0.Add(temp1[3].ToString());
                            temp0.Add(temp1[4].ToString());
                            student.Add(temp0);
                            break;
                        }
                    }

                }
            }
            return student;
        }

        //-------------------------------------------------------------------------------------------------------------------------

        public List<string>Get_Score_Class()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < dsHS.Tables["Scores"].Rows.Count; i++)
            {
                StringBuilder s = new StringBuilder();
                DataRow current = dsHS.Tables["Scores"].Rows[i];
                s.Insert(0, current[8].ToString() + "-" + current[7].ToString());
                if (!result.Contains(s.ToString()))
                {
                    result.Add(s.ToString());
                }
            }
            return result;
        }

        public List<List<string>> Get_Student_of_a_Score_class(string Class, string Course)
        {
            List<List<string>> score = new List<List<string>>();
            for (int i = 0; i < dsHS.Tables["Scores"].Rows.Count; i++)
            {
                List<string> temp0 = new List<string>();
                DataRow temp = dsHS.Tables["Scores"].Rows[i];
                if (temp[8].ToString() == Class && temp[7].ToString() == Course)
                {
                    temp0.Add(temp[0].ToString());
                    temp0.Add(temp[1].ToString());
                    temp0.Add(temp[2].ToString());
                    temp0.Add(temp[3].ToString());
                    temp0.Add(temp[4].ToString());
                    temp0.Add(temp[5].ToString());
                    temp0.Add(temp[6].ToString());

                    score.Add(temp0);
                }


            }
            return score;
        }

    }


}


