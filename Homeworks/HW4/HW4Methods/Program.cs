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
    // Entry point first, per teacher request
    public class Program
    {
        static void Main(string[] args)
        {
            // test values
            string engineerName = "Uncle John";
            int yearsExperience = 30;
            string location = "Salt Lake City, Utah";
            int x = 42;
            int y = 73;
            int n = 57;         // Fibonacci index and project code

            HW4Methods engineer = new HW4Methods();

            // 1. void that prints text
            engineer.PrintEngineerIntro(engineerName, yearsExperience);

            // 2. method that returns data
            Console.WriteLine(engineer.GetRVStatus(location));

            // 3. swap two numbers by reference
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            
            engineer.SwapTwoNumbers(ref x, ref y);
            
            Console.WriteLine($"After  swap: x = {x}, y = {y}");

            // 4. nth Fibonacci
            long fib = engineer.CalculateFibonacci(n);
            
            Console.WriteLine($"Fibonacci({n}) = {fib}");

            // 5. prime test
            bool prime = engineer.IsPrime(n);
            
            Console.WriteLine($"{n} is {(prime ? "prime" : "not prime")}");
        }
    }

    
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
}