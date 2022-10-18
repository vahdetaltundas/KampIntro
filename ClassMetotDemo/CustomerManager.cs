using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" isimli kullanıcı veritabanına eklendi.");
        }

        public void Listing(List<Customer> customers)
        {
            int temp = 1;
            foreach (Customer customer in customers)
            {
                Console.WriteLine(temp+". "+customer.Name+" isimli müşteri");
                temp++;
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli kullanıcı veritabanından silindi.");
        }

    }
}
