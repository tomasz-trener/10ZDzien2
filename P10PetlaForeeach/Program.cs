using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10PetlaForeeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("petla for");
            string[] tablica = new string[3] { "ala", "ma", "kota" };
            for (int i = 0; i < tablica.Length; i++)
                Console.WriteLine(tablica[i]);

            Console.WriteLine("petle foreach");
            foreach (string k in tablica)
                Console.WriteLine(k);

            // zalety : jest prościej (składnia jest prostsza) 
            // wady: musimy iterować dla każdego , kolejność jest niezmienna 

            var a = 4; // to znaczy, że a jest typu int
            var b = "ala ma kota"; // to b jest typu string 

            // to nie jest typ dynamiczny 
            //a = "a";

            a = a + 5;

            var typ = new List<string[]>();
            List<string[]> typ2 = new List<string[]>();

          

        }
    }
}
