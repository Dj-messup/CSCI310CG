// Chica Gomes
// HW10Lists working on
//
// Create 2 lists of different types (one should be ints) and populate each list with some values
// (the int should be at least 10). Write a method to insert a value into the list passed as a
// parameter, should use BinarySearch to determine where to insert the value (the list must be
// sorted for BinarySearch to function correctly). Write a method to print out a list passed to it.
// Demonstrate your code working from Main.
//

using System;
using System.Collections.Generic;

namespace HW10Lists
{
    public class HW10Lists
    {
        public static void Main()   // unused args warning
        {
            //int list
            var intList = new List<int>
            {
                36, 5, 24, 106, 68, 1, 54, 3, 99, 143
            };

            Console.WriteLine("Initial integer list:");
            PrintList(intList);

            intList.Sort();
            Console.WriteLine("Sorted integer list:");
            PrintList(intList);

            InsertSorted(intList, 50);
            Console.WriteLine("After inserting 50:");
            PrintList(intList);

            Console.WriteLine();

            // string list
            var fruitList = new List<string>
            {
                "Apple", "Mango", "Soursop", "Tangerines", "Chico" //best sapote that taste like brown sugar
            };

            Console.WriteLine("Initial fruit list:");
            PrintList(fruitList);

            fruitList.Sort();
            Console.WriteLine("Sorted fruit list:");
            PrintList(fruitList);

            InsertSorted(fruitList, "Blackberry");
            Console.WriteLine("After inserting Blackberry:");
            PrintList(fruitList);
        }

        // Inserts value into sorted list at the position determined by BinarySearch
        private static void InsertSorted<T>(List<T> list, T value) where T : IComparable<T> //said to make it private??
        {
            int idx = list.BinarySearch(value);
            if (idx < 0)
                idx = ~idx;
            list.Insert(idx, value);
        }

        // Prints any List
        private static void PrintList<T>(List<T> list) //jetbrains likes private??
        {
            foreach (var item in list)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
