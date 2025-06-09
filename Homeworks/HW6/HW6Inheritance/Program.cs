// Chica Gomes – HW6

using System;

namespace HW6Inheritance
{
    // Base class
    public class People
    {
        public string Name { get; set; }
    }

    // Derived class #1
    public class Student : People
    {
        public void Study()
        {
            Console.WriteLine($"{Name} is studying hard for the exams.");
        }
    }

    // Derived class #2
    public class Professor : People
    {
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching a fascinating lesson.");
        }
    }
    public class UniversityDemo   // better name than “Program”
    {
        public static void Main()
        {
            var student = new Student { Name = "Chica" };
            student.Study();

            var prof = new Professor { Name = "Professor Alayami" };
            prof.Teach();
        }
    }
}
