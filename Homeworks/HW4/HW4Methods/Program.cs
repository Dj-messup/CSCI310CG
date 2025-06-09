// Chica Gomes
// HW4 Done
//
//Description: You will write several methods inside of your class:
// Create a void which outputs some text based on the parameters.
// Create a method that returns some sort of data back to the call
// and then is printed out from Main.
// Create a method that swaps two numbers via ref.
// Create a method that finds the nth Fibonacci number (you can use a for loop or recursion)
// and then returns that number to be printed out.
// Create a method that determines if a number is prime or not and prints out the result from Main.
// 

using System;

namespace HW4Methods
{
    public class HW4Methods
    {
        public static void Main()   //unused args warning
        {
            string engineerName = "Uncle John";
            int yearsExp = 30;
            string location = "Salt Lake City, Utah";
            int x = 42;
            int y = 73;
            int n = 57;   // Fibonacci + prime

            var engineer = new Hw4Methods();

            //beginning
            engineer.PrintEngineerIntro(engineerName, yearsExp);

            //RV status
            Console.WriteLine(engineer.GetRvStatus(location));

            //swap
            Console.WriteLine($"before swap: x = {x}, y = {y}");
            engineer.SwapTwoNumbers(ref x, ref y);
            Console.WriteLine($"after  swap: x = {x}, y = {y}");

            //fibonacci
            long fib = engineer.CalculateFibonacci(n);
            Console.WriteLine($"Fibonacci({n}) = {fib}");

            //prime
            bool prime = engineer.IsPrime(n);
            Console.WriteLine($"{n} is {(prime ? "prime" : "not prime")}");
        }
    }

    public class Hw4Methods
    {
        // intro
        public void PrintEngineerIntro(string name, int yearsExperience)
        {
            Console.WriteLine($"Meet {name}, a civil engineer with {yearsExperience} years of experience and an RV lifestyle.");
        }

        // rv status
        public string GetRvStatus(string location)
        {
            return $"Currently parked near {location}, sketching bridge designs.";
        }

        // swap two ints
        public void SwapTwoNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // fibonacci
        public long CalculateFibonacci(int n)
        {
            if (n <= 1) return n;

            long a = 0;
            long b = 1;
            for (int i = 2; i <= n; i++)
            {
                long next = a + b;
                a = b;
                b = next;
            }
            return b;
        }

        // prime check
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
