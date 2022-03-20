using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            string adres = "https://www.google.com/search?q=pogoda warszawa";
            string dane = new WebClient().DownloadString(adres);
            File.WriteAllText(@"c:\dane\pogoda.html",dane);

        }
    }
}
