//Chica Gomes 
//HW5 In progress
//
// description: Create a simple class with at least two private variables (fields) and corresponding get/set for those
// variables. The class should also have a constructor and at least one method in the class that does something.
// Demonstrate your class in Main with at least 2 objects created from the class.

using System;

// quick lil teacher aspect for a nod to when i taught at UH 
public class StudentProfile
{
    // Private fields
    private string name;
    private int age;

    // Constructor
    public StudentProfile(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Getter and Setter for Name
    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    // Getter and Setter for Age
    public int GetAge()
    {
        return age;
    }

    public void SetAge(int newAge)
    {
        if (newAge > 0)
        {
            age = newAge;
        }
    }

    // Method that introduces the student
    public void Introduce()
    {
        Console.WriteLine($"Aloha! I'm {name}, a {age}-year-old Computer Science major from Hawai‘i. I'm still exploring which programming language I like best!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create first student object (Chica!)
        StudentProfile chica = new StudentProfile("Chica", 21);
        chica.Introduce();

        // Create second student object (a classmate)
        StudentProfile classmate = new StudentProfile("Noah", 24);// ask him whats his real age 
        classmate.Introduce();

        // Update Noah's name and age
        classmate.SetName("NoaH K."); //i chose my friend Noah from class 
        classmate.SetAge(24);
        Console.WriteLine("Updated classmate info:");
        classmate.Introduce();
    }
}