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
        Class c = new Class("class1", s);
        Class c2 = new Class("class2", s);
        Class c3 = new Class("class3", s);
        Class c4 = new Class("class4", s);

        List<Class> classes = new List<Class>();

        DateTime d1 = new DateTime(2015, 12, 30, 5, 0, 0);
        DateTime d2 = new DateTime(2015, 12, 30, 7, 0, 0);
        DateTime d3 = new DateTime(2015, 12, 30, 9, 0, 0);
        DateTime d4 = new DateTime(2015, 12, 30, 11, 0, 0);
        DateTime d5 = new DateTime(2015, 12, 31, 6, 0, 0);
        DateTime d6 = new DateTime(2015, 12, 31, 7, 0, 0);
        DateTime d7 = new DateTime(2015, 12, 31, 8, 0, 0);
        DateTime d8 = new DateTime(2015, 12, 31, 9, 0, 0);
        DateTime d9 = new DateTime(2015, 12, 31, 10, 0, 0);
        DateTime d10 = new DateTime(2015, 12, 31, 11, 0, 0);

        Time time1 = createTime(d1, c);
        Time time2 = createTime(d2, c);
        Time time3 = createTime(d3, c);
        Time time4 = createTime(d4, c);
        Time time5 = createTime(d5, c);
        Time time6 = createTime(d6, c);
        Time time7 = createTime(d7, c);
        Time time8 = createTime(d8, c);
        Time time9 = createTime(d9,c);
        Time time10 = createTime(d10, c);

        Time time11 = createTime(d1, c2);
        Time time12 = createTime(d2, c2);
        Time time13 = createTime(d3, c2);
        Time time14 = createTime(d4, c2);
        Time time15 = createTime(d5, c2);
        Time time16 = createTime(d6, c2);
        Time time17 = createTime(d7, c2);
        Time time18 = createTime(d8, c2);
        Time time19 = createTime(d9, c2);
        Time time20 = createTime(d10, c2);

        Time time21 = createTime(d1, c3);
        Time time22 = createTime(d2, c3);
        Time time23 = createTime(d3, c3);
        Time time24 = createTime(d4, c3);
        Time time25 = createTime(d5, c3);
        Time time26 = createTime(d6, c3);
        Time time27 = createTime(d7, c3);
        Time time28 = createTime(d8, c3);
        Time time29 = createTime(d9, c3);
        Time time30 = createTime(d10, c3);

        Time time31 = createTime(d1, c4);
        Time time32 = createTime(d2, c4);
        Time time33 = createTime(d3, c4);
        Time time34 = createTime(d4, c4);
        Time time35 = createTime(d5, c4);
        Time time36 = createTime(d6, c4);
        Time time37 = createTime(d7, c4);
        Time time38 = createTime(d8, c4);
        Time time39 = createTime(d9, c4);
        Time time40 = createTime(d10, c4);

        List<Time> times = new List<Time>();
        times.Add(time1);
        times.Add(time2);
        times.Add(time3);
        times.Add(time4);
        times.Add(time5);
        times.Add(time6);
        times.Add(time7);
        times.Add(time8);
        times.Add(time9);
        times.Add(time10);

        times.Add(time11);
        times.Add(time12);
        times.Add(time13);
        times.Add(time14);
        times.Add(time15);
        times.Add(time16);
        times.Add(time17);
        times.Add(time18);
        times.Add(time19);
        times.Add(time20);

        times.Add(time21);
        times.Add(time22);
        times.Add(time23);
        times.Add(time24);
        times.Add(time25);
        times.Add(time26);
        times.Add(time27);
        times.Add(time28);
        times.Add(time29);
        times.Add(time30);

        times.Add(time31);
        times.Add(time32);
        times.Add(time33);
        times.Add(time34);
        times.Add(time35);
        times.Add(time36);
        times.Add(time37);
        times.Add(time38);
        times.Add(time39);
        times.Add(time40);

        c.AddTime(time1);
        c.AddTime(time2);
        c.AddTime(time3);
        c.AddTime(time4);
        c.AddTime(time5);
        c.AddTime(time6);
        c.AddTime(time7);
        c.AddTime(time8);
        c.AddTime(time9);
        c.AddTime(time10);

        c2.AddTime(time11);
        c2.AddTime(time12);
        c2.AddTime(time13);
        c2.AddTime(time14);
        c2.AddTime(time15);
        c2.AddTime(time16);
        c2.AddTime(time17);
        c2.AddTime(time18);
        c2.AddTime(time19);
        c2.AddTime(time20);

        c3.AddTime(time21);
        c3.AddTime(time22);
        c3.AddTime(time23);
        c3.AddTime(time24);
        c3.AddTime(time25);
        c3.AddTime(time26);
        c3.AddTime(time27);
        c3.AddTime(time28);
        c3.AddTime(time29);
        c3.AddTime(time30);

        c4.AddTime(time31);
        c4.AddTime(time32);
        c4.AddTime(time33);
        c4.AddTime(time34);
        c4.AddTime(time35);
        c4.AddTime(time36);
        c4.AddTime(time37);
        c4.AddTime(time38);
        c4.AddTime(time39);
        c4.AddTime(time40);

        classes.Add(c);
        classes.Add(c2);
        classes.Add(c3);
        classes.Add(c4);
        c.randomize();



        //System.Diagnostics.Debug.WriteLine(conflict);

        Generator g = new Generator(classes);

        g.generateTimetables(10);
        foreach(Timetable timeable in g.timetables)
        {
            System.Diagnostics.Debug.WriteLine("new timetable");
            timeable.pTable();
        }
    }

    public static Time createTime(DateTime start,Class @class)
    {
        DateTime end = start.AddHours(2);

        return new Time("room", start, end, @class);
    }
}
