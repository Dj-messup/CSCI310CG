// Chica Gomes
// HW11Collections working on
//
// Create a Dictionary, Queue and Stack. Write methods to interface
// with those collections, one method should print out the collection.
// Demonstrate the collections working.
//

using System;
using System.Collections.Generic;

namespace HW11Collections
{
    public class HW11Collections
    {
        public static void Main()   // unused args warning
        {
            // Dictionary: Hawaiʻi Pidgin to English
            var pidginDict = new Dictionary<string, string>
            {
                { "Dakine",   "that thing"       },
                { "Pau hana",  "finished work"    },
                { "Ono",       "delicious"        },
                { "Shoots",    "see you later"    },
                { "Bumbai",    "later on one day" },
                { "Akamai",    "smart"            }
            };

            Console.WriteLine("Pidgin dictionary:");
            PrintDictionary(pidginDict);
            Console.WriteLine();

            // Queue: Hawaiian islands to visit (FIFO)
            var islandQueue = new Queue<string>();
            islandQueue.Enqueue("O'ahu");
            islandQueue.Enqueue("Maui");
            islandQueue.Enqueue("Hawai'i");
            islandQueue.Enqueue("Kaua'i");
            islandQueue.Enqueue("Moloka'i");

            Console.WriteLine("Island queue:");
            PrintQueue(islandQueue);
            islandQueue.Dequeue();
            Console.WriteLine("After Dequeue:");
            PrintQueue(islandQueue);
            Console.WriteLine();

            // Stack: Shave ice flavors to try (LIFO)
            var shaveIceStack = new Stack<string>();
            shaveIceStack.Push("Mango");
            shaveIceStack.Push("Li Hing Mui");
            shaveIceStack.Push("Taro");
            shaveIceStack.Push("Pineapple");

            Console.WriteLine("Shave ice stack:"); // do you call it shave ice?
            PrintStack(shaveIceStack);
            shaveIceStack.Pop();
            Console.WriteLine("After Pop:");
            PrintStack(shaveIceStack);
        }

        // Prints a Dictionary
        private static void PrintDictionary<K, V>(Dictionary<K, V> dict)
        {
            foreach (var kvp in dict)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Prints a Queue
        private static void PrintQueue<T>(Queue<T> queue)
        {
            foreach (var item in queue)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        // Prints a Stack
        private static void PrintStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
