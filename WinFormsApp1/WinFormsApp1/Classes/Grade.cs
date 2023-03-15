using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Grade
    {
        public int ID;
        public Subject subject;
        public float grade;
        public string name;
        public float weight;

        public Grade(int ID, Subject subject, float grade, string name,float weight)
        {
            this.ID = ID;
            this.subject = subject;
            this.grade = grade;
            this.name = name;
            this.weight = weight;
            subject.AddGrade(this);
        }

        public override string ToString() 
        {
            return name + ": " + grade;
        }

    }
