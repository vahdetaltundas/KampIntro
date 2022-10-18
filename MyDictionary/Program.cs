using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, int> dictionary1 = new MyDictionary<int, int>();

            dictionary1.Add(1, 2);
            dictionary1.Add(2, 3);
            dictionary1.Add(3, 4);

            dictionary1.DictionaryList();
            
        }
    }
}
