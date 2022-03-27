using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface IPrintTasks
    {
        bool PrintContent(String content);
        bool ScanContent(String content);
        bool PhotoCopyContent(String content);


    }
}
