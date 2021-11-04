// Dia 24_Harjoituksia_Switchlauseita/ 1.11.2021
using System;

namespace SWITCH
{
    class Program
    {
        // Tehtävä 1/ Ehtolause
        /*static void Main(string [ ]args)
        {
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            int luku2 = int.Parse(Console.ReadLine());
            int a = luku2;
            if (luku1 > luku2)
            {
                luku2 = luku1;
                luku1 = a;
            }
            Console.WriteLine("Annoit luvut {0} ja {1}", luku1, luku2);
        }*/

        // Tehtävä 2/ Max
        /*static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas kokonaisluku: ");
            int luku3 = int.Parse(Console.ReadLine());
            int max;
            if (luku2 > luku1 && luku2 > luku3)
            {
                max = luku2;
            }
            else if (luku3 > luku2 && luku3 > luku1)
            {
                max = luku3;
            }
            else
            {
                max = luku1;
            }
            Console.WriteLine("Suurin luku on: {0}", max);
        }*/

        // Tehtävä 3/ kokonaisluku sanana
        /*static void Main(string []args)
        {
            Console.Write("Anna kokonaisluku välillä 0-9: ");
            int luku = int.Parse(Console.ReadLine());
            switch (luku)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Virhe! Ole hyvä ja valitse kokonaisluku välillä 0-9.");
                    break;
            }*/

        // Tehtävä 4/ suurin viidestä kokonaisluvusta/ katso uudestaan
        /*static void Main(string []args)
        {
            int[] luvut = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Anna " + (x + 1) + ". kokonaisluku: ");
                luvut[x] = int.Parse(Console.ReadLine());
            }
            int suurin = luvut[0];
            for (int y = 1; y < 5; y++)
            {
                if (luvut[y] > luvut[y - 1])
                {
                    suurin = luvut[y];
                }
            }
            Console.WriteLine("Suurin luku on: {0}", suurin);
        }*/

        // Tehtävä 5/ 
        /*static void Main(string[] args) 
        {
            Console.Write("Valitse numero, minkä haluat syöttää: 1 (koknaisluku), 2 (doubleluku), 3 (merkkijono):");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1: 
                    Console.Write("Syötä kokonaisluku: ");
                    int kluku = int.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("Annettu kokonaislukusi on: " + kluku + " ja siihen lisätty yksi: " + (kluku + 1));
                    break;
                case 2:
                    Console.Write("Syötä doubleluku: ");
                    double dluku = double.Parse(Console.ReadLine());
                    Console.WriteLine("Annettu doublelukusi on: " + dluku + " ja siihen lisätty yksi: " + (dluku + 1));
                    break;
                case 3:
                    Console.Write("Syötä merkkijono: ");
                    string mjono = Console.ReadLine();
                    Console.WriteLine("Annettu merkkijonosi on: " + mjono + " ja merkkijonon loppuun lisätty *-merkki: " + (mjono + "*"));
                    break;
                default:
                    Console.WriteLine("Virhe! Ole hyvä ja valitse joko 1(koknaisluku), 2(doubleluku) tai 3(merkkijono): ");
                    break;
            }

        }*/

        // Tehtävä 6/ Bonuspiste
        /* static void Main(string[] args)
         {
             Console.Write("Syötä bonuspiste välillä 1-9: ");
             int bonus = int.Parse(Console.ReadLine());
             switch (bonus)
             {
                 case 1:
                 case 2:
                 case 3:
                     Console.WriteLine("Uusi bonuspisteesi: " + bonus * 10);
                     break;
                 case 4:
                 case 5:
                 case 6:
                     Console.WriteLine("Uusi bonuspisteesi: " + bonus * 100);
                     break;
                 case 7:
                 case 8:
                 case 9:
                     Console.WriteLine("Uusi bonuspisteesi:" + bonus * 1000);
                     break;
                 default:
                     Console.WriteLine("Virhe! Ole hyvä ja anna bonuspiste välillä 0-9.");
                     break;
             }
         }*/

        // Tehtävä 7/ numerot sanoina/ katso uudestaan
        static void Main(string[] args)
        {
            string lause = "";
            Console.Write("Anna numero välillä 0 - 999: ");
            string nro = Console.ReadLine();
            int maara = nro.Length;  // Length !
            if (maara == 3)  // Sadat
            {
                lause += Sadat(nro[0]);
                if (nro[1] == '1')
                {
                    lause += Poikkeukset(nro[2]);
                }
                else
                {
                    lause += Kymmenet(nro[1]);
                    lause += Ykkoset(nro[2]);
                }

            }
            else if (maara == 2)  // Kymmenet
            {
                Console.WriteLine("Nro[0] = " + nro[0]);
                if (nro[0] == '1')
                {
                    lause += Poikkeukset(nro[1]);
                }
                else
                {
                    lause += Kymmenet(nro[0]);
                    lause += Ykkoset(nro[1]);
                }
            }
            else        // Ykkoset
            {
                lause += Ykkoset(nro[0]);
            }

            Console.WriteLine(lause);
            static string Sadat(int luku)
            {
                switch (luku)
                {
                    case '9':
                        return "yhdeksansataa ";
                    case '8':
                        return "kahdeksansataa ";
                    case '7':
                        return "seitsemänsataa ";
                    case '6':
                        return "kuusisataa ";
                    case '5':
                        return "viisisataa ";
                    case '4':
                        return "neljäsataa ";
                    case '3':
                        return "kolmesataa ";
                    case '2':
                        return "kaksisataa ";
                    case '1':
                        return "sata ";
                    default:
                        return "";
                }
            }

            static string Kymmenet(int luku)
            {
                switch (luku)
                {
                    case '9':
                        return "yhdeksänkymmentä ";
                    case '8':
                        return "kahdeksankymmentä ";
                    case '7':
                        return "seitsemänkymmentä ";
                    case '6':
                        return "kuusikymmentä ";
                    case '5':
                        return "viisikymmentä ";
                    case '4':
                        return "neljäkymmentä ";
                    case '3':
                        return "kolmekymmentä ";
                    case '2':
                        return "kaksikymmentä ";
                    case '1':
                        return "kymmenen ";
                    default:
                        return "";
                }
            }

            static string Ykkoset(int luku)
            {
                switch (luku)
                {
                    case '9':
                        return "yhdeksän ";
                    case '8':
                        return "kahdeksän ";
                    case '7':
                        return "seitsemän ";
                    case '6':
                        return "kuusi ";
                    case '5':
                        return "viisi ";
                    case '4':
                        return "neljä ";
                    case '3':
                        return "kolme ";
                    case '2':
                        return "kaksi ";
                    case '1':
                        return "yksi ";
                    default:
                        return "";
                }
            }

            static string Poikkeukset(int luku)  // <- vaikea
            {
                switch (luku)
                {
                    case '9':
                        return "yhdeksäntoista ";
                    case '8':
                        return "kahdeksäantoista ";
                    case '7':
                        return "seitsemäntoista ";
                    case '6':
                        return "kuusitoista ";
                    case '5':
                        return "viisitoista ";
                    case '4':
                        return "neljätoista ";
                    case '3':
                        return "kolmetoista ";
                    case '2':
                        return "kaksitoista ";
                    case '1':
                        return "yksitoista ";
                    default:
                        return "";
                }
            }
        }
    }
}

