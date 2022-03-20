using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieTabliceWieloWymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(sciezka);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbWierszy = wiersze.Length - 1;
            int liczbaKolumn = wiersze[0].Split(';').Length;

            string[,] tab = new string[liczbWierszy, liczbaKolumn];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                for (int j = 0; j < komorki.Length; j++)
                    tab[i - 1, j] = komorki[j];
            }

            Console.WriteLine("wyświetlenie");

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                    Console.Write(tab[i,j] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
