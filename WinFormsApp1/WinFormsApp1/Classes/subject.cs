using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public class Subject
{
	public int ID;
	public string name;
	public string code;
	public List<Class> classes = new List<Class>();
	public List<Grade> grades = new List<Grade>();
	float totalWeight = 0;
	float totalGrade = 0;
	float g;
	public Color color;
	private Random rnd = new Random();

	public float Grade;

	public Subject(int ID,string name,string code)
	{
		this.ID = ID;
		this.name = name;
		this.code = code;
		int colorSelect = rnd.Next(0, 2);
		int r = rnd.Next(128);
		int g = rnd.Next(128);
		int b = rnd.Next(128);
        switch (colorSelect)
        {
			case 0:
				r = 220;
				break;

			case 1:
				g = 220;
				break;

			case 2:
				b = 220;
				break;
        }
		color = Color.FromArgb(r,g,b);
	}

	public void AddClass(Class @class)
	{
		this.classes.Add(@class);
	}

	public void AddGrade(Grade grade)
	{
		this.grades.Add(grade);
	}

	public void CalculateGrade()
    {
		float total = 0;
		int number = 0;
		foreach(Grade grade in grades)
        {
			number++;
			total += grade.grade;
        }

		this.Grade = total / number;
    }

	public override string ToString() 
	{
		return this.name;
	}

	public void calculateGrade()
    {

		foreach(Grade grade in grades)
        {
			g = (grade.weight / 100);
			totalGrade += grade.grade * (grade.weight/100);
			totalWeight += grade.weight;
        }

		Grade = totalGrade / (totalWeight / 100);
    }
}
