﻿using System;
using System.Collections;
using System.Collections.Generic;

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

	public float Grade;

	public Subject(int ID,string name,string code)
	{
		this.ID = ID;
		this.name = name;
		this.code = code;
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
