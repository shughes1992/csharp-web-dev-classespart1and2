using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolPractice
{
    internal class Course


    {
        public string Name { get; set; }

        public string ProfessorName { get; set; }

        public List<Student> StudentRoster { get; set; }



//constructor ! NEEDED , if not created- it will be an empty one

        public Course(string name, string professorName, List<Student> studentRoster )
        {
            Name = name;
            ProfessorName = professorName;
            StudentRoster = studentRoster;
        }
    }
}


