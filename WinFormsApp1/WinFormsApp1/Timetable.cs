using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Timetable

{
	public List<Time> times = new List<Time>();
	public Timetable(List<Time> times)
	{
		this.times = times.OrderBy(o => o.start).ToList();
	}
}
