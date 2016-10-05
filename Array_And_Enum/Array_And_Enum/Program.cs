using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_And_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            int[] numbers = new int[30];
            int[] numbers2 = { 14, 15, 16, 17, 18, 19, 20 };

            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = i * 2;
                
            }

            for(int j=0;j<numbers.Length;j++)
            {
                Console.WriteLine(numbers[j].ToString());
            }

            #endregion
            #region Enum
            
            int dayNumber;
            dayNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((weekdays)dayNumber).ToString());  
            #endregion
            Console.ReadKey();
        }
    }
}
