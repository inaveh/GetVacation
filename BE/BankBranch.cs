using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankBranch
    {

        string BankName { get; set; }
        string BranchNumber { get; set; }
        string BankAddress { get; set; }
        string BranchCity { get; set; }
        public override string ToString()
        {
            return "bank name: " + BankName + "/n" +
                   "branch number: " + BranchNumber + "/n" +
                   "bank address: " + BankAddress + "/n" +
                   "branc city: " + BranchCity + "/n";
        }
    }
}
