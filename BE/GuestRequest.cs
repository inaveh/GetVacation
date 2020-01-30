using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public int GuestRequestKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public bool Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public AREA Area { get; set; }
        public TYPE Type { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public bool Pool { get; set; }
        public bool ChildrenAttractions { get; set; }

        public override string ToString()
        {
            return "name of the customer: " + PrivateName + " " + FamilyName + "/n" +
                   "mail address: " + MailAddress + "/n" +
                   "status: " + Status + "/n" +
                   "registrationDate: " + RegistrationDate + "/n" +
                   "entryDate: " + EntryDate + "/n" +
                   "releaseDate: " + ReleaseDate + "/n" +
                   "area: " + Area + "/n" +
                   "type: " + Type + "/n" +
                   "adults: " + Adults + "/n" +
                   "children: " + Children + "/n" +
                   "pool: " + Pool + "/n" +
                   "childrenAttractions: " + ChildrenAttractions + "/n";
        }
    }
}
