using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        public static long Silnia (long a)
        {
            if (a > 1)
            {
                return  a * Silnia(a - 1);
            }
            else return 1;
        }

        static void Main(string[] args)
        {
            long silnia = Silnia(6);
            Console.WriteLine($"Silnia = {silnia}");
        }
    }
}
