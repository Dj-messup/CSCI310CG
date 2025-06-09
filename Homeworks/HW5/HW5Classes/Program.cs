// Chica Gomes
// HW5 Done
//
//description: Create a simple class with at least two private variables
//(fields) and corresponding get/set for those variables. The class should
//also have a constructor and at least one method in the class that does something.
//Demonstrate your class in Main with at least 2 objects created from the class.
//

using System;

namespace HW5Classes
{
    public class UniversityDemo
    {
        public static void Main()
        {
            // first student – me
            var chica = new StudentProfile("Chica", 21);
            chica.Introduce("Hawai‘i");   // show hometown
            chica.ShowProfile();

            // second student – classmate
            var noah = new StudentProfile("Noah", 23);
            noah.Introduce();             // no hometown
            Console.WriteLine();

            // tweak classmate info then print again
            noah.UpdateName("Noah K.");
            noah.UpdateAge(24);
            Console.WriteLine("Updated info:");
            noah.ShowProfile();
        }
    }

    //helper
    public class StudentProfile
    {
        //private setters
        public string Name { get; private set; }
        public int    Age  { get; private set; }

        //constructor
        public StudentProfile(string name, int age)
        {
            Name = name;
            Age  = age;
        }

        //setter
        public void UpdateName(string newName) => Name = newName;

        public void UpdateAge(int newAge)
        {
            if (newAge > 0) Age = newAge;  //keep it reasonable
        }

        //quick intro hometown
        public void Introduce(string hometown = null)
        {
            if (string.IsNullOrWhiteSpace(hometown))
                Console.WriteLine($"Hi, I'm {Name}. I'm {Age} and I enjoy coding.");
            else
                Console.WriteLine($"Hi, I'm {Name} from {hometown}. I'm {Age} and I enjoy coding.");
        }

        //full profile
        public void ShowProfile()
        {
            Console.WriteLine("Student Profile");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age:  {Age}");
            Console.WriteLine();
        }
    }
}