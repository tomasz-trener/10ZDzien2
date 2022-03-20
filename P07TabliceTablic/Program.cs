using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07TabliceTablic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tablicaDwuWymiarowa = new string[2, 3];

            string[][] tablicaTablic = new string[3][];

            tablicaTablic[0] = new string[2];
            tablicaTablic[1] = new string[1];
            tablicaTablic[2] = new string[3];

            tablicaTablic[0][0] = "a";
            tablicaTablic[0][1] = "b";

            tablicaTablic[1][0] = "c";

            tablicaTablic[2][0] = "d";
            tablicaTablic[2][1] = "e";
            tablicaTablic[2][2] = "f";

            for (int i = 0; i < tablicaTablic.Length; i++)
            {
                string[] t = tablicaTablic[i];
                for (int j = 0; j < t.Length; j++)
                    Console.Write(t[j]);
                
                Console.WriteLine();
            }
            Console.ReadKey();

            // tablica tablic = tablica postrzępiona = jagged array 

            // moja subiektywna opinia -> tablice tablic 


            // w przypadku list nie ma list dwuwymiarowych!!
            // są listylisty 

            List<List<string>> listaList = new List<List<string>>();

        }
    }
}
