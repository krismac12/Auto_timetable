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
    class SubjectAccess
    {
        public static List<Subject> getSubjects()
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

        public static void insertSubject(string name, string code)
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

        public static void UpdateSubject(string name, string code, int ID)
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

        public static void deleteSubject(int ID)
        {
            Database db = new Database();

            string query = "DELETE FROM Subjects WHERE ID = @ID";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}
