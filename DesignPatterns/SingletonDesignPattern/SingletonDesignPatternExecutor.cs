using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class SingletonDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            Singleton singletonObject1 = Singleton.GetInstance();
            Singleton singletonObject2 = Singleton.GetInstance();
            if (singletonObject1 == singletonObject2)
            {
                Console.WriteLine("They are same instance");
            }
            else
            {
                Console.WriteLine("They are not same instance");
            }
            Console.ReadKey();
        }
    }
}
