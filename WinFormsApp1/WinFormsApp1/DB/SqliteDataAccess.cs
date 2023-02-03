using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class SqliteDataAccess 
    {
        public static  List<Subject>  getSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            Database db = new Database();
            string query = "Select * from Subjects";
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    //System.Diagnostics.Debug.WriteLine("ID: {0}, Name: {1}, Code: {2}", result["ID"], result["Name"], result["Code"]);
                    int id = Convert.ToInt32(result["ID"]);
                    string name = result["Name"].ToString();
                    string code = result["Code"].ToString();

                    Subject subject = new Subject(id, name, code);
                    subjects.Add(subject);
                }
            }

            db.CloseConnection();
            return subjects;


        }
    }
}
