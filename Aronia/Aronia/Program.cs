// C#-ohjelmointi/ Dia 9/ Harjoituksia/ 25.10.2021
// Tehtävä 3
using System;

namespace Aronia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hyvää päivää!");
        }
    }
}

// Tehtävä 4
namespace OmaNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eriko Korhonen");
        }
    }
}

// Tehtävä 5
namespace YksiNumerot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("11");
            Console.WriteLine("101");
            Console.WriteLine("1001");
        }
    }
}

// Tehtävä 6
namespace EtuNimi
{
    Class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Mikä sinun nimesi on? ");

            string nimi = Console.ReadLine();
            Console.WriteLine("Hei: {0}", nimi);
            Console.ReadLine();
        }
    }
}

// Tehtävä 8
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = Math.Pow(-7, 4);
            Console.WriteLine("-7*-7*-7*-7:" + result1);

            double result2 = Math.Pow(2, 8);
            Console.WriteLine("2*2*2*2*2*2*2*2:" + result2);

            int num = Math.Min(8, 4);
            Console.WriteLine(num);

            double real = Math.Max(-11.2, 6.4);
            Console.WriteLine(real);

            double sqrt1 = Math.Sqrt(25);
            Console.WriteLine(sqrt1);

            double sqrt2 = Math.Sqrt(2);
            Console.WriteLine(sqrt2);
         }
    }
}

// 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 5;
            x = y + 3;
            Console.WriteLine(x);

        }

        static void Main(string[] args)
        {
            var x = 10;
            var y = 5;
            x = y - 2;
            Console.WriteLine(x);
         }
    }
}

// Dia 16/ Harjoituksia
namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 1
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku2 + 3));
            
            // Tehtävä 2
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku2 - 2));
            
            // Tehtävä 3
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());;
            Console.WriteLine("x = " + (luku2 * 5));
            
            // Tehtävä 4
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 / luku2));
            
            //Tehtävä 5
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 % luku2));
            
            // Tehtävä 6
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 += luku2));
            
            // Tehtävä 7
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 -= luku2));
            
            // Tehtävä 8
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 *= luku2*5));
            
            // Tehtävä 9
            Console.Write("Anna ensimmäinen numero: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 /= luku2));
        }
    }
}

// Dia 24/ Harjoituksia
// Tehtävä 1
public static void Main(string[] args)
{
    Console.Write("Ole hyvä, ja anna kahta kokonaislukuarvoa: ");
    int luku1 = int.Parce(Console.ReadLine());
    int luku2 = int.Parce(Console.ReadLine());
    if (luku1 < luku2)
    {
        Console.WriteLine("Suuruusjärjestys: " + luku2'' + luku1);
    }
    else if(luku1 > luku2)
    {
        Console.WriteLine("Suuruusjärjestys: " + luku1'' + luku2);
    }
    else if(luku1 == luku2)
    {
        Console.WriteLine("Suuruusjärjestys: " + luku1'' + luku2);
    }
}






