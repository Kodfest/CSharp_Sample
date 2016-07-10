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

            /*
            Beklenmedik durumlarda yazdığımız kodun patlaması için
            Try Catch kullanarak programımızın hata vermesini önlemiş oluruz.
            */
            try
            {
                // okunan değer integer'a çevirilip number'a atandı
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
            }
            catch (Exception ex)
            {
                // Dönen uyarı mesajı yazdırılıyor
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
