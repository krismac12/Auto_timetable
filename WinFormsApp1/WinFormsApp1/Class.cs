﻿using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class Class
{
	public string name;
	public Subject subject;
	public List<Time> times = new List<Time>();
	private static Random rng;

	public Class(string name, Subject subject)
	{
		this.name = name;
		this.subject = subject;
	}

	public void AddTime(Time time)
    {
		this.times.Add(time);
    }

	public void randomize()
    {
		if(times.Count != 0)
        {
			rng = new Random();
			times = times.OrderBy(a => rng.Next()).ToList();
		}
	}


}
