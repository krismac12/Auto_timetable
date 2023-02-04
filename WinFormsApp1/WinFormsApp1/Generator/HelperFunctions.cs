using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class HelperFunctions
    {

        public static void Test()
        {

            
            
            List<Subject> subjects = SqliteDataAccess.getSubjects();
            List<Class> classes = SqliteDataAccess.getClasses(subjects);
            SqliteDataAccess.insertTime(1, "Room1", DateTime.Now.AddHours(2).ToString(), DateTime.Now.AddHours(4).ToString(), 2);
            SqliteDataAccess.insertTime(1, "Room2", DateTime.Now.AddDays(2).AddHours(2).ToString(), DateTime.Now.AddDays(2).AddHours(4).ToString(), 2);
            SqliteDataAccess.insertTime(1, "Room3", DateTime.Now.AddDays(3).AddHours(2).ToString(), DateTime.Now.AddDays(2).AddHours(4).ToString(), 1);
            List<Time> times = SqliteDataAccess.getTimes(classes,1);


            foreach (Class @class in classes)
            {
                System.Diagnostics.Debug.WriteLine(@class.name);
                foreach(Time t in @class.times)
                {
                    System.Diagnostics.Debug.WriteLine(t.room + "Time:" + t.start.ToString() + t.end.ToString());
                }
            }

            //System.Diagnostics.Debug.WriteLine(conflict);

            //Generator g = new Generator(classes);

            //g.generateTimetables(10);
        }

        public static Time createTime(DateTime start, Class @class)
        {
            DateTime end = start.AddHours(2);

            return new Time(1,"room",1, start, end, @class);
        }
    }
}
