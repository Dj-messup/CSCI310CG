// Chica Gomes
// Project 3 working on it
//
// Description: You must read in information from a file and create objects from the file.
// where each field in the file corresponds to: last name, first name, customer id,
// business name, phone number. Read the file with at least 4 entries into some sort of
// collection (List, LinkedList, Dictionary, etc) and the collection should store the
// customers as objects.create a class for customers with the variables(fields) that
// match what is in your input file with corresponding get and set for each one.
// Also you should have a constructor. create an interface that your class inherits
// from with at least 2 methods you have to implement. Your class should have a
// ToString and CompareTo (that you have to implement from IComparable or IComparer)
// Demonstrate you mini customer database functioning and write out to a new file a
// formatted list for your customers
//
//changed my properties to copy always on customers.txt to help with file. Output file should be in bin

using System;
using System.IO;
using System.Collections.Generic;

namespace CustomerManagement
{
    //interface, every customer should be able to give full name and contact info
    public interface ICustomerOperations
    {
        string GetFullName();
        string GetContactInfo();
    }
    
    //match file format, support sort, use interface
    public class Customer : ICustomerOperations, IComparable<Customer>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Id  { get; set; }     //renamed id
        public string Business { get; set; }
        public string Phone { get; set; }
        
        // Just make a new Customer with all their info
        public Customer(string lastName, string firstName, int id, string business, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            Id = id;
            Business = business;
            Phone = phone;
        }
        
        //Combine first and last
        public string GetFullName() => $"{FirstName} {LastName}";
        //combine business and phone 
        public string GetContactInfo() => $"{Business} • {Phone}";
        
        //print in format
        public override string ToString() =>
            $"Last name: {LastName}\n" +
            $"First name: {FirstName}\n" +
            $"ID: {Id}\n" +
            $"Business: {Business}\n" +
            $"Phone: {Phone}\n";
        
        //sort by last then by first if match
        public int CompareTo(Customer? other)
        {
            if (other == null) return 1;
            int cmp = String.Compare(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);
            return cmp != 0 ? cmp : String.Compare(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Program
    {
        public static void Main() 
        {
            string inputFile  = "customers.txt";
            string outputFile = "customersout.txt";
            
            // Make a list for all the customers
            var customers = new List<Customer>();
            
            //open and read
            using (var sr = new StreamReader(inputFile))
            {
                // Split by commas, get rid of some spaces
                string? line; // declare first
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(',', StringSplitOptions.TrimEntries);
                    // Trim all fields just in case
                    for (int i = 0; i < parts.Length; i++) parts[i] = parts[i].Trim();
                    if (parts.Length == 5 && int.TryParse(parts[2], out int id))
                    {
                        customers.Add(new Customer(
                            lastName: parts[0],
                            firstName: parts[1],
                            id: id,
                            business: parts[3],
                            phone: parts[4]
                        ));
                    }
                    else
                    {
                        Console.WriteLine($"Skipped line (bad format): {line}");
                    }
                }
            }
            
            // Sort the customers (alphabetical)
            customers.Sort();
            
            // Show the customers (so you can check the file was read)
            Console.WriteLine("-----Customer Database-----\n");
            if (customers.Count == 0)
                Console.WriteLine("No customers were read from the file.");
            else
            {
                foreach (var c in customers)
                {
                    Console.WriteLine(c);
                }
            }
            
            //write in file in nice format
            using (var sw = new StreamWriter(outputFile))
            {
                foreach (var c in customers)
                {
                    sw.WriteLine($"Last name: {c.LastName}");
                    sw.WriteLine($"First name: {c.FirstName}");
                    sw.WriteLine($"ID: {c.Id}");
                    sw.WriteLine($"Business: {c.Business}");
                    sw.WriteLine($"Phone: {c.Phone}");
                    sw.WriteLine();
                }
            }

            Console.WriteLine($"Formatted customer list written to {outputFile}");
        }
    }
}
