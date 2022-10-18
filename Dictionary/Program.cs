using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dicList=new Dictionary<int,string>();

            dicList.Add(1, "Vahdet");
            dicList.Add(2, "Ramazan");
            dicList.Add(3, "Hüseyin");
            dicList.Add(4, "Enes");

            Console.WriteLine(dicList[2]);





        }
    }
}
