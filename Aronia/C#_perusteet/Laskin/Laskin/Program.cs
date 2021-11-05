//c# perusteet_Yksinkertainen laskin/ 4.11.2021
using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            String lasku;
            int luku1;
            int luku2;
            double tulos;
            Console.Write("Minkälaisen laskun haluat laskea? plus/miinus/kerto/jako: ");
            lasku = Console.ReadLine();

            Console.Write("Syötä ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());

            if (lasku == "plus")
            {
                tulos = luku1 + luku2;
                Console.WriteLine("Tulos = " + tulos);
            }
            else if (lasku == "miinus")
            {
                tulos = luku1 - luku2;
                Console.WriteLine("Tulos = " + tulos);
            }
            else if (lasku == "kerto")
            {
                tulos = luku1 * luku2;
                Console.WriteLine("Tulos = " + tulos);
            }
            else if (lasku == "jako")
            {
                tulos = (double)luku1 / luku2;
                Console.WriteLine("Tulos = " + tulos);
            }


        }
    }
}
