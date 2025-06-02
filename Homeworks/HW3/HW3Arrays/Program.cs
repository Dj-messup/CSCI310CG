//Chica Gomes
//HW3 Done
//
//description: Create a folder named HW3 under a Homeworks folder and create a new project in that location named HW3Arrays.
// Create a one-dimensional array of 10 random numbers between 0 and 100 (you will want to use the Random class and create an instance
// of that class, then use a for loop to populate that array with the instance.Next(100)). Print out that array, sort the array, print it
// out, reverse the array and then print it out again.
// Create a 3 by 3 rectangular array with some values (does not need to be random) and create a jagged array with at least 3 rows.
//

using System;

namespace HW3Arrays
{
    public class HW3Arrays
    {
        static void Main(string[]args)
        {
            //random number generate
            Random rand = new Random();
            int[] numbers = new int[10];
            
            //random numbers between 0-99 into array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100);
            }
            
            //print it
            Console.WriteLine("Original array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            //sort it
            Array.Sort(numbers);
            Console.WriteLine("\nSorted array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            //reverse it
            Array.Reverse(numbers);
            Console.WriteLine("\nReverse array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            // 3x3 not random rect array 
            int[,] matrix =
            {
                { 12, 7, 5 },
                { 3, 14, 8 },
                { 9, 6, 11 },
            };
            
            Console.WriteLine("\n3x3 matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
            
            // jagged array w/3 rows of diff lengths
            int [][] jaggedArray = new int[3][];
            jaggedArray[0] = new int [] { 10, 20 };
            jaggedArray[1] = new int [] { 30, 40, 50 };
            jaggedArray[2] = new int [] { 60, 70, 80, 90 };
            
            Console.WriteLine("\njagged array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
