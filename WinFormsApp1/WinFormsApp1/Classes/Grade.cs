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

        public Grade(int ID, Subject subject, float grade, string name)
        {
            this.ID = ID;
            this.subject = subject;
            this.grade = grade;
            this.name = name;

            subject.AddGrade(this);
        }

        public override string ToString() 
        {
            return name + ": " + grade;
        }

    }
