using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models.Abstraction;
using BusinessLogic.Models.ConcreteImplementations;
using BusinessLogic.Models.Enums;

namespace Strategy.ImprovedContext
{
    //This is updated Strategy Context where we do not need to pass Strategy instance to the Constructor.
    //This however brings certain overhead as we need to instantiate all Strategies when creating an instance of Strategy Context.
    public class UpdatedStrategyContext
    {
        private readonly Dictionary<StrategyType, StrategyAbstraction> _strategies =
            new Dictionary<StrategyType, StrategyAbstraction>();

        public UpdatedStrategyContext()
        {
            SetStrategies();
        }

        private void SetStrategies()
        {
            _strategies.Add(StrategyType.StrategyA, new StrategyA());
            _strategies.Add(StrategyType.StrategyB, new StrategyB());
            _strategies.Add(StrategyType.StrategyC, new StrategyC());
        }

        public void RunStrategy(StrategyType strategyType)
        {
            _strategies[strategyType].RunStrategy();
        }
    }
}
