// Chica Gomes – HW4
using System;

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
        // 1. void that prints text based on parameters
        public void PrintEngineerIntro(string name, int yearsExperience)
        {
            Console.WriteLine($"Meet {name}, a civil engineer with {yearsExperience} years of experience and an RV lifestyle.");
        }

        // 2. returns a string to caller
        public string GetRVStatus(string location)
        {
            return $"Currently parked near {location}, sketching bridge designs.";
        }

        // 3. swaps two ints by reference
        public void SwapTwoNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Fibonacci
        public long CalculateFibonacci(int n)
        {
            if (n <= 1) return n;
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long next = a + b;
                a = b;
                b = next;
            }
            return b;
        }

        // 5. prime check
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            int limit = (int)Math.Sqrt(number);
            for (int i = 2; i <= limit; i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}