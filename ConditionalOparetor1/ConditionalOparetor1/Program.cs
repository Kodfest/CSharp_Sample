using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOparetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); // word'e okunan değer atanır

            /*
             ? öncesinde koşul belirtilir.
             Bu kodda okuduğumuz değerin uzunluğu (karakter sayısı) 5'e eşit ve küçükse 
             koşul True değer alır ve ? : arasındaki ilk kısım çalışır.
             Eğer 5'den daha büyükse koşul False değer alır 
             ve : sonrasındaki kısım çalışır.
             
            Kodda eklediğimiz word den önceki True ve False değerlerinin 
            özel bir anlamaı yoktur. İfadeleri vurgulamak için eklenmiştir.
            */
            word = word.Length <= 5 ? "True " + word : word = "False " + "Uzunluk 5'den büyük";

            Console.WriteLine(word); // word'ün son hali ekrana yazılır.

            Console.ReadKey(); //Ekran bir tuşa basılana kadar bekletilir.
        }
    }
}
