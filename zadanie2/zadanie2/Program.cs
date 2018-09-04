using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        public static void Metoda()
        {
            for(int i=1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("podzielna 3 i 5");
                else if (i % 3 == 0)
                    Console.WriteLine("podzielna 3");
                else if (i % 5 == 0)
                    Console.WriteLine("podzielna 5");
                else
                    Console.WriteLine($"{i}");
            }
        }

        public static double Metoda2()
        {
            double suma = 0;
            for(int i =0;i<=100; i++)
            {
                if (i % 2 == 0)
                    suma += i;
            }
            return suma;
        }

        public static List<double> Metoda3(double[] tab)
        {
            List<double> list = new List<double>();

            for (int i = 0; i<tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                    list.Add(tab[i]);
            }
            return list;
        }

        static void Main(string[] args)
        {
            //Metoda();
            // double suma = Metoda2();
            //Console.WriteLine($"{suma}");

            double[] tab = { 2, 3, 4, 5, 6, 7, 8, 9 };
            List <double> list = Metoda3(tab);
            //foreach(var i in list)
               // Console.WriteLine($"{i}");
            Console.WriteLine($"{string.Join(", ", list)}");
        }
    }
}
