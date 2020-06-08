using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SchoolPractice  //make sure its the same damn namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            Student dan = new Student("Dan", 1, 1, 4.0);



            Console.WriteLine($"The student class works... {dan.Name} is a student");
            dan.AddGrade(5, 3.5);
            dan.AddGrade(45, 2.0);
            Console.WriteLine(dan.StudentInfo());


            //Console.WriteLine(dan.NumberOfCredits);
            //Console.WriteLine(dan.Gpa);
            
           // Console.WriteLine(dan.GetGradeLevel());
            Console.WriteLine(dan.ToString());






            //var students = new List<Student>();

            //var adding = true;

            //while (adding)
            //{
            //    var newStudent = new Student("Dan", 1, 1, 4.0); //console.wrightline for newStudent.Name etc...

            //    Console.Write("Student Name: ");
            //    newStudent.Name = Console.ReadLine();

            //    Console.Write("Student ID: ");
            //    newStudent.StudentId = int.Parse(Console.ReadLine());

            //    Console.Write("Student Credits: ");
            //    newStudent.NumberOfCredits = int.Parse(Console.ReadLine());

            //    Console.Write("Student GPA: ");
            //    newStudent.Gpa = double.Parse(Console.ReadLine());


            //    students.Add(newStudent);
            //    Student.Count++;
            //    Console.WriteLine();

            //    Console.WriteLine("Add another? y/n");

            //    if (Console.ReadLine() != "y")
            //    {
            //        adding = false;

            //        Console.WriteLine("Please add a teacher");

            //    }



            //    foreach (var student in students)
            //    {
            //        Console.WriteLine("Name: {0}, ID: {1}", student.Name, student.StudentId);
            //    }
            }
        }
    }

