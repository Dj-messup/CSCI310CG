// Chica Gomes
// HW14 kinda cleaned up In Progress
//
// description: 
//

using System;

namespace HW14Delegates
{
    public delegate void CircleDelegate(double r);

    class Program
    {
        // — helpers — //
        static void CalcArea(double r) =>
            Console.WriteLine($"area:  {Math.PI * r * r:F2}");

        static void CalcCirc(double r) =>
            Console.WriteLine($"circ:  {2 * Math.PI * r:F2}");

        static double GetArea(double r) => Math.PI * r * r;
        static double GetCirc(double r) => 2 * Math.PI * r;
        static bool   IsValid(double r) => r >= 0;

        // — main — //
        static void Main()
        {
            Console.Write("radius? ");
            if (!double.TryParse(Console.ReadLine(), out double r))
            {
                Console.WriteLine("bad input – try again"); return;
            }

            // multicast: one call, two prints
            CircleDelegate ops = CalcArea;
            ops += CalcCirc;

            Console.WriteLine("\nmulticast:");
            ops(r);

            // Func
            Func<double,double> fArea = GetArea;
            Func<double,double> fCirc = GetCirc;

            Console.WriteLine("\nfunc:");
            Console.WriteLine($"area  -> {fArea(r):F2}");
            Console.WriteLine($"circ  -> {fCirc(r):F2}");

            // Action
            Action<double> aArea = x => Console.WriteLine($"area  (action) -> {fArea(x):F2}");
            Action<double> aCirc = x => Console.WriteLine($"circ  (action) -> {fCirc(x):F2}");

            Console.WriteLine("\naction:");
            aArea(r);
            aCirc(r);

            // Predicate
            Predicate<double> ok = IsValid;

            Console.WriteLine("\npredicate:");
            Console.WriteLine(ok(r) ? "radius looks good " : "radius can’t be negative homie ");
        }
    }
}