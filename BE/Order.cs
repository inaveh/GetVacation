using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        public int HostingUnitKey { get; set; }
        public int GuestRequestKey { get; set; }
        public int OrderKey { get; set; }
        public int fee { get; set; }
        public ORDER_STATUS OrderStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return "The order key is: " + OrderKey + "/n" +
                   "The status of the order is: " + OrderStatus + "/n" +
                   "The date the order was open: " + CreateDate + "/n" +
                   "The date of the order: " + OrderDate + "/n";
        }
    }
}
