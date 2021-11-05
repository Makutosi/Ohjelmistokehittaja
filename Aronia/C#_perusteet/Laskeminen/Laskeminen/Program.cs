// C#_ perusteet/ 3.11.2021
using System;

namespace Laskeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;

            int summa;
            int erotus;
            int tulo;
            double osamaara;

            summa = x + y;
            erotus = x - y;
            tulo = x * y;
            osamaara = (float)x / y;
            // osamaara = (float)x / y;

            Console.WriteLine("Summa = " + summa);
            Console.WriteLine("Erotus = " + erotus);
            Console.WriteLine("Tulo = " + tulo);
            Console.WriteLine("Osamaara = " + osamaara);

        }
    }
}
