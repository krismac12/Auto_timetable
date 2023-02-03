using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Timetable

{
	public List<Time> times = new List<Time>();
	public Timetable()
	{

	}

	public bool Conflicts(Time time)
	{
		bool conflict = true;
		if(times.Count > 0)
        {
			foreach (Time t in times)
			{
				if (t.overlap(time))
				{
					conflict = true;
					return conflict;
				}
				else
				{
					conflict = false;
				}
			}
		}
        else
        {
			conflict = false;
        }
		return conflict;
	}
	public void AddTime(Time time)
	{
		this.times.Add(time);
		this.times = this.times.OrderBy(o => o.start).ToList();
	}

	public void AddTime(List<Time> times)
	{
		this.times = times.OrderBy(o => o.start).ToList();
	}

	public void pTable()
    {
            foreach (Time t in times)
            {
                System.Diagnostics.Debug.WriteLine(t.timeClass.subject.name + " " + t.timeClass.name+" "+t.start.DayOfWeek + " "+t.start.TimeOfDay + "-" + t.end.TimeOfDay);
            }
    }

}
