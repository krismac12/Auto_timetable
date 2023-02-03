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

        public static void insertSubject(string name,string code)
        {
            Database db = new Database();
            string query = "INSERT INTO Subjects ('Name', 'Code') VALUES(@name, @code)";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            var result = myCommand.ExecuteNonQuery();

            db.CloseConnection();



        }

        public static void UpdateSubject(string name, string code,int ID)
        {
            Database db = new Database();
            string query = "UPDATE Subjects SET Name = @name, Code = @code WHERE id = @ID ";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@code", code);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();



        }

        //Classes

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
                    Class @class = new Class(id, name, subject);
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
    }
}
