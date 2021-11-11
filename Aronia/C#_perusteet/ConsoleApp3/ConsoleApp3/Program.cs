// C#_perusteet/ Osa 4: Käyttäjän syötteen lukeminen/ 6.11.2021
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nimi; // alustetaan muuttujan nimi
            int ika;

            Console.Write("Anna nimesi: ");
            nimi = Console.ReadLine();

            Console.Write("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine()); // muuttaa tekstijono numeroksi
            // ika = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nimesi on " + nimi + " ja olet " + ika + "vuotias!");
            ika++;
            Console.WriteLine("Vuoden päästä olet " + ika + " vuotias!");
        }
    }
}
