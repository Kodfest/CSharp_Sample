using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string tipinde bir şehirler listesi oluşturuldu.
            3 şehir eklendi.
            */
            List<string> Cities = new List<string>();
            Cities.Add("İzmir");
            Cities.Add("İstanbul");
            Cities.Add("Ankara");

            //şeihrler yazdırılıyor
            foreach (var item in Cities)
            {
                Console.WriteLine(item);
            }

            try
            {
                foreach (var item in Cities.ToList())
                {
                    // item listeden çıkarılıyor
                    Cities.Remove(item);
                    Console.WriteLine("{0} çıkarıldı.", item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
