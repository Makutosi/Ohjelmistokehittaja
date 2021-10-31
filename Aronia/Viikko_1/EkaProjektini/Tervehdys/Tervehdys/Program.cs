// Dia 9_Harjoituksia_Tehtävä 6/ 25.10.2021
using System;

namespace Tervehdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ole hyvä, ja anna sinun etunimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi + "!");

            //
            Console.WriteLine("\nMikä sinun nimesi on?");
            string etunimi = Console.ReadLine();
            Console.WriteLine("Tervetuloa " + etunimi + "!");
        }
    }
}
