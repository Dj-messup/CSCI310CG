﻿//Chica Gomes
//HW1 Done
//
//Description: All of your code should be in the namespace and class HW1Types.
//Inside of Main, create at least 4 different variables of different types (example: int, decimal, string, char)
//and set them to some value. Print out the values with a description (using string interpolation).
// Then change the values to something different and print out the values again.
// Next calculate the area of a triangle using Heron's formula.
// You can choose the values for the triangle or you can use ReadLine and Parse
// (covered in day 4 content) to prompt for the sides of an arbitrary triangle.
// To access square root or power, look at the Math class
// (it's automatically available and all you'll have to do is Math.Sqrt(42) for example).
//

using System;

namespace HW1Types
{
    public class HW1Types
    {
        static void Main(string[]args)
        {
            // create int,dec,string,char
            int islandCount = 137; // Total Hawaiian islands according to google
            decimal locoMocoPrice = 10.00m; //If no m then considered a double. Didn't know if good for assign.
            string homeBase = "Oʻahu";
            char placeInitial = 'O';

            Console.WriteLine($"There's {islandCount} islands in Hawai'i in general."); //use WriteLine for.
            Console.WriteLine($"A loco moco usually costs around ${locoMocoPrice}."); //new line
            Console.WriteLine($"I was born on and raised on the island of {homeBase}.");
            Console.WriteLine($"The first initial of my island is {placeInitial}.");

            // Change all 
            islandCount = 8; // Switch to main islands
            locoMocoPrice = 9.50m; //need m for literal. ran into issues treating it like a double 
            homeBase = "Colorado";
            placeInitial = 'C'; //change for sake of assignment
            
            Console.WriteLine($"\nBut, there is only {islandCount} main islands.");//add space and design
            Console.WriteLine($"I found a loco moco for ${locoMocoPrice} once.");
            Console.WriteLine($"I’m now staying in {homeBase} unfortunately.");
            Console.WriteLine($"The first initial of Colorado is {placeInitial}.");
            
            //calculate the area of a triangle using herons
            Console.WriteLine("lets calculate the area of a triangle using heron's formula.");
            double a = 3.0;
            double b = 4.0;
            double c = 5.0; // right triangle values

            // Compute half perimeter
            double s = (a + b + c) / 2;
            
            // Heron's formula
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("\nUsing sides a=3, b=4, c=5:");//add readabily/clarity w/new line
            Console.WriteLine($"and knowing half of the perimeter is = {s}");
            Console.WriteLine("\narea = square root of (s (s−a)(s−b)(s−c))");
            Console.WriteLine($"The area of the triangle is {area}");
            //some of these seem like a lot of fluff of words, but they are descriptions soooo 
        }
    }
}
