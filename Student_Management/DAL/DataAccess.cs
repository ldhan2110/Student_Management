using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.DAL
{
    class DataAccess
    {
        private OleDbConnection cnn = new OleDbConnection();

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

        public bool Update_User(string username, string password,string type)
        {
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE Users SET Password = ? WHERE Username = ?";

            cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = password;
        
            cmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = username;

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
