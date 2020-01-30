using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public int UnitKey { get; set; }
        public Host Owner { get; set; }
        public string HostingUnitName { get; set; }
        public TYPE  Type { get; set; }
        public AREA Area { get; set; }
        public bool[,] Diary = new bool[12, 31];
        public override string ToString()
        {
            return "unit key: " + UnitKey + "/n" +
                   "name of the owner: " + Owner.PrivateName +" "+ Owner.FamilyName + "/n" +
                   "name of the unit: " + HostingUnitName + "/n" + "type of the place is:" + Type +"/n" +
                   "Area of the place is:" + Area + "/n";
        }
    }
}
