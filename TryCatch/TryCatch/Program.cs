using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[4];
            //Console.WriteLine(array[5]);


            //try
            //{
            //    int[] array = new int[4];
            //    Console.WriteLine(array[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.Write("Bir Sayı Girin:");
            //try
            //{
            //    int i = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("final Bölümü");
            //}


            //try
            //{
            //    throw new FormatException();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            bool state = false;
            while (!state)
            {
                int i;
                state = Int32.TryParse(Console.ReadLine(), out i);

                if (state == false)
                {
                    Console.WriteLine("Hatali Giriş");
                }
            }

        }
    }
}
