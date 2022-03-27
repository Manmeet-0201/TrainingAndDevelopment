using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern.ConcreteStrategy
{
    public class AscendingSort : IStrategy
    {
        public object Sort(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
