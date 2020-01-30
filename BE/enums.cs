using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
        public enum AREA { All, North, South, Center, Jerusalem };
        public enum TYPE { Zimmer, Hotel, Camping };
   
        public enum COLLECTIONS_CLEARANCE { Yes, No };
        public enum ORDER_STATUS { BeforeChecking, MailSent, ClosedWithoutResponed, ClosedWithResponed }
}
