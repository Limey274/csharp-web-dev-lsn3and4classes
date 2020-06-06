using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        

            public string Topic;
            public List<Student> Roster;
            public string Subject;
          



            public Course(string topic, List<Student> roster, string subject)
            {
                Topic = topic;

                Roster = roster ;

                Subject = subject;
                           
            }

        }
    }

