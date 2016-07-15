using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/Kodfest/CSharp_Sample/tree/master/ConditionalOperator3
            // switch case yapısı örneğîne whîle döngüsü yardmıyla devamlılık eklendî
            
            string c;

            do
            {
                Console.WriteLine("İşlem Seçiniz\n");

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

                Console.WriteLine("Yenı ıslem yapmak ıstıyor musunuz? (evet|hayır)");
                c = Convert.ToString(Console.ReadLine());
                

            } while (c == "evet");
        }
    }
}
