// Chica Gomes
// HW15 In Progress
//
// description: 
//

//using System; // if using older version : 
//using System.Collections.Generic;
//using System.Linq;

namespace HW15Linq
{
    class Program
    {
        static void Main()
        {
            // source list of numbers 1–20
            var nums = Enumerable.Range(1, 20).ToList();

            // filter even numbers
            var evens = nums.Where(x => x % 2 == 0);
            Console.WriteLine("evens: " + string.Join(", ", evens));

            //project squares
            var squares = nums.Select(x => x * x);
            Console.WriteLine("squares: " + string.Join(", ", squares));

            //order words by length descending
            var words = new List<string> { "apple", "fig", "banana", "date", "cherry" };
            var byLengthDesc = words.OrderByDescending(w => w.Length);
            Console.WriteLine("words by length desc: " + string.Join(", ", byLengthDesc));

            //group numbers into odd/even
            var groups = nums.GroupBy(x => x % 2 == 0 ? "even" : "odd");
            foreach (var g in groups)
                Console.WriteLine($"{g.Key}s: {string.Join(", ", g)}");

            //join two lists to find common elements
            var listA = new List<int> { 2, 4, 6, 8, 10 };
            var listB = new List<int> { 5, 6, 7, 8, 9 };
            var common = listA.Join(listB, a => a, b => b, (a, b) => a); // parameter B never used error?
            Console.WriteLine("common between A and B: " + string.Join(", ", common));

            //skip first 5 and take next 5 (6–10)
            var chunk = nums.Skip(5).Take(5);
            Console.WriteLine("numbers 6 to 10: " + string.Join(", ", chunk));

            //any/all checks
            Console.WriteLine("any > 15? " + nums.Any(x => x > 15));
            Console.WriteLine("all positive? " + nums.All(x => x > 0));
        }
    }
}