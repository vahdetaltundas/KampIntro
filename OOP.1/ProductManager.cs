using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._1
{
    internal class ProductManager 
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" ürünü eklendi.");
        }

        public void UpDate(Product product)
        {
            Console.WriteLine(product.ProductName+" ürünü güncellendi");
        }
    }
}
