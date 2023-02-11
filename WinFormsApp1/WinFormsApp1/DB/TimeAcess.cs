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
    class TimeAcess
    {
        public static List<Time> getTimes(List<Class> classes, int class_ID)
        {
            List<Time> times = new List<Time>();
            Database db = new Database();
            string query = "Select * from Time WHERE Class_ID = " + class_ID;
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    int id = Convert.ToInt32(result["ID"]);
                    int type = Convert.ToInt32(result["Type"]);
                    string room = result["Room"].ToString();
                    string startTime = result["StartTime"].ToString();
                    string endTime = result["EndTime"].ToString();
                    int classID = Convert.ToInt32(result["Class_ID"]);
                    int start = Convert.ToInt32(result["Start_Week"]);
                    int end = Convert.ToInt32(result["End_Week"]);
                    Class @class = classes.FirstOrDefault(o => o.ID == classID);
                    Time time = new Time(id, room, type, DateTime.Parse(startTime), DateTime.Parse(endTime), @class,start,end);
                    times.Add(time);
                }
            }

            db.CloseConnection();
            return times;
        }

        public static List<Time> getNA()
        {
            List<Time> times = new List<Time>();
            Database db = new Database();
            string query = "Select * from Time WHERE Type = 2";
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            db.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    int id = Convert.ToInt32(result["ID"]);
                    int type = Convert.ToInt32(result["Type"]);
                    string room = result["Room"].ToString();
                    string startTime = result["StartTime"].ToString();
                    string endTime = result["EndTime"].ToString();
                    int start = Convert.ToInt32(result["Start_Week"]);
                    int end = Convert.ToInt32(result["End_Week"]);
                    Time time = new Time(id, room, type, DateTime.Parse(startTime), DateTime.Parse(endTime),start,end);
                    times.Add(time);
                }
            }

            db.CloseConnection();
            return times;
        }

        public static void insertTime(int type, string room, string start_time, string end_time, int class_ID,int start,int end)
        {
            Database db = new Database();
            string query = "INSERT INTO Time ('Type', 'Room', 'StartTime', 'EndTime', 'Class_ID', 'Start_Week', 'End_Week') VALUES(@type, @room,@start_time,@end_time,@class_ID,@start,@end)";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@room", room);
            myCommand.Parameters.AddWithValue("@start_time", start_time);
            myCommand.Parameters.AddWithValue("@end_time", end_time);
            myCommand.Parameters.AddWithValue("@start", start);
            myCommand.Parameters.AddWithValue("@end", end);
            myCommand.Parameters.AddWithValue("@class_ID", class_ID);
            var result = myCommand.ExecuteNonQuery();

            db.CloseConnection();



        }

        public static void insertNA(int type, string room, string start_time, string end_time,int start,int end)
        {
            Database db = new Database();
            string query = "INSERT INTO Time ('Type', 'Room', 'StartTime', 'EndTime', 'Start_Week', 'End_Week') VALUES(@type, @room,@start_time,@end_time,@start,@end)";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@room", room);
            myCommand.Parameters.AddWithValue("@start_time", start_time);
            myCommand.Parameters.AddWithValue("@end_time", end_time);
            myCommand.Parameters.AddWithValue("@start", start);
            myCommand.Parameters.AddWithValue("@end", end);
            var result = myCommand.ExecuteNonQuery();

            db.CloseConnection();



        }

        public static void UpdateTime(int id, int type, string room, string start_time, string end_time)
        {
            Database db = new Database();
            string query = "UPDATE Time SET type = @type, room = @room, StartTime = @start_time,EndTime = @end_time,  WHERE id = @ID ";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", type);
            myCommand.Parameters.AddWithValue("@type", type);
            myCommand.Parameters.AddWithValue("@room", room);
            myCommand.Parameters.AddWithValue("@start_time", start_time);
            myCommand.Parameters.AddWithValue("@end_time", end_time);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();



        }

        public static void deleteTime(int ID)
        {
            Database db = new Database();

            string query = "DELETE FROM Time WHERE ID = @ID";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            myCommand.Parameters.AddWithValue("@ID", ID);
            var result = myCommand.ExecuteNonQuery();
            db.CloseConnection();
        }

        public static bool isEmpty()
        {
            Database db = new Database();
            int count = 0;
            string query = "SELECT COUNT(*) FROM Time Where Type = 1";
            db.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                     count = Convert.ToInt32(result["COUNT(*)"]);
                }
            }
            db.CloseConnection();
            if (count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void deleteTimeCascade()
        {
            Database db = new Database();

            db.OpenConnection();
            db.CloseConnection();
        }
    }
}
