using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11TypyZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "hej";
            double d = 8.5;
            bool e = false;

            DateTime dt = new DateTime(2021, 12, 30);

           //DateTime dt = new DateTime()

            WebClient wc = new WebClient();
            StringBuilder sb = new StringBuilder("ala");
            sb.Append("ma");
            sb.Append("kota");

            DateTime dt2;

            new DateTime(2022, 01, 10);




        }
    }
}
