using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Client
{
    class CannonMG2470 : IPrintTasks
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("CannonMG2470 photocopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("CannonMG2470 print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("CannonMG2470 scan Done");
            return true;
        }
    }
}
