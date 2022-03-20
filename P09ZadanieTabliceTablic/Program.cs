using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieTabliceTablic
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(sciezka);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length - 1;

            string[][] tab = new string[liczbaWierszy][];

            for (int i = 1; i <= liczbaWierszy; i++)
                tab[i-1] = wiersze[i].Split(';');

            Console.WriteLine("-- wyświetlenie danych --");
            //for (int i = 0; i < tab.Length; i++)
            //    Console.WriteLine(string.Join(" ", tab[i]));

            foreach (var k in tab)
                Console.WriteLine(string.Join(" ",k));

            Console.ReadKey();
        }
    }
}
