using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string ifadelerin içine yazılan 
            "\n" bir satır alta geçilmesini sağlar
            */
            Console.WriteLine("İşlem Seçiniz\n");
            
            // İşlem Menüsü
            Console.WriteLine("1. Satış Bürosu\n2. Muhasebe Bürosu\n3. İnsan Kaynakları\n4. Müşteri Temsilcisi");
            byte secim = Convert.ToByte(Console.ReadLine());
            string cikti;

            switch (secim)
            {
                case 1:
                    cikti = "Satış'a Yönlendiriliyorsunuz.";
                    break;
                case 2:
                    cikti = "Muhasebe'ye Yönlendiriliyorsunuz.";
                    break;
                case 3:
                    cikti = "İnsan Kaynaklarına Yönlendiriliyorsunuz.";
                    break;
                case 4:
                    cikti = "Müşteri Temsilcisine Yönlendiriliyorsunuz.";
                    break;

                default:
                    cikti = "Yanlış Giriş \nMüşteri Temsilcisine Yönlendiriliyorsunuz.";
                    break;
            }
            Console.WriteLine(cikti);

            Console.ReadKey();
        }
    }
}
