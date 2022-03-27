using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class ClassDemoExecutor
    {
        static void Main(string[] args)
        {
            #region Commented code
            //Student Rahul = new Student(1, "rahul");
            //Rahul.SetName("rahul kumar");
            //Rahul.SetRollNo(2);
            //Console.WriteLine(Rahul.GetName());
            //Console.WriteLine(Rahul.GetRollNo());
            //Customer Ramesh = new Customer("Raju");
            //Console.WriteLine("Enter some value for property");
            //Ramesh.MyProperty = int.Parse(Console.ReadLine());
            //Console.WriteLine(Ramesh.MyProperty);
            //Console.WriteLine()
            //Console.ReadKey();
            #endregion
            Customer Raju = new Customer("Raju");
            Console.WriteLine(Raju.Name);
            Console.ReadKey();
        }
    }
}
