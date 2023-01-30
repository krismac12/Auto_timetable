using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Generator
{
	public List<Class> classes = new List<Class>();
	public List<Timetable> timetables = new List<Timetable>();
	public Generator(List<Class> classes)
	{
		this.classes = classes;
	}

	public void generateTimetables(int count)
    {
		int timeCount = 0;
		for(int i = 0; i < classes.Count;i++)
        {
			timeCount += classes[i].times.Count;
			for(int x = 0; x < classes[i].times.Count; x++)
            {
				List<Time> times = new List<Time>();
				times.Add(classes[i].times[x]);

				foreach(Class @class in classes)
                {
					if(@class != classes[i])
                    {
						@class.randomize();
						times.Add(@class.times[0]);
					}
                }
				Timetable timetable = new Timetable(times);
				timetables.Add(timetable);

			}
        }
    }
}
