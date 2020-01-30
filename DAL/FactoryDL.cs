using IBl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class FactoryDL
    {
        public static Idal get_imp_Dal(string type)
        {
            switch (type)
            {
                case "list":
                    return Dal_imp.GetInstance();

                //case "xml":
                //    return Dal_XML_imp.GetInstance();

                default:
                    return null;

            }
        }
    }
}
