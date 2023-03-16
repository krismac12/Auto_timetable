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
		public List<Time> constraints = TimeAcess.getConstraints();

		public Generator(List<Class> classes,List<Time> times)
		{
			NA = times;

			classes = classes.OrderBy(x => x.times.Count).ToList();
			this.classes = classes;

		}

		public void generateTimetables(int count)
		{
			int num = 0;
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
						if(classes.Count >= 1)
                        {
							foreach (Class @class in classes)
							{
								if (@class != classes[i])
								{
									@class.randomize();
									foreach (Time time in @class.times)
									{
										if (!timetable.Conflicts(time))
										{
											bool overlap = false;
											foreach(Time constraint in constraints)
											{
												if (time.overlap(constraint))
												{
													overlap = true;
													if (timetable.ConstraintConflict(time, constraint.hours))
													{
														timetable.AddTime(time);
													}
												}
											}
											if(overlap == false)
											{
												timetable.AddTime(time);
												break;
											}
											timetable.AddTime(time);
											break;
										}
									}
								}
							}
						}
						num++;
						if(timetable.times.Count == NA.Count + classes.Count)
                        {
							if(timetables.Count == 0)
							{
								timetable.addStrings();
								timetables.Add(timetable);
							}
							else if(timetables[timetables.Count - 1].times == timetable.times)
							{

							}
							else
							{
								timetable.addStrings();
								timetables.Add(timetable);
							}
						}
						if (timetables.Count >= count)
						{
							return;
						}

					}
				}
			randomize();
			timetables = timetables.Distinct().ToList();

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