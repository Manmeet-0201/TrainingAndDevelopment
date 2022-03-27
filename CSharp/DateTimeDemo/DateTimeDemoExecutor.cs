using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class DateTimeDemoExecutor
    {
        static void Main(string[] args)
        {
            // creating datetime object
            var birthday = new DateTime(1967, 12, 19);
            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference);
            Console.WriteLine(difference.Days);
            var someTime = new DateTime(2017, 10, 18, 9, 51, 32);
            someTime.AddMinutes(134);
            Console.WriteLine(someTime);

        }
    }
}
