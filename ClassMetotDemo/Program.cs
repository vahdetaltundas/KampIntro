using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1,Name="Vahdet",LastName="Altundaş",Age=23 };
            Customer customer2 = new Customer() { Id = 2, Name = "Ramazan", LastName = "Dizman", Age = 21 };
            Customer customer3 = new Customer() { Id = 3, Name = "Enes", LastName = "Cesur", Age = 22 };

            CustomerManager customerManager = new CustomerManager();

            List<Customer> customers = new List<Customer>() { customer1,customer2,customer3};

            customerManager.Add(customer1);
            customerManager.Listing(customers);
            customerManager.Delete(customer2);




        }
    }
}
