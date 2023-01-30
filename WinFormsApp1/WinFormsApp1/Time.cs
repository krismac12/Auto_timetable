using System;

public class Time
{
	public string room;
	public Class timeClass;
	public DateTime start;
	public DateTime end;
	public Time(string room, DateTime start,DateTime end,Class timeClass)
	{
		this.room = room;
		this.timeClass = timeClass;
		this.start = start;
		this.end = end;
	}

	public bool overlap(Time newTime)
    {
		bool overlap = start < newTime.end && end > newTime.start;
		return overlap;
	}
}
