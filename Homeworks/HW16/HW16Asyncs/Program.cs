// Chica Gomes
// HW16Async IP
//
// description:Create and demonstrate at least 2 functions that are different than what I created
// and at least one must be async.
//

using System;
using System.Threading.Tasks;

namespace HW16Async
{
    class HW16Asyncs
    {
        // sync: print square of each number from 1 to max (delay 50ms)
        static void PrintSquares(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"squares {i}: {i * i}");
                Task.Delay(50).Wait();
            }
        }

        // async: print cube of each number from 1 to max (delay 100ms)
        static async Task PrintCubesAsync(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"cubes   {i}: {i * i * i}");
                await Task.Delay(100);
            }
        }

        static async Task Main()
        {
            Console.Write("enter max number: ");
            if (!int.TryParse(Console.ReadLine(), out int max) || max < 1)
            {
                Console.WriteLine("invalid input, must be a positive integer");
                return; //error handling 
            }

            Console.WriteLine();
            Console.WriteLine("sync squares:");
            PrintSquares(max);

            Console.WriteLine();
            Console.WriteLine("async cubes:");
            await PrintCubesAsync(max);

            Console.WriteLine();
            Console.WriteLine("yayy we did it!!");
        }
    }
}