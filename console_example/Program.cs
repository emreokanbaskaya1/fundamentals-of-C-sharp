using System;

namespace console_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan veri alma
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadınızı girin: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşınızı girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            // Kisiler sınıfından nesne oluşturma ve metodu çağırma
            Kisiler ks = new Kisiler();
            ks.kisiListesi(ad, soyad, yas);
        }
    }
}