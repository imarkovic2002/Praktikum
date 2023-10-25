using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kalkulator:");

            Console.WriteLine("Unesite prvi broj:");

            string prvibroj = Console.ReadLine();

            Console.WriteLine("Unesite drugi broj:");

            string drugibroj = Console.ReadLine();
            Console.WriteLine("Upišite koju radnju želite obaviti:(+/-)?");
            string radnja = Console.ReadLine();

            Console.WriteLine("Prvi uneseni broj je:" + prvibroj + ", dok drugi broj je:" + drugibroj);
            IzvrsiNaredbu(radnja, float.Parse(prvibroj), float.Parse(drugibroj));

            Console.ReadLine();
        }


        public static void IzvrsiNaredbu(string radnja, float prvibroj, float drugibroj)
        {
            //Console.WriteLine("Suma je:" + (float.Parse(prvibroj) + float.Parse(drugibroj)));

            if (radnja == "-")
            {
                Console.WriteLine("Odabrali ste minus:" + (prvibroj - drugibroj));
            }
            else if (radnja == "+")
            {
                Console.WriteLine("Odabrali ste zbrajanje:" + (prvibroj + drugibroj));
            }
            else
                Console.WriteLine("Niste odabrali dobru radnju.");
            Console.ReadLine();
        }
    }
}