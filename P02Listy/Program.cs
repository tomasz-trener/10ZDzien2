using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[4];

            int n = Convert.ToInt32(Console.ReadLine());
            string[] tab2 = new string[n];


            List<string> lista1 = new List<string>();
            // ile elementów ma ta lista?  odp: 0  (ta lista <> null)

            List<string> lista2; // ta lista = null

            lista1.Add("ala");
            lista1.Add("ma");
            lista1.Add("kota");

            string napis = lista1[1]; // ma
            lista1[1] = "bedzie miala";

            int dlugoscListy = lista1.Count; // inaczej niż tablicach (length)

            // dodawanie na koniec
            lista1.Add("małego");

            // dodawanie w środek
            lista1.Insert(1, "mała"); //ala mała bedzie miała kota małego 

            // usuwanie elemetów

            lista1.RemoveAt(1);
            lista1.Remove("kota"); // usuwa pierwsze wystąpienie danego elementu
            //lista1.RemoveAll() // wymaga zastosowania składni linq, która poznamy później


            List<int> listaLiczb = new List<int>();





        }
    }
}
