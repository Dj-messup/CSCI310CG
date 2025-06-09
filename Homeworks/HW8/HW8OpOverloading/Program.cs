// Chica Gomes
// HW8 Done
//
//description: Take the Fraction class I created and overload the multiply (*)
//operator and divide operator (/). Demonstrate with 2 different Fractions.
//

using System;

namespace HW8OpOverloading
{
    //beginning
    public class Hw8Demo
    {
        public static void Main()   // no unused args warning
        {
            var frac1 = new Fraction(2, 3);
            var frac2 = new Fraction(3, 4);

            Console.WriteLine($"Fraction 1: {frac1}");
            Console.WriteLine($"Fraction 2: {frac2}");

            var product  = frac1 * frac2;
            var quotient = frac1 / frac2;

            Console.WriteLine($"Product  (2/3 * 3/4): {product}");
            Console.WriteLine($"Quotient (2/3 / 3/4): {quotient}");
        }
    }

    //helper
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int num, int denom)
        {
            if (denom == 0) throw new ArgumentException("denominator can’t be 0");
            _numerator   = num;
            _denominator = denom;
            Simplify();
        }

        public override string ToString() => $"{_numerator}/{_denominator}";

        //op overload
        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a._numerator * b._numerator,
                         a._denominator * b._denominator);

        public static Fraction operator /(Fraction a, Fraction b) =>
            new Fraction(a._numerator * b._denominator,
                         a._denominator * b._numerator);

        //reduce to low terms
        private void Simplify()
        {
            int g = Gcd(Math.Abs(_numerator), Math.Abs(_denominator));
            _numerator   /= g;
            _denominator /= g;

            if (_denominator < 0)
            {
                _numerator   = -_numerator;
                _denominator = -_denominator;
            }
        }

        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }
}
