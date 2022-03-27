using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern
{
    class Context
    {
        private IStrategy _strategy;
        public Context()
        { }
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public List<String> ContextSort(List<String> list)
        {
            List<String> sortedList = this._strategy.Sort(list) as List<String>;
            return sortedList;


        }
    }
}
