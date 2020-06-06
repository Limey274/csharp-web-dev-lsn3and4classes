using System;
using System.Collections.Generic;
// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        static public int Count = 0;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits{ get; set; }
        public double Gpa { get; set; }



    public Student(string name, int studentid, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentid;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }


    }
}



