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

        public void Import_CSV_into_System(string filename,string table)
        {
            DataTable importedData = new DataTable();
            string header = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string Class = sr.ReadLine();
                if (string.IsNullOrEmpty(header))
                {
                    header = sr.ReadLine();
                }
                string[] headerColumns = header.Split(',');
                foreach (string headerColumn in headerColumns)
                {
                    importedData.Columns.Add(headerColumn);
                }
                importedData.Columns.Add("Class");

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()+','+Class;
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
        }

        
    }
}


