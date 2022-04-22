using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolPractice
{
    public class Course


    {
        public string CourseName { get; set; }

        public string ProfessorName { get; set; }

        public List<Student> StudentRoster { get; set; }





//constructor ! NEEDED , if not created- it will be an empty one

        public Course(string name, string professorName, List<Student> studentRoster )
        {
            CourseName = CourseName;
            ProfessorName = professorName;
            StudentRoster = studentRoster;
        }
    }
}


