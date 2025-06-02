//HW2 in Process, need to check math of tax if I did it right
using System;

namespace HW2Conditionals
{
    public class HW2Conditionals
    {
        static void Main(string[]args)
        {
           Console.WriteLine("Enter your income: "); 
           
           float income;
           income = Single.Parse(Console.ReadLine());

           float tax;
           if (income < 10000f)
           {
               tax = income * 0.05f; // first <10,000 inc, 5%
               
           } else if (income <= 100000f) //count 10,000 and 100,000 inc
           {
               tax = income * 0.097f; //9.7%
               
           } else
           {
               tax = income * 0.14f; //14%
           }
           
           //print total tax
           Console.WriteLine(tax.ToString("0.00"));
           
           
            //print the triangles and square part
           Console.WriteLine("Enter number of lines to create ascending, descending triangles, and a square!");//don't need @
           
           int lines = int.Parse(Console.ReadLine());
           
           //triangle 
           for (int i = 1; i <= lines; i++)
           {
               for (int j = 1; j <= i; j++)
                   Console.Write("*"); //restrict to write so it looks nice
               Console.WriteLine("\n");
           }
           
           Console.WriteLine("\n");//aesthetic pleasing add
           
           //inverted Triangle
           for (int i = lines; i >= 1; i--)
           {
               for (int j = 1; j <= i; j++)
                   Console.Write("*");
               Console.WriteLine("\n");
           }
           
           Console.WriteLine("\n");//aesthetic pleasing add
           
           //square 
           for (int i = 1; i <= lines; i++)
           {
               for(int j = 1; j <= lines; j++)
                   Console.Write("*");
               Console.WriteLine("\n");
           }
        }
    }
}
