﻿using System;
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
