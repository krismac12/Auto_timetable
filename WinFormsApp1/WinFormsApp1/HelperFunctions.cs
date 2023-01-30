using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
public class HelperFunctions
{

    public static void Test()
    {
        Subject s = new Subject("hello", "ios its");
        Class c = new Class("name", s);

        DateTime start1 = new DateTime(2019, 12, 30, 5, 0, 0);
        DateTime end1 = new DateTime(2015, 12, 31, 7, 0, 0);
        Time time1 = new Time("room1", start1, end1, c);

        DateTime start2 = new DateTime(2015, 12, 30, 7, 0, 0);
        DateTime end2 = new DateTime(2015, 12, 30, 8, 0, 0);
        Time time2 = new Time("room1", start2, end2, c);

        DateTime start3 = new DateTime(2017, 12, 30, 7, 0, 0);
        DateTime end3 = new DateTime(2018, 12, 30, 8, 0, 0);
        Time time3 = new Time("room1", start3, end3, c);


        List<Time> times = new List<Time>();
        times.Add(time3);
        times.Add(time2);
        times.Add(time1);

        c.AddTime(time3);
        c.AddTime(time2);
        c.AddTime(time1);

        foreach (Time t in c.times)
        {
            System.Diagnostics.Debug.WriteLine(t.start);

        }

        c.randomize();

        foreach (Time t in c.times)
        {
            System.Diagnostics.Debug.WriteLine(t.start);

        }
    }
}
