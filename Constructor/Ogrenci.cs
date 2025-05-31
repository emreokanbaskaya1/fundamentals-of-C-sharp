using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Ogrenci
    {
        public Ogrenci(string bilgi)
        {
            string blg;
            Console.Write("Ad - Kulüp: ");
            blg = Console.ReadLine();
            Console.WriteLine(blg);
            Console.WriteLine("Bilgi: " + bilgi);
            Console.WriteLine("Soyad: Yılmaz");
            Console.WriteLine("Meslek: Öğretmen");
        }
    }
}
