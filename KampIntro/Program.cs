using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Vahdet Altundaş";
            kurs2.IzlenmeOrani = 98;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ömer Doğan";
            kurs3.IzlenmeOrani = 72;

            Kurs[] kurslar=new Kurs[] {kurs1,kurs2,kurs3};

            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }






            Console.ReadLine();

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
