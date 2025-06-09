// Chica Gomes
// HW6 done 
//
//description: Create a class for People that contains a name along with a
//corresponding get/set (using automatic properties). Create 2 derived classes
//which inherit from People and each class should have their own method.
//Demonstrate creating objects from each class and setting the name along with calling
//the method you created for that class.
// 

using System;

namespace HW6Inheritance
{
    public class UniversityDemo   //can always change
    {
        public static void Main()
        {
            var student = new Student { Name = "Chica" };
            student.Study();

            var prof = new Professor { Name = "Professor Alayami" }; //yuh cisb
            prof.Teach();
        }
        
    }

        
    // Base class
    public class People
    {
        public string Name { get; set; } = string.Empty; // had a warning, Non-nullable property
    }

    // some phrase
    public class Student : People
    { 
        public void Study()
        {
            Console.WriteLine($"{Name} is studying hard for the exams."); // not like I have three jobs
        }
    }

    // another phrase
    public class Professor : People
    {
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching a fascinating lesson.");
        }
    }
}
