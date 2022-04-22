using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // CLASSES are TYPES of OBJECTS
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            //new below invokes student cronstructor?

            Student student1 = new Student("Sam", 44323, 1, 4.0);
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"ID {student1.StudentId}");
            Console.WriteLine($"# Credits: {student1.NumberOfCredits}");
            Console.WriteLine($"GPA: {student1.Gpa}");

        }
    }
}
