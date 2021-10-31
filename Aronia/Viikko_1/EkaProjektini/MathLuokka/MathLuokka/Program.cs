// Dia 9_Harjoituksia_Tehtävä 8/ 25.10.2021
using System;

namespace MathLuokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math.Pow: Exponentti");
            double result1 = Math.Pow(-7, 4);
            Console.WriteLine("-7*-7*-7*-7=" + result1);

            double result2 = Math.Pow(2, 8);
            Console.WriteLine("2*2*2*2*2*2*2*2=" + result2);

            for (int i = 1; i <= 8; i++)
            Console.WriteLine(Math.Pow(i, 2));

            Console.WriteLine("\nMath.Min & Math.Max:");
            int num = Math.Min(8, 4);
            Console.WriteLine(num);

            double real = Math.Max(-11.2, 6.4);
            Console.WriteLine(real);

            /*int[] arr = new[] { 14, 3, 5, 6, 8 };
            int max = 0, min = 100;
            for(int i = 0; i < 5; i++)
            { 
                max = Math.Max(arr[i], max);
                min = Math.Min(arr[i], min);
            }
            Console.Write("\nmax on {0},min on {1}", max, min);*/

            Console.WriteLine("\nMath.Sqrt: Neliöjuuri");
            double sqrt1 = Math.Sqrt(25);
            Console.WriteLine(sqrt1);

            double sqrt2 = Math.Sqrt(2);
            Console.WriteLine(sqrt2);
        }
    }
}
