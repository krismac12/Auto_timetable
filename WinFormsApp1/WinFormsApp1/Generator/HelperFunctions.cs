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

            SqliteDataAccess.insertSubject("subject the fourth", "banana");

            List<Subject> subjects = SqliteDataAccess.getSubjects();

            foreach(Subject subject in subjects)
            {
                System.Diagnostics.Debug.WriteLine(subject.name);
            }


            SqliteDataAccess.insertSubject("subject the fourth","banana");

            //System.Diagnostics.Debug.WriteLine(conflict);

            //Generator g = new Generator(classes);

            //g.generateTimetables(10);
        }

        public static Time createTime(DateTime start, Class @class)
        {
            DateTime end = start.AddHours(2);

            return new Time("room", start, end, @class);
        }
    }
}
