using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class GradeAcess
    {
        public static List<Grade> getGrades(List<Subject> subjects, int subject_ID)
        {
            List<Grade> grades = new List<Grade>();
            Database db = new Database();
            string query = "Select * from Grade WHERE Subject_ID = " + subject_ID;
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    int id = Convert.ToInt32(result["ID"]);
                    string name = result["Name"].ToString();
                    string grade_s = result["Grade"].ToString();
                    Subject subject = subjects.FirstOrDefault(o => o.ID == subject_ID);
                    Grade grade = new Grade(id, subject, float.Parse(grade_s), name);
                    grades.Add(grade);
                }
            }

            db.CloseConnection();
            return grades;
        }


        public static void insertGrade(int subject_id, string name,string grade)
        {
            Database db = new Database();
            string query = "INSERT INTO Grades ('Subject_ID', 'Name', 'Grade') VALUES(@subject_ID, @name,@grade,)";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@subject_ID", subject_id);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@grade", grade);
            var result = myCommand.ExecuteNonQuery();

            db.CloseConnection();



        }


        public static void UpdateGrade(int id,int subject_ID,string name,string grade) 
        {
            Database db = new Database();
            string query = "UPDATE Time SET Subject_ID = @subject_ID, Name = @name, Grade = @grade WHERE ID = @ID ";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", id);
            myCommand.Parameters.AddWithValue("@subject_ID", subject_ID);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@grade", grade);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();



        }

        public static void deleteGrade(int ID)
        {
            Database db = new Database();

            string query = "DELETE FROM Grade WHERE ID = @ID";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}
