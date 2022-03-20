using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            //  File.WriteAllText(@"c:\dane\pogoda.html",dane);

            const char znak = '°';
            const string znakKoncowy = ">";

            while (true)
            {
                Console.WriteLine("Podaj nazwe miasta");
                string nazwaMiasta = Console.ReadLine();
                string adres = $"https://www.google.com/search?q=pogoda {nazwaMiasta}";
                string dane = new WebClient().DownloadString(adres);

                int indx = dane.IndexOf(znak);
                int aktualnaPoz = indx;

                while (dane.Substring(aktualnaPoz, 1) != znakKoncowy)
                    aktualnaPoz--;

                string wynik = dane.Substring(aktualnaPoz + 1, indx + 1 - aktualnaPoz);
                Console.WriteLine(wynik);
            }
            
            

        }
    }
}
