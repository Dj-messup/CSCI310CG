// Chica Gomes
// EventManager In Progress
//
// description: follow prompts , create a simple event manager. You will need to have the following requirements implemented:
// Classes for customers and orders which either use an interface or abstract class that they inherit some methods from.
// A method in orders that when an order comes in for a customer, an event is triggered to notify something
// (it can just be output to the console and this would be similar to the example I created).
// You should also create a method that will alert subscribers to when the order is ready to ship and need to create a class that subscribes to that event.
// Inside of Main, you will create at least 10 customers and demonstrate the events trigger when an order is placed for one of the customers and when an order is ready to ship. Additionally write some queries using LINQ or lambdas to pull from the list of customers (name or other pieces of information for example).
//

// using System;
//using System.Collections.Generic;
//using System.Linq; - no need 

namespace EventManager
{
    // base class with init-only ID
    public abstract class BaseEntity
    {
        public int Id { get; protected init; } // suggested protected 
    }

    // customer holds ID, Name, Email
    public class Customer : BaseEntity
    {
        public string Name { get; init; }
        public string Email { get; init; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString() => $"{Id}: {Name} <{Email}>";
    }

    // event args carries the order + its customer
    public class OrderEventArgs(Order order, Customer customer) : EventArgs //primary constructor class suggestion
    {
        public Order Order { get; } = order;
        public Customer Customer { get; } = customer;
    }

    // order triggers two events
    public class Order : BaseEntity
    {
        public Customer Customer { get; }
        public string Product { get; init; }
        public event EventHandler<OrderEventArgs>? OrderPlaced;
        public event EventHandler<OrderEventArgs>? OrderShipped;

        public Order(int id, Customer customer, string product)
        {
            Id = id;
            Customer = customer;
            Product = product;
        }

        // place the order
        public void Place()
        {
            Console.WriteLine($"placing order {Id} for {Customer.Name}");
            OrderPlaced?.Invoke(this, new OrderEventArgs(this, Customer));
        }

        // ship the order
        public void Ship()
        {
            Console.WriteLine($"shipping order {Id} ({Product}) to {Customer.Name}");
            OrderShipped?.Invoke(this, new OrderEventArgs(this, Customer));
        }
    }

    // subscriber for both events
    public class NotificationService
    {
        public void OnOrderPlaced(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"[notify] order {e.Order.Id} placed for {e.Customer.Name} (product: {e.Order.Product})");
        }

        public void OnOrderShipped(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"[notify] order {e.Order.Id} shipped to {e.Customer.Email}");
        }
    }

    class EventManager
    {
        static void Main()
        {
            // build 10 customers
            var customers = Enumerable.Range(1, 10).Select(i => new Customer(i, $"Cust{i}", $"cust{i}@mail.com")).ToList();

            // show all customers
            Console.WriteLine("Customers:");
            foreach (var c in customers)
                Console.WriteLine($"  {c}");

            // prompt user for customer selection
            Console.Write("\nEnter customer ID to place an order for: ");
            int custId = int.TryParse(Console.ReadLine(), out int val) ? val : -1;
            var cust = customers.FirstOrDefault(c => c.Id == custId);
            if (cust == null)
            {
                Console.WriteLine("Invalid customer. Exiting.");
                return;
            }

            // prompt for product
            Console.Write("Enter product name: ");
            string? product = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(product))
            {
                Console.WriteLine("No product given. Exiting.");
                return; //error handle
            }

            // make an order
            var rnd = new Random();
            int orderId = 500 + rnd.Next(100);
            var order = new Order(orderId, cust, product);

            // hook up notifications
            var notifier = new NotificationService();
            order.OrderPlaced  += notifier.OnOrderPlaced;
            order.OrderShipped += notifier.OnOrderShipped;

            Console.WriteLine();
            order.Place();

            // let user decide to ship, add to handle upper or lower case 
            Console.Write("Ready to ship? (y/n): ");
            var resp = Console.ReadLine();
            if (resp != null && resp.Trim().ToLower() == "y")
            {
                order.Ship();
            }
            else
            {
                Console.WriteLine("Order not shipped yet.");
            }

            // LINQ queries
            Console.WriteLine();
            Console.WriteLine("even Ids:");
            foreach (var c2 in customers.Where(c => c.Id % 2 == 0)) 
                Console.WriteLine($"  {c2}");

            Console.WriteLine();
            Console.WriteLine("all emails:");
            foreach (var email in customers.Select(c => c.Email)) 
                Console.WriteLine($"  {email}");
        }
    }
}