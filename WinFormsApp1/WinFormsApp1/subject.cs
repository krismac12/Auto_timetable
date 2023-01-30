using System;
using System.Collections;
using System.Collections.Generic;

public class Subject
{	
	public string name;
	public string code;
	public List<Class> classes = new List<Class>();

	public Subject(string name,string code)
	{
		this.name = name;
		this.code = code;
	}

	public void AddClass(Class @class)
	{
		this.classes.Add(@class);
	}
}
