// Chica Gomes
// Project 1
//
// Description: 
using System;

namespace Project1
{
    public class Project1
    {
        static void Main(string[] args)
        {
            // ask for birth year
            Console.WriteLine("Hey! What year were you born in? (e.g. 2003)");
            int year;
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Oops, that’s not a valid year. Exiting.");//safe
                return;
            }

            // ask for birth month
            Console.WriteLine("Cool. What month? (1–12)");
            int month;
            try
            {
                month = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Oops, invalid month. Exiting.");//safe
                return;
            }

            // ask for birth day
            Console.WriteLine("And what day? (1–31)");
            int day;
            try
            {
                day = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Oops, invalid day. Exiting.");//safe
                return;
            }

            DateTime today = DateTime.Today;
            DateTime dob; // date of birth

            // make sure the date is real
            try
            {
                dob = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("That date does not exist. Try again later.");//safe
                return;
            }

            // calculate age
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age))
            {
                age--;
            }

            // check impossible ages
            if (dob > today)
            {
                Console.WriteLine("Hold on—you're not born yet!");
                return;
            }

            if (age > 150)
            {
                Console.WriteLine("Wow, over 150 years old? Come on.");//requirement
                return;
            }

            Console.WriteLine($"\nYou are {age} years old.");

            // if it’s their birthday today
            if (dob.Month == today.Month && dob.Day == today.Day)
            {
                Console.WriteLine("Happy Birthday!");//requirement
            }

            // figure out Western zodiac sign
            string sunSign = GetSunSign(month, day);
            Console.WriteLine($"\nYour Western (sun) zodiac sign is: {sunSign}");

            // figure out Chinese zodiac sign
            string chineseSign = GetChineseZodiac(year);
            Console.WriteLine($"Your Chinese zodiac sign is: {chineseSign}");
        }

        // get Western sun sign
        static string GetSunSign(int m, int d)
        {
            if ((m == 1 && d >= 20) || (m == 2 && d <= 18)) return "Aquarius";
            if ((m == 2 && d >= 19) || (m == 3 && d <= 20)) return "Pisces";
            if ((m == 3 && d >= 21) || (m == 4 && d <= 19)) return "Aries";
            if ((m == 4 && d >= 20) || (m == 5 && d <= 20)) return "Taurus";
            if ((m == 5 && d >= 21) || (m == 6 && d <= 20)) return "Gemini";
            if ((m == 6 && d >= 21) || (m == 7 && d <= 22)) return "Cancer";
            if ((m == 7 && d >= 23) || (m == 8 && d <= 22)) return "Leo";
            if ((m == 8 && d >= 23) || (m == 9 && d <= 22)) return "Virgo";
            if ((m == 9 && d >= 23) || (m == 10 && d <= 22)) return "Libra";
            if ((m == 10 && d >= 23) || (m == 11 && d <= 21)) return "Scorpio";
            if ((m == 11 && d >= 22) || (m == 12 && d <= 21)) return "Sagittarius";
            return (m == 12 && d >= 22) || (m == 1 && d <= 19) ? "Capricorn" : "Unknown";
        }

        // get Chinese zodiac
        static string GetChineseZodiac(int year)
        {
            string[] animals = {
                "Rat",   "Ox",   "Tiger", "Rabbit",
                "Dragon","Snake","Horse", "Goat",
                "Monkey","Rooster","Dog", "Pig"
            };
            int index = (year - 1900) % 12;
            if (index < 0) index += 12;
            return animals[index];
        }
    }
}
