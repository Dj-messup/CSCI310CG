//Chica Gomes
//HW7 Done
//
//description: Create a base class called Vehicle that has a number of methods
//and variables. Derive that class into two different classes (Car and Truck for example)
//where each one will override at least two of the methods from Vehicle. Create objects in
//Main and demonstrate the classes.
//
    
using System;

namespace HW7Polymorphism
{
    // Demo first so the entry point is easy to find
    public class VehicleDemo
    {
        public static void Main()
        {
            // Car object
            Vehicle myCar = new Car { Make = "Mazda", Model = "CX5", Year = 2018 };
            myCar.Start();
            myCar.Drive();
            myCar.Stop();

            Console.WriteLine(); // spacer

            // dream ride: ’69 Camaro
            Vehicle myTruck = new Truck { Make = "Chevrolet", Model = "Camaro", Year = 1969 };
            myTruck.Start();
            myTruck.Drive();
            myTruck.Stop();
        }
    }

    // Base class
    public class Vehicle
    {
        public string Make  { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int    Year  { get; set; }

        public virtual void Start() => Console.WriteLine("Starting the vehicle…");
        public virtual void Drive() => Console.WriteLine("Driving the vehicle…");
        public virtual void Stop()  => Console.WriteLine("Stopping the vehicle…");
    }

    // class — Car
    public class Car : Vehicle
    {
        public override void Start() => Console.WriteLine($"Starting the car: {Make} {Model} ({Year})");
        public override void Drive() => Console.WriteLine($"Cruising in the car: {Make} {Model}");
        public override void Stop()  => Console.WriteLine($"Parking the car: {Make} {Model}");
    }

    // class — ’69 Camaro (truck)   
    public class Truck : Vehicle
    {
        public override void Start() => Console.WriteLine($"Firing up the {Year} {Make} {Model}");
        public override void Drive() => Console.WriteLine($"Letting the {Model} roar down the highway");
        public override void Stop()  => Console.WriteLine($"Parking the {Make} {Model}");
    }
}
