using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rakamlar: ");

            for (int i = 0; i < 10; i++)
            {
                // i değerini ekrana yazıp bir boşluk bırakıyor
                Console.Write(i + " ");
            }

            char c;
            Console.Write("\n\nHarfler: ");

            for (c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");
            }

            Console.ReadKey();
        }
    }
}
