using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZdanieManagerTekstu
{
    class ManagerTekstu
    {
        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            string[] wyrazy = zdanie.Split(' ');

            if (wyrazy.Length < 2)
                throw new Exception("Zdanie jest za krótkie");

            int indeksNajdluzszegoWyrazu = 0;
            int najdluzszy = wyrazy[indeksNajdluzszegoWyrazu].Length;

            for (int i = 1; i < wyrazy.Length; i++)
                if (wyrazy[i].Length > najdluzszy)
                {
                    najdluzszy = wyrazy[i].Length;
                    indeksNajdluzszegoWyrazu = i;
                }        
            string najdluzszyWyraz = wyrazy[indeksNajdluzszegoWyrazu];
            return najdluzszyWyraz;
        }

        public string[] ZnajdzWszystkieNajluzszeWyrazy(string zdanie)
        {
            string najdluzszy = ZnajdzNajdluzszyWyraz(zdanie);
            string[] wszystieNajdluzsze = podajWszystkieWyrazyOPodanejDlugosci(najdluzszy.Length, zdanie.Split(' '));
            return wszystieNajdluzsze;
        }

        private string[] podajWszystkieWyrazyOPodanejDlugosci(int dlugosc, string[] wyrazy)
        {
            List<string> znalezione = new List<string>();

            foreach (var w in wyrazy)
                if (w.Length == dlugosc)
                    znalezione.Add(w);
           
            return znalezione.ToArray();
        }

    }
}
