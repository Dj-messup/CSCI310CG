//Chica Gomes
//HW7 In Progress
//
// Desciption: Create a base class called Vehicle that has a number of methods and variables.
// Derive that class into two different classes (Car and Truck for example) where each one will
// override at least two of the methods from Vehicle. Create objects in Main and demonstrate the classes.

using System;

namespace HW7Polymorphism
{
    // Base class Vehicle
    public class Vehicle
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Virtual methods to be overridden
        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping the vehicle...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving the vehicle...");
        }
    }

    // Derived class Car
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Make} {Model} ({Year})");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the car: {Make} {Model} ({Year})");
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving the car: {Make} {Model} ({Year})");
        }
    }
    
    //Instance to drive dream car instead place here : 
    
    // Derived class Truck ex)
    public class Truck : Vehicle
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Sparkle
            Vehicle myCar = new Car { Make = "Mazda", Model = "Sport", Year = 2018 }; // ask mom what we drive 
            myCar.Start();
            myCar.Drive();
            myCar.Stop();

            // Create a Truck.. i should change it to dream car #camarro 1969
            Vehicle  = new Truck { Make = "" = , Model = "", Year = };
            .Start();
            .Drive();
            .Stop();
        }
    }
}
