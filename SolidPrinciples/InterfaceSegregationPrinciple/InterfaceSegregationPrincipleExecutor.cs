using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple.Client;

namespace InterfaceSegregationPrinciple
{
    class InterfaceSegregationPrincipleExecutor
    {
        static void Main(string[] args)
        {
            HPLaserJet hpPrinter = new HPLaserJet();
            hpPrinter.FaxContent("Fax this message");
            CannonMG2470 cannonPrinter = new CannonMG2470();
            cannonPrinter.PhotoCopyContent("Photocopy this Message");
            Console.ReadKey();

        }
    }
}
