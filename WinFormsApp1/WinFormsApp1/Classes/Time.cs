using System;

public class Time
{
	public int ID;
	public int type;
	public string room;
	public Class @class;
	public DateTime start;
	public DateTime end;
	public Time(int id ,string room,int type, DateTime start,DateTime end,Class @class)
	{
		this.ID = id;
		this.room = room;
		this.type = type;
		this.@class = @class;
		this.start = nextDayofWeek(start);
		this.end = nextDayofWeek(end);

		@class.AddTime(this);
	}

	public Time(int id, string room, int type, DateTime start, DateTime end)
	{
		this.ID = id;
		this.room = room;
		this.type = type;
		this.start = nextDayofWeek(start);
		this.end = nextDayofWeek(end);
	}

	public bool overlap(Time newTime)
    {
		bool overlap = start < newTime.end && end > newTime.start;
		return overlap;
	}

	public DateTime nextDayofWeek(DateTime date)
    {
		var today = DateTime.Today;
		var start = today.StartOfWeek(DayOfWeek.Sunday);
		var nextDay = start.AddDays((int)date.DayOfWeek).AddHours(date.Hour).AddMinutes(date.Minute);
		return nextDay;
	}
}

public static class DateTimeExtensions
{
	public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
	{
		int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
		return dt.AddDays(-1 * diff).Date;
	}
}