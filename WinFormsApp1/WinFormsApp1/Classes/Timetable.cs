using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Timetable

{
	public List<Time> times = new List<Time>();
	public List<string> timeString = new List<string>();
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

	public bool ConstraintConflict(Time time, int hours)
	{
		if (times.Count > 0)
		{
			foreach (Time t in times)
			{
				if (time.start <= t.end.AddHours(hours) && time.start <= t.end)
				{
					return true;
				}

				if (time.end >= t.start.AddHours(-hours) && time.end >= t.end)
				{
					return true;
				}
			}
		}
		return false;
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
			if (t.type == 1)
			{
				System.Diagnostics.Debug.WriteLine(t.@class.subject.name + " " + t.@class.name + " " + t.start.DayOfWeek + " " + t.start.TimeOfDay + "-" + t.end.TimeOfDay);

			}
			else
			{

				System.Diagnostics.Debug.WriteLine(t.room + " " + t.start.DayOfWeek + " " + t.start.TimeOfDay + "-" + t.end.TimeOfDay);

			}
		}
			System.Diagnostics.Debug.WriteLine("NEW Timetable");

	}

	public void addStrings()
    {
		foreach(Time time in times)
        {
			timeString.Add(time.Display());
        }
    }

}
