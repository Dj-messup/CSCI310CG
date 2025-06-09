//Chica Gomes
//Project 2 IN Progress 
//
//Description: Create a class to store points from a cartesian coordinate system (x, y).
// Create an operator overload to add 2 points together and return a point.
// Create an operator to multiply a point with a scale and then return the point.
// Create an operator to multiply 2 points together, same as you would add 2 points together.
// Create a ToString method to return a string of a point.
// Overload == and != to compare 2 points.
// Create 2 points in Main and demonstrate your class and overloaded operators.

using System;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    // Constructor
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Overload + to add two points
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    // Overload * to scale a point by a scalar
    public static Point operator *(Point p, double )
    {
        return new Point(p.X * , p.Y * ); //scale
    }

    // Overload * to multiply two points (component-wise)
    public static Point operator *(Point a, Point b)
    {
        return new Point(a.X * b.X, a.Y * b.Y);
    }

    // Override ToString to display the point
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    // Overload == operator
    public static bool operator ==(Point a, Point b)
    {
        return a.X == b.X && 
    }

    // Overload != operator
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    // Ov
    public override bool Equals(object obj)
    {
        
        return false;
    }

    public override int // hash??
    {
        return //smthn
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two points
        

        // Demonstrate addition
        

        // Demonstrate scalar multiplication
        

        // Demonstrate point-wise multiplication
        

        // Demonstrate equality
        
    }
}
