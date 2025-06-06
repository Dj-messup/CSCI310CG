//Chica Gomes
//HW6 in progress 
//
//Description : Create a class for People that contains a name along with a corresponding get/set
//(using automatic properties). Create 2 derived classes which inherit from People and each class
//should have their own method. Demonstrate creating objects from each class and setting the name
//along with calling the method you created for that class.

using System;

namespace HW6Inheritance
{
    // Base class People
    public class People
    {
        // Automatic property for Name
        public string Name { get; set; }
    }

    // Derived class Student
    public class Student : People
    {
        // Method specific to Student
        public void Study()
        {
            Console.WriteLine($"{Name} is studying hard for the exams!"); // yup totally not working three jobs every school year
        }
    }

    // Derived class Proffessor
    public class Proffessor : People
    {
        // Method specific to Teacher
        public void Proff()
        {
            Console.WriteLine($"{Name} is teaching a fascinating lesson!"); // i do get excited about topics to cover in CISB
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object and set the name
            Student student = new Student();
            student.Name = "Chica";
            student.Study();

            // Create a Teacher object and set the name
            Proffessor Proff = new Proffessor(); // fix this 
            
            Proffessor.Name = "Professor Alayami"; // the goat
            Proffessor.Proff();
        }
    }
}