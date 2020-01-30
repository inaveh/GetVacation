using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        public int HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public BankBranch BankBranchDetails { get; set; }
        public string BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }

        public override string ToString()
        {
            return "host key: " + HostKey + "/n" +
                   "name of the host: " + PrivateName +" "+ FamilyName + "/n" +
                   "phone number: " + PhoneNumber + "/n" +
                   "mail address: " + MailAddress+ "/n" +
                   "bank branch details: " +BankBranchDetails + "/n" +
                   "bank account number: " + BankAccountNumber + "/n" +
                   "collection clearance: " + CollectionClearance + "/n";
        }
    }
}
