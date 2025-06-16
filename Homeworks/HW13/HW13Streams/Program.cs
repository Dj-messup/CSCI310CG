// Chica Gomes
// HW13Streams working on it
//
// Description:Create a text file. Read in the file using either a
// StringReader or FileStream. Manipulate some of the data and write out
// to a different file. You should use the using keyword for any streams.
//
//changed my properties to copy always on greet.txt to help with file. Output file should be in bin

using System;
using System.IO;// not really needed 

namespace HW13Streams
{
    public class HW13Streams
    {
        public static void Main()
        {
            string inputFile  = "greet.txt";
            string outputFile = "greetout.txt";

            //Read, transform, and write
            using (var fsIn  = new FileStream(inputFile,  FileMode.Open,   FileAccess.Read))
            using (var sr    = new StreamReader(fsIn))
            using (var fsOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            using (var swOut = new StreamWriter(fsOut))
            {
                string? line; // loop condition insert here 
                while ((line = sr.ReadLine()) != null)
                {
                    // convert to uppercase
                    swOut.WriteLine(line.ToUpperInvariant());
                }
            }

            //Now read back greetout.txt and print it
            Console.WriteLine("Contents of greetout.txt:");
            using (var sr2 = new StreamReader(outputFile))
            {
                string? outLine; // loop condition too
                while ((outLine = sr2.ReadLine()) != null)
                {
                    Console.WriteLine(outLine);
                }
            }
        }
    }
}