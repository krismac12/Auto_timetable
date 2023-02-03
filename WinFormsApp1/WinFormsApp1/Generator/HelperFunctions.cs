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

            foreach(Class @class in classes)
            {
                System.Diagnostics.Debug.WriteLine(@class.name);
            }

            foreach(Subject subject in subjects)
            {
                System.Diagnostics.Debug.WriteLine(subject.name);
                foreach(Class @class in subject.classes)
                {
                    System.Diagnostics.Debug.WriteLine(@class.name);
                }
            }

            SqliteDataAccess.UpdateClass("Class2 New", "Code 2 New",1,3);
            foreach (Class @class in classes)
            {
                System.Diagnostics.Debug.WriteLine(@class.name);
            }

            foreach (Subject subject in subjects)
            {
                System.Diagnostics.Debug.WriteLine(subject.name);
                foreach (Class @class in subject.classes)
                {
                    System.Diagnostics.Debug.WriteLine(@class.name);
                }
            }
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
