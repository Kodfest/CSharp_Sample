using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            char c;

            while (state)
            {
                // https://github.com/Kodfest/CSharp_Sample/tree/master/ConditionalOperator3
                // switch case yapısı örneğîne whîle döngüsü yardmıyla devamlılık eklendî
                 
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

                Console.WriteLine("Yenı ıslem yapmak ıstıyor musunuz? (e/h)");
                c = Convert.ToChar(Console.ReadLine());

                if (c == 'e')
                    state = true;
                else
                    state = false;           
            }
        }
    }
}
