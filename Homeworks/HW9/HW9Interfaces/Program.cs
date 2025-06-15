// Chica Gomes
// HW9Interfaces working on 
//
// Description: Create an interface with at least 2 methods.
// Create a class that implements the interface. Demonstrate
// that the class with interface functions as expected.
// for context.. I'm into plants 
//
using System;

namespace HW9Interfaces
{
    public class HW9Interfaces
    {
        public static void Main() // args unused warning
        {
            //modeled after my plant anuhea that I forgot about at work and now its burned
            Succulent aloe = new Succulent();

            // interface reference to call methods
            IPlant plant = aloe;
            plant.Water();
            plant.Photosynthesize();
        }
    }

    // interface with two required methods
    public interface IPlant
    {
        void Water();
        void Photosynthesize();
    }

    // sealed class using iplant interface DEMONSTRATION WORKING!!
    public sealed class Succulent : IPlant
    {
        // explicit interface
        void IPlant.Water()
        {
            Console.WriteLine("Succulent has been watered (lightly, of course).");
        }

        void IPlant.Photosynthesize()
        {
            Console.WriteLine("Succulent is photosynthesizing in the sun... Don't worry.");
        } // does that sound ominous?
    }
}
