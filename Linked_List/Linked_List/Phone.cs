using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Phone
    {
        public string phoneName { get; set; }
        public string phoneNumber { get; set; }
        public decimal phonePrice { get; set; }
        public Phone(string phoneName, string phoneNumber, decimal phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneNumber = phoneNumber;
            this.phonePrice = phonePrice;
        }
    }
}
