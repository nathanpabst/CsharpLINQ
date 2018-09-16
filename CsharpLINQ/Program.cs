using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("Nate", "8162290960", "1 Main St", 42));
            customers.Add(new Customer("Starshine", "1234567890", "2 Main St", 24));
            customers.Add(new Customer("Pollo El Diablo", "2345678901", "3 Main St", 25));
            customers.Add(new Customer("stupidFace", "4567891234", "4 Main St", -900));
            customers.Add(new Customer("munjac", "4560987123", "5 Main St", -450));

            //search for all customers with negative account balances
            var overdue =
                from cust in customers
                //if the customer balance is less than zero...
                where cust.Balance < 0
                //then, arrange the results in ascending order
                orderby cust.Balance ascending
                //the "new" keyword is needed to select more than one field from an object
                select new { cust.Name, cust.Balance };

                Console.WriteLine("Customers with a negative balance:");

            foreach (var cust in overdue)
            {
                Console.WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);
            }
            Console.Read();
        }

        class Customer
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public decimal Balance { get; set; }

            public Customer(string name, string phone, string address, decimal balance)
            {
                Name = name;
                Phone = phone;
                Address = address;
                Balance = balance;

            }
        }
    }
}
