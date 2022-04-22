using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program
// update the starter code to make use of auto-implemented properties.
namespace SchoolPractice
{
    //4 properties below are declaring all students will have all 4 properties

    public class Student
    {
        // means the property can be get and set!
        // "Hey, when you want to access the prop, you can do Student.Name ! or you can set it
        // private property in a claa will only be accessible within this class (in these curly braces!)


        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        //constructor ! NEEDED , if not created- it will be an empty one
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
    }
}


