using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace IBl
{
    public static class Cloning
    {
        public static Order Clone(this Order original)
        {
            Order target = new Order();
            target = original;
            return target;
        }

        public static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest();
            target = original;
            return target;
        }

        public static Host Clone(this Host original)
        {
            Host target = new Host();
            target = original;
            return target;
        }

        public static HostingUnit Clone(this HostingUnit original)
        {
            HostingUnit target = new HostingUnit();
            target = original;
            return target;
        }

        //and so on for each entity… 
    }
}
