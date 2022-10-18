using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Musteri musteri1=new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();
            GercekMusteri musteri3=new GercekMusteri();
            TuzelMusteri musteri4=new TuzelMusteri();

            CostumerManager costumerManager=new CostumerManager();

            costumerManager.Add(musteri1);
            costumerManager.Add(musteri2);
            costumerManager.Add(musteri3);
            costumerManager.Add(musteri4);
            costumerManager.Add(musteri1);


        }
    }
}
