using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj kraj");
            string kraj = Console.ReadLine().ToLower();

            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane = new WebClient().DownloadString(sciezka);
            string[] wiersze = dane.Split('\n');
            List<string> imionaNazwiska = new List<string>();

            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    imionaNazwiska.Add($"{komorki[2]} {komorki[3]}");
            }

            string sciezkaWynik = @"c:\dane\kraje";

            if (!Directory.Exists(sciezkaWynik))
                Directory.CreateDirectory(sciezkaWynik);
            
            File.WriteAllLines($@"{sciezkaWynik}\{kraj}.txt", imionaNazwiska);

        }
    }
}
