using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadanieKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            Console.WriteLine("Pdaj równanie");
            string r = Console.ReadLine();

            try
            {
                double wynik = k.Policz(r);
                Console.WriteLine(wynik);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();


        }
    }
}
