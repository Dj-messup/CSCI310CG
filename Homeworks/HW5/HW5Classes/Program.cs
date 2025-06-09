// Chica Gomes – HW5 finished

using System;

public class StudentProfile
{
    //private setters
    public string Name { get; private set; }
    public int Age     { get; private set; }

    // Constructor
    public StudentProfile(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    //clener
    public void UpdateName(string newName) => Name = newName;

    public void UpdateAge(int newAge)
    {
        if (newAge > 0) Age = newAge;
    }

    // Action – quick cute lil intro
    public void Introduce()
    {
        Console.WriteLine($"Aloha! I’m {Name}, a {Age}-year-old Computer Science major from Hawai‘i.");
    }

    // Action, show full profile block
    public void ShowProfile()
    {
        Console.WriteLine("——— Student Profile ———");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object me
        var chica = new StudentProfile("Chica", 21);
        chica.Introduce();
        chica.ShowProfile();

        // Object classmate
        var noah = new StudentProfile("Noah", 23);
        noah.Introduce();

        // Tweak classmate then display again
        noah.UpdateName("Noah K.");
        noah.UpdateAge(24);
        Console.WriteLine("Updated info:");
        noah.ShowProfile();
    }
}