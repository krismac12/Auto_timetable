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
            List<Subject> subjects = SubjectAccess.getSubjects();
            List<Class> classes = ClassAccess.getClasses(subjects);
            foreach(Class @class in classes)
            {
                List<Time> times = TimeAcess.getTimes(classes, @class.ID);
            }

            List<Time> NA = TimeAcess.getNA();
            Generator g = new Generator(classes,NA);
            g.generateTimetables(20);
            foreach (Timetable table in g.timetables)
            {
                table.pTable();
            }

            NA[0].overlap(TimeAcess.getTimes(classes,7)[0]);

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
