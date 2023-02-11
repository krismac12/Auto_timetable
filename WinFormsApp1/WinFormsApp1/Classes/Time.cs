using System;

public class Time
{
	public int ID;
	public int type;
	public string room;
	public Class @class;
	public DateTime start;
	public DateTime end;
	public int start_week;
	public int end_week;
	public Time(int id ,string room,int type, DateTime start,DateTime end,Class @class,int start_week,int end_week)
	{
		this.ID = id;
		this.room = room;
		this.type = type;
		this.@class = @class;
		this.start = nextDayofWeek(start);
		this.end = nextDayofWeek(end);
		this.start_week = start_week;
		this.end_week = end_week;

		@class.AddTime(this);
	}

	public Time(int id, string room, int type, DateTime start, DateTime end, int start_week, int end_week)
	{
		this.ID = id;
		this.room = room;
		this.type = type;
		this.start = nextDayofWeek(start);
		this.end = nextDayofWeek(end);
		this.start_week = start_week;
		this.end_week = end_week;
	}

	public bool overlap(Time newTime)
    {
		bool overlap = true;
		bool overlapTime = true;
		bool overlapWeek = true;
		if (start < newTime.start)
        {
			overlapTime = end > newTime.start;
        }
        else
        {
			overlapTime = start < newTime.end;
        }

		if (start_week < newTime.start_week)
		{
			overlapWeek = end_week > newTime.start_week;
		}
		else
		{
			overlapWeek = start_week < newTime.end_week;
		}

		if(overlapWeek && overlapTime)
        {
			overlap = true;
        }
        else
        {
			overlap = false;
        }
		return overlap;
	}

	public DateTime nextDayofWeek(DateTime date)
    {
		var today = DateTime.Today;
		var start = today.StartOfWeek(DayOfWeek.Sunday);
		var nextDay = start.AddDays((int)date.DayOfWeek).AddHours(date.Hour).AddMinutes(date.Minute);
		return nextDay;
	}

	public override string ToString()
	{
			return this.room +": "+this.start.DayOfWeek.ToString() + " " + string.Format("{0:hh:mm tt}", start) + " - " + string.Format("{0:hh:mm:ss tt}", end) + " Weeks: " + start_week + " - "+ end_week;
	}



	public string Display()
    {
		if(type == 1)
        {
			return @class.subject.code + " \r\n" +
				@class.subject.name + " \r\n" +
				"Class: " + @class.name + " \r\n" +
				"Room: " + room + " \r\n" +
				"Weeks: " + start_week + " - " + end_week + " \r\n" +
				"Time: " + " \r\n" +
				string.Format("{0:hh:mm tt}", start) +" - "+ string.Format("{0:hh:mm tt}", end) + "\r\n";


		}
        else
        {
			return
				"Type: " + room + " \r\n" +
				"Time: " + " \r\n" +
				string.Format("{0:hh:mm tt}", start) + " - " + string.Format("{0:hh:mm tt}", end) + "\r\n";
		}
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