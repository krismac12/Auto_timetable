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