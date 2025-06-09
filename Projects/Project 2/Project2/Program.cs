// Chica Gomes
// Project2 Finished
//
//description: Create a class to store points from a cartesian coordinate system (x, y).
// Create an operator overload to add 2 points together and return a point.
// Create an operator to multiply a point with a scale and then return the point.
// Create an operator to multiply 2 points together, same as you would add 2 points together.
// Create a ToString method to return a string of a point.
// Overload == and != to compare 2 points.
// Create 2 points in Main and demonstrate your class and overloaded operators.
//

using System;

namespace Project2
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //operators

        public static Point operator +(Point a, Point b) =>
            new Point(a.X + b.X, a.Y + b.Y);

        public static Point operator *(Point p, double k) =>
            new Point(p.X * k, p.Y * k);

        public static Point operator *(double k, Point p) => p * k;

        public static Point operator *(Point a, Point b) =>
            new Point(a.X * b.X, a.Y * b.Y);

        //comparison

        public static bool operator ==(Point a, Point b) =>
            a.X == b.X && a.Y == b.Y;

        public static bool operator !=(Point a, Point b) => !(a == b);

        public override bool Equals(object? obj) =>
            obj is Point p && this == p;

        public override int GetHashCode() =>
            HashCode.Combine(X, Y);

        //print it out

        public override string ToString() => $"({X}, {Y})";
    }

    public class Project2
    {
        public static void Main()
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(4, 5);

            Console.WriteLine($"Point 1: {p1}");
            Console.WriteLine($"Point 2: {p2}\n");

            Console.WriteLine($"p1 + p2 = {p1 + p2}");
            Console.WriteLine($"p1 * 2  = {p1 * 2}");
            Console.WriteLine($"p1 * p2 = {p1 * p2}\n");

            var copyOfP1 = new Point(2, 3);
            Console.WriteLine($"p1 == copyOfP1 ? {p1 == copyOfP1}");
            Console.WriteLine($"p1 != p2       ? {p1 != p2}");
        }
    }
}