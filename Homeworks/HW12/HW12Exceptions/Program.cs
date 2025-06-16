// Chica Gomes
// HW12Exceptions Done
//
// Description: Create a user-defined exception and demonstrate throwing the exception.
//
using System;

namespace HW12Exceptions
{
    // custom exception for scoring really high
    public class TooSmartException : Exception
    {
        public TooSmartException(string message) : base(message) { }
    }

    public class HW12Exceptions
    {
        public static void Main()
        {
            int score;

            Console.Write("Enter your final exam score (0–100): ");
            bool valid = int.TryParse(Console.ReadLine(), out score);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            try
            {
                CheckFinalScore(score);
            }
            catch (TooSmartException e)
            {
                Console.WriteLine("Caught TooSmartException:");
                Console.WriteLine($"  {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finished checking your score.");
            }
        }

        // throws TooSmartException if score is over 99
        private static void CheckFinalScore(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }

            if (score > 89)
            {
                throw new TooSmartException($"You got a {score}? You are too smart! Go take a nap.");
            }

            Console.WriteLine($"You got a {score}. Good effort!");
        }
    }
}