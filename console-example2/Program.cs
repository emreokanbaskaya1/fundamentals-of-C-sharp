
using console_example2;
using System;
    using System.Threading.Tasks;

namespace conosle_example2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(5, 10);
            isl.topla(20, 30);

            isl.kare(5);


            Console.Read();

        }

    }

   
    
}