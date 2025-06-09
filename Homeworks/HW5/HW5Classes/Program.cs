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

    // Action #1 – quick intro
    public void Introduce()
    {
        Console.WriteLine($"Aloha! I’m {Name}, a {Age}-year-old Computer Science major from Hawai‘i.");
    }

    // Action #2 – show full profile block
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
        // Object #1 – you
        var chica = new StudentProfile("Chica", 21);
        chica.Introduce();
        chica.ShowProfile();

        // Object #2 – classmate
        var noah = new StudentProfile("Noah", 23);
        noah.Introduce();

        // Tweak classmate then display again
        noah.UpdateName("NoaH K.");
        noah.UpdateAge(24);
        Console.WriteLine("Updated info:");
        noah.ShowProfile();
    }
}