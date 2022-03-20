using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieNapisy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");

            string zdanie = Console.ReadLine();

            string[] wyrazy = zdanie.Split(' ');

            int indeksNajdluzszego = 0;
            int najdluzszaWartosc = wyrazy[indeksNajdluzszego].Length;

            for (int i = 1; i < wyrazy.Length ; i++)
                if (wyrazy[i].Length > najdluzszaWartosc )
                {
                    najdluzszaWartosc = wyrazy[i].Length;
                    indeksNajdluzszego = i;
                }
            

            string najdluzszyWyraz = wyrazy[indeksNajdluzszego];
            Console.WriteLine(najdluzszyWyraz);
            Console.ReadKey();

        }
    }
}
