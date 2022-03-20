using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TabliceWieloWymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // tablice 1-wymiarowe najczęściej 
            // tablice 2-wymiarowe rzadko 
            // tablice 3 i więcej praktycznie nigdy (typowych aplikacjach biznesowych) 

            string[] tablica1 = new string[4];

            string[,] tablica2 = new string[4, 3];
            string[,,] tablica3 = new string[4, 3, 5];


            int dlugoscWym0 = tablica2.GetLength(0); // 4
            int dlugoscWym1 = tablica2.GetLength(1); // 3

            int dlugoscTablicy = tablica2.Length; // 4*3 = 12

            tablica2[0, 0] = "a";
            tablica2[0, 1] = "b";
            tablica2[0, 2] = "c";

            tablica2[1, 0] = "d";
            tablica2[1, 1] = "e";
            tablica2[1, 2] = "f";

            tablica2[2, 0] = "g";
            tablica2[2, 1] = "h";
            tablica2[2, 2] = "i";

            tablica2[3, 0] = "j";
            tablica2[3, 1] = "k";
            tablica2[3, 2] = "l";

            for (int i = 0; i < dlugoscWym0; i++)
            {
                for (int j = 0; j < dlugoscWym1; j++)
                    Console.Write(tablica2[i,j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine("----------");

            for (int i = 0; i < dlugoscWym1; i++)
            {
                for (int j = 0; j < dlugoscWym0; j++)
                    Console.Write(tablica2[j, i] + " ");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
