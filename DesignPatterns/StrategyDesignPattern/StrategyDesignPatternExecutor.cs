using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.ConcreteStrategy;
using StrategyDesignPattern.Strategy;
namespace StrategyDesignPattern
{
    class StrategyDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            Context contextObject = new Context();
            List<String> list = new List<String>() { "India", "USA", "UK" };
            contextObject.SetStrategy(new AscendingSort());
            List<String> sortedList = contextObject.ContextSort(list);
            foreach (string str in sortedList)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
