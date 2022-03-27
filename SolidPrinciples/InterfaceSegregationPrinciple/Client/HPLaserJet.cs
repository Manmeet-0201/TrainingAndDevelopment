using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Client
{
    class HPLaserJet : IPrintTasks, IFaxContent
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("HPLaserJet Fax done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("HPLaserJet PhotoCopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("HPLaserJet Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
