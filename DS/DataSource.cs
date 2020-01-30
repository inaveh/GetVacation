using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DS
{
    public class DataSource
    {
        public static List<Order> listOfOrders = new List<Order>
        {
            new Order
            {

            }
        };

        public static List<GuestRequest> listOfRequests = new List<GuestRequest>
        {
            new BE.GuestRequest
            {

                PrivateName="שלומי",FamilyName="בן",MailAddress="shlo@gmail.com",Status=true,
                RegistrationDate=new DateTime(2020,01,14),EntryDate=new DateTime(2019,01,01),
                ReleaseDate=new DateTime(2019,01,03),Area=AREA.Jerusalem,Type=TYPE.Camping,
                Adults=2,Children=0,Pool=true,ChildrenAttractions=false,GuestRequestKey=10000006
            },

                 new BE.GuestRequest()
            {
                PrivateName="חיים",FamilyName="כהן",MailAddress="cha@gmail.com",Status=true,
                RegistrationDate=new DateTime(2019,04,14),EntryDate=new DateTime(2019,05,10),
                ReleaseDate=new DateTime(2019,05,16),Area=AREA.Center,Type=TYPE.Hotel,
                Adults=2,Children=2,Pool=true,ChildrenAttractions=false,GuestRequestKey=10000005
            }
        };

        public static List<Host> listOfHosts = new List<Host>
        {
            new BE.Host()
            {
                PrivateName="יעקב",FamilyName="דניאלי",PhoneNumber="05065168456",
                MailAddress ="12yaacc@yahoo.com",BankAccountNumber="701326",
                CollectionClearance =true
            },
            new BE.Host()
            {
                PrivateName="חגי",FamilyName="דויד",PhoneNumber="0591356482",
                MailAddress ="chgi@gmail.com",BankAccountNumber="7012394",
                CollectionClearance =true
            },
        };

        public static List<HostingUnit> listOfUnits = new List<HostingUnit>
        {
        new BE.HostingUnit
            {
                 HostingUnitName="בראשית",Type=TYPE.Hotel,Area=AREA.Jerusalem,Owner=new Host()
                 {
                        PrivateName="יעקב",FamilyName="דניאלי",PhoneNumber="05065168456",
                        MailAddress ="12yaacc@yahoo.com",BankAccountNumber="701326",
                        CollectionClearance =true
                 }
            },
                 new BE.HostingUnit()
            {
                 HostingUnitName="שמות",Type=TYPE.Zimmer,Area=AREA.South, Owner=new Host()
                 {
                         PrivateName="חגי",FamilyName="דויד",PhoneNumber="0591356482",
                        MailAddress ="chgi@gmail.com",BankAccountNumber="7012394",
                        CollectionClearance =true
                 },
            },
        };


    }
}
