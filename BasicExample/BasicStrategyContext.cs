using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models.Abstraction;

namespace Strategy.BasicExample
{
    public class BasicStrategyContext
    {
        private StrategyAbstraction _strategy;


        public void SetStrategy(StrategyAbstraction strategy)
        {
            _strategy = strategy;
        }

        public void RunStrategy()
        {
            _strategy.RunStrategy();
        }
    }
}
