using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Girin");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Sıfır Girildi.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negatif Sayı Girildi.");
            }
            else
            {
                Console.WriteLine("Pozitif Sayı Girildi.");
            }

            Console.ReadKey();
        }
    }
}
