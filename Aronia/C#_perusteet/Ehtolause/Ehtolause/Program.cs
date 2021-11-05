//C#_perusteet_osa 3/ 5.11.2021
using System;

namespace Ehtolause
{
    class Program
    {
        /*static void Main(string[] args)
        {
            if(true)  // if(false)-> Ehto ei ollut tosi
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }
        }*/

        /*static void Main(string[] args)
        {
            bool ehto = true; // muuttuja ehto
            if (ehto)
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }
        }*/
        /*static void Main(string[] args)
        {
            bool ehto = false;
            if (!ehto) // (ehto == false)
            // ! tarkistaa, onko ehto false?
            // ilman ! onko ehto true?
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }*/
        /*static void Main(string[] args)
        {
            int x = 7;
            if (x == 7)   // (x == 6) -> Ehto ei ollut tosi
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }
        }*/

        /*static void Main(string[] args)
        {
            int x = 0;
            if (x == 1)  
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }
            Console.WriteLine(); // tyhjä rivi
            x++;
            if (x == 1)
            {
                Console.WriteLine("Ehto oli tosi!");
            }
            else
            {
                Console.WriteLine("Ehto ei ollut tosi");
            }
        }*/
        /*static void Main(string[] args)
        {
            int x = 71; // x: arvo on 71
            if (x == 0) // Tarkistetaan, onko x arvo 0?
            {
                Console.WriteLine("X on nolla.");
            }
            else if (x == 1) // tarkistetaan, onko x: arvo 1?
            {
                Console.WriteLine("X on yksi.");
            }
            else
            {
                Console.WriteLine("X on jotain muuta kuin nolla tai yksi.");
            }
        }*/
        // lyhyempi versio
        static void Main(string[] args)
        {
            //int x = 71;
            //if (x == 0)
            //    Console.WriteLine("X on nolla");
            //else if (x == 1)
            //    Console.WriteLine("X on yksi.");
            //else
            //    Console.WriteLine("X on muuta kuin nolla tai yksi.");
            ////
            /* String nimi = "Pekka";
             if (nimi == "Pekka")
                 Console.WriteLine("X on nolla.");
             else if (nimi == "Liisa")
                 Console.WriteLine("X on Yksi.");
             else
                 Console.WriteLine("X on muuta kuin nolla tai yksi.");*/
            ////
            /*String nimi = "Liisa";
            /*int x = 0;
            if (nimi == "Pekka")
                Console.WriteLine("X on nolla.");
            else if (nimi == "Anssi" || (x == 0 && nimi == "Liisa"))
                Console.WriteLine("X on yksi.");
            else
                Console.WriteLine("X on jotain muuta kuin nolla tai yksi.");*/
            ////
            String nimi = "Liisa";
            int x = 1;
            if (nimi != "Pekka") //Mikäli nimi ei ole Pekka, tulostetaan "X on nolla".
                Console.WriteLine("X on nolla.");
            else if (nimi == "Anssi" || (x == 0 && nimi == "Liisa"))
                Console.WriteLine("X on yksi.");
            else
                Console.WriteLine("X on jotain muuta kuin nolla tai yksi.");
        }

    }
    
}
