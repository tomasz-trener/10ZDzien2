using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZdanieManagerTekstu
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerTekstu mt = new ManagerTekstu();

            Console.WriteLine("Podaj zdanie");
            string zdane = Console.ReadLine();

            try
            {
                string w1 = mt.ZnajdzNajdluzszyWyraz(zdane);
                string[] w2 = mt.ZnajdzWszystkieNajluzszeWyrazy(zdane);

                Console.WriteLine($"Najdluzszy wyraz: {w1}");
                Console.WriteLine("---------");
                Console.WriteLine($"Wszystkie najdluzsze wyrazy: {string.Join(", ", w2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

 
            Console.ReadKey();

        }
    }
}
