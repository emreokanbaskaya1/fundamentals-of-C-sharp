

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();

            kml.AD = "Murat";
            

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);


            Console.Read();

        }
    }
}