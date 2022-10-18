using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list1 = new MyList<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            foreach (var i in list1.Items)
            {
                Console.WriteLine(i);
            }

        }
    }
}
