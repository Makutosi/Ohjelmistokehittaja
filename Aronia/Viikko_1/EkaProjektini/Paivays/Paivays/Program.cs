// Dia 9_Harjoituksia_Tehtävä 7/ 25.10.2021
using System;

namespace Paivays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dia 47
            int vuosi, kk, paiva, t, min, sek, millis;
            System.DateTime aika = System.DateTime.Now;
            vuosi = aika.Year;
            kk = aika.Month;
            paiva = aika.Day;
            t = aika.Hour;
            min = aika.Minute;
            sek = aika.Second;
            millis = aika.Millisecond;
            Console.WriteLine("Päivämäärä on " + paiva + "." + kk + "." + vuosi);
            Console.WriteLine("Kellonaika on " + t + ":" + min + ":" + sek);
            Console.WriteLine("Milliekunnit ovat: " + millis);
            // ohjausmerkki \n Rivin vaihto
            Console.WriteLine("\nNyt on " + DateTime.Now.ToString() + ".");// Console.Write?

            // DateTime.Now  M=kuukausi  m=minuutti
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // ToString
            string result = dt.ToString("dd.MM.yyyy HH:mm:ss");
            Console.WriteLine(result);

            // Parse/ ParseExact
            string strTime = "25.10.2021 11.30.00";

            DateTime dTime = DateTime.Parse(strTime);
            Console.WriteLine(dTime);

            strTime = "26.10.2021";
            dTime = DateTime.Parse(strTime);
            Console.WriteLine(dTime);

            strTime = "10.30.00";
            dTime = DateTime.Parse(strTime);
            Console.WriteLine(dTime);

            Console.ReadKey();
        }
    }
}
