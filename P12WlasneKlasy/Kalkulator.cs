using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12WlasneKlasy
{
    class Kalkulator
    {
        // możemy tutaj zadeklarować 4 elementy 

        //1) pola -> cechy obiektu (właściwości) 
        //2) właściwości -> to samo co pola ale bardziej rozbudowane 
        //3) konstruktory -> w jaki sposób możemy tworzyć dany obiekt
        //4) metody -> co dany obiekt potrafi zrobić 

        private int dodaj(int a, int b)
        {
            string s = "ala ma kota";
            s = s.ToUpper();

            int c = a + b;

            return c;
        }

        public int Przemnoz(int a, int b)
        {
            //return a * b;
            int wynik = 0;
            for (int i = 0; i < b; i++)
                wynik = dodaj(wynik, a);

            return wynik;

        }

        public int Odejmij(int a, int b)
        {
            return a - b;
        }


    }
}
