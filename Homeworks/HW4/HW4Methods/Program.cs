// Chica Gomes
// HW4 in progress 
//
// Inside the class, add:
//  • a void that prints text based on parameters
//  • a method that returns data to Main for printing
//  • a method that swaps two values with ref
//  • a method that finds the nth Fibonacci number and returns it
//  • a method that checks if a number is prime and prints the result

using System;

// an ode to my stepdad because I don't have a real one and I figured he would like me writing about him 

namespace HW4Methods
{
    public class HW4Methods
    {
        // 1. Void method that outputs text based on parameters
        public void PrintEngineerIntro(string name, int yearsExperience)
        {
            Console.WriteLine(
                $"Meet {name}, a civil engineer with {yearsExperience} years of experience, " +
                "living the RV life after years of travelling and fascinated by the Fibonacci sequence!" //IGNORE PROFF:change this in personal repo to show on fathers day 
            );
        }

        // 2. Method that returns data to be printed in Main
        public string GetRVStatus(string location)
        {
            return $"Currently parked near {location}, sketching bridge designs and pondering Fibonacci patterns in nature!";
        } // IGNORE PROFF: add writeline for homie being a great guy visiting me in GJ - in personal repo 

        // 3. Method that swaps two blueprint IDs (alphanumeric) #tidyyyyyy
        public void SwapBlueprintIDs(ref string blueprintA, ref string blueprintB)
        {
            string temp = blueprintA;
            blueprintA = blueprintB;
            blueprintB = temp;
            // IGNORE PROFF: this could be changed to instead of blueprint but phrases when i first met em to now on personal repo
        }

        // 4. Method to find the nth Fibonacci number (iterative) and return it as a long
        public long CalculateFibonacci(int n)
        {
            if (n <= 1) return n;

            long a = 0;
            long b = 1;
            long result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }

        // 5. Method to determine if a number is prime
        public bool IsPrimeProjectCode(int code)
        {
            if (code <= 1) return false;

            int limit = (int)Math.Sqrt(code);
            for (int i = 2; i <= limit; i++)
            {
                if (code % i == 0) return false;
            }

            return true;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            HW4Methods engineer = new HW4Methods();

            // //Print engineer intro for Uncle John
            // engineer.PrintEngineerIntro("Uncle John", 30);
            //
            // //Get RV status
            // string status = engineer.GetRVStatus("Salt Lake City, Utah");
            // Console.WriteLine(status);
            //
            // //Swap blueprint IDs
            // string blueprint1 = "CP1950";
            // string blueprint2 = "CP2025";
            // // instance to swap
            // Console.WriteLine($"Before swap: Blueprint A = {blueprint1}, Blueprint B = {blueprint2}");
            // engineer.SwapBlueprintIDs(ref blueprint1, ref blueprint2);
            // Console.WriteLine($"After swap: Blueprint A = {blueprint1}, Blueprint B = {blueprint2}");
            //
            // //Fibonacci calculation for n = 57 (birth year ode)
            // int n = 57; 
            // long fibNumber = engineer.CalculateFibonacci(n);
            // Console.WriteLine($"The {n}th Fibonacci number is {fibNumber}");
            //
            // // Prime check
            // int projectCode = 57; 
            // bool isPrime = engineer.IsPrimeProjectCode(projectCode);
            Console.WriteLine($"Project code is {name} {projectCode} is {(isPrime ? "a prime number" : "not a prime number")}");
        }
    }
}
```
