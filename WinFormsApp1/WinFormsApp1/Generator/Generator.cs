using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


namespace WinFormsApp1
{

	public class Generator
	{
		public List<Class> classes = new List<Class>();
		public List<Timetable> timetables = new List<Timetable>();
		public List<Time> NA = new List<Time>();
		public Generator(List<Class> classes,List<Time> times)
		{
			this.classes = classes;
			NA = times;
		}

		public void generateTimetables(int count)
		{
			while (classes.Count < count)
			{
				for (int i = 0; i < classes.Count; i++)
				{
					for (int x = 0; x < classes[i].times.Count; x++)
					{
						Timetable timetable = new Timetable();
						foreach(Time time in NA)
                        {
							timetable.AddTime(time);
                        }
						if (timetable.Conflicts(classes[i].times[x]))
                        {
							continue;
                        }
                        else
                        {
							timetable.AddTime(classes[i].times[x]);
                        }
						foreach (Class @class in classes)
						{
							if (@class != classes[i])
							{
								@class.randomize();
								foreach (Time time in @class.times)
								{
									if (timetables.Count >= count)
									{
										return;
									}
									if (!timetable.Conflicts(time))
									{
										timetable.AddTime(time);
										break;
									}
								}
							}
						}
						timetables.Add(timetable);

					}
				}
			}
			randomize();

		}
		public void randomize()
		{
			Random rng;
			if (timetables.Count != 0)
			{
				rng = new Random();
				timetables = timetables.OrderBy(a => rng.Next()).ToList();
			}
		}
	}
}