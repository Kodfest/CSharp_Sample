using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.AddRange(new int[] { 8, 10, 13, 3, 8 });

            #region YardimciMethodlar
            // aşağıdaki yorum satırlarini teker teker kaldırıp
            // nasıl değişiklikler olduğu inceleyin

            //list.RemoveAt(0); // girilen index silinir
            //list.Remove(8); // girilen değer listeden silinir, birden fazla varsa ilki silinir
            //list.RemoveRange(3, 2); // belirlenen aralık silinir. ilk değer başlangıç index, ikinci değer boyutu belirtir

            //bool varmi = list.Contains(13); //girilen değerin dizide olup olmadığını geri döner
            //if (varmi == true)
            //{
            //    Console.WriteLine("varmış");
            //}

            //var result = list.Find(i => i > 3); // 3 den büyük ilk değeri döner
            //var result = list.FindAll(i => i > 3).ToList(); // 3 den büyük bütün elemanları döner
            //var result = list.FindAll(i => i > 3).Count(); // 3 den büyük elemanların sayısı döner
            //list.RemoveAll(i => i > 3); // 3 den büyük bütün elemanları siler

            //list.Sort(); // listeyi sıralar
            //list.Reverse(); // listeyi ters çevirir
            //list.Clear(); // listeyi temizler
            #endregion

            #region alfabe
            //List<char> alfabe = new List<char>();

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alfabe.Add(i);
            //}

            //alfabe.Reverse();

            //foreach (var item in alfabe)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion


            foreach (var item in list)
            {
                Console.WriteLine("\n\t" + item);
            }

            Console.ReadKey();
        }
    }
}
