using System;
using System.Collections.Generic;


namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // CLASSES are TYPES of OBJECTS
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            //new below invokes student cronstructor?

            Student student1 = new Student("Ryan", 44323, 98, 4.0);
            Student student5 = new Student("Penelope", 211, 1, 4.0);
            Student student3 = new Student("Johnny", 53, 1, 3.0);

            //Console.WriteLine($"Name: {student1.Name}");
            //Console.WriteLine($"ID {student1.StudentId}");
            //Console.WriteLine($"# Credits: {student1.NumberOfCredits}");
            //Console.WriteLine($"GPA: {student1.Gpa}");

            List<Student> students = new List<Student>();
            students.Add(student3);
            students.Add(student1);
            students.Add(student5);

            Course latin = new Course("Latin 101", "Professor Bourdegard", students);
            Console.WriteLine($"Name: {latin.Name}");
            Console.WriteLine($"Professor: {latin.ProfessorName}");
            Console.WriteLine($"Roster: ");


            foreach (Student student in latin.StudentRoster)
            {
                Console.WriteLine("----------");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"ID {student.StudentId}");
                Console.WriteLine($"# Credits: {student.NumberOfCredits}");
                Console.WriteLine($"GPA: {student.Gpa}");

            }

        }
    }
}
