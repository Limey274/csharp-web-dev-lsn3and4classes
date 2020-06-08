using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student //getting and setting name, studentid, numOfCredits, & GPA. Get will return the value, set will assign a value to the "get" value 
    {
        static public int Count = 0;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits{ get; set; }
        public double Gpa { get; set; }

        

    public Student(string name, int studentId, int numberOfCredits, double gpa) //every student created will have a name, id, credit number, and gpa associated. This constructor makes the program recognize the values
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
           
        }
        public Student(string name, int studentId)// the name and id are associated with the default value of 0 credits and 0.0 gpa. *This is a UNIQUE value to the class*
        {
            Name = name;
           StudentId = studentId;
            NumberOfCredits = 0;
            Gpa = 0.0;
            
        }

        public Student(string name) // every new student name will make the "Count" go up one. *This is a UNIQUE value to the class*
        {
            Name = name;
            StudentId = Count;
            Count++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo(string Name, double Gpa) 
        {

            return Name + " has a GPA of: " + Gpa;
        }

        public void AddGrade(int courseCredits, double grade)
        {

            double quality = Gpa * NumberOfCredits;
            double courseQuality = courseCredits * grade;

            NumberOfCredits += courseCredits;
            double totalQuality = (quality + courseQuality) / NumberOfCredits;
            
            Gpa = totalQuality;
        }

        public string GetGradeLevel()
        {

            if (this.NumberOfCredits < 30)
            {
                return "Freshman";

            }
            else if (this.NumberOfCredits < 60)
            {
                return "Sophomore";

            }
            else if (this.NumberOfCredits < 90)

            {
                return "Junior";

            }
            else
            {
                return  "Senior";
            }

        }

        
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }
    }
}



