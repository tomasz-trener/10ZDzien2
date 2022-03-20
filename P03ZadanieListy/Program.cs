using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieListy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę o wcztanie dowolnego zdania");
            string zdanie = Console.ReadLine().ToLower();

            string[] tab = zdanie.Split(' ');

            List<string> znalezione = new List<string>();
            const char literka = 'a'; // const oznacza, ze progrmista nie bedzie mógł tej zmiennej zmienić

            for (int i = 0; i < tab.Length; i++)
                if (tab[i].Contains(literka))
                    znalezione.Add(tab[i]);

            string znalezioneElementy = string.Join(" ", znalezione);
            Console.WriteLine(znalezioneElementy);

            Console.ReadKey();

        }
    }
}
