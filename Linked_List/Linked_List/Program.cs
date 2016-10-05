using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Phone> _linkedList = new LinkedList<Phone>();

            Phone phone1 = new Phone("Apple Iphone 6S","0506 158 17 73",3250);
            Phone phone2 = new Phone("LG G3 32GB","0506 158 17 74",1500);
            Phone phone3 = new Phone("LUMIA 950 XL","0506 158 17 75",2400);

            _linkedList.AddLast(phone1);
            _linkedList.AddLast(phone2);
            _linkedList.AddLast(phone3);

            foreach(var item in _linkedList)
            {
                Console.WriteLine(item.phoneName);
            }
            Console.ReadKey();
        }

    }
}
