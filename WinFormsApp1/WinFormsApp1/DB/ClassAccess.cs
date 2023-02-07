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
    class ClassAccess
    {

        public static List<Class> getClasses(List<Subject> subjects)
        {
            List<Class> classes = new List<Class>();
            Database db = new Database();
            string query = "Select * from Classes";
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    int id = Convert.ToInt32(result["ID"]);
                    string name = result["Name"].ToString();
                    string code = result["Code"].ToString();
                    int subjectID = Convert.ToInt32(result["Subject_ID"]);
                    Subject subject = subjects.FirstOrDefault(o => o.ID == subjectID);
                    Class @class = new Class(id, name,code, subject);
                    classes.Add(@class);
                }
            }

            db.CloseConnection();
            return classes;
        }

        public static List<Class> getClasses(List<Subject> subjects,int ID)
        {
            List<Class> classes = new List<Class>();
            Database db = new Database();
            string query = "Select * from Classes WHERE Subject_ID = " + ID;
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    int id = Convert.ToInt32(result["ID"]);
                    string name = result["Name"].ToString();
                    string code = result["Code"].ToString();
                    int subjectID = Convert.ToInt32(result["Subject_ID"]);
                    Subject subject = subjects.FirstOrDefault(o => o.ID == subjectID);
                    Class @class = new Class(id, name, code, subject);
                    classes.Add(@class);
                }
            }

            db.CloseConnection();
            return classes;
        }

        public static void insertClass(string name, string code, int Subject_ID)
        {
            Database db = new Database();
            string query = "INSERT INTO Classes ('Name', 'Code', 'Subject_ID') VALUES(@name, @code,@subject_ID)";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            myCommand.Parameters.AddWithValue("@subject_ID", Subject_ID);
            var result = myCommand.ExecuteNonQuery();

            db.CloseConnection();



        }

        public static void UpdateClass(string name, string code, int ID, int Subject_ID)
        {
            Database db = new Database();
            string query = "UPDATE Classes SET Name = @name, Code = @code, Subject_ID = @subject_ID WHERE id = @ID ";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            myCommand.Parameters.AddWithValue("@subject_ID", Subject_ID);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();



        }

        public static void deleteClass(int ID)
        {
            Database db = new Database();

            string query = "DELETE FROM Classes WHERE ID = @ID";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}
