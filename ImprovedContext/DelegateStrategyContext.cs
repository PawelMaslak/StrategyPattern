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
    public class DelegateStrategyContext
    {
        private readonly Dictionary<StrategyType, Func<StrategyAbstraction>> _strategies =
            new Dictionary<StrategyType, Func<StrategyAbstraction>>();

        public DelegateStrategyContext()
        {
            SetStrategies();
        }

        private void SetStrategies()
        {
            _strategies.Add(StrategyType.StrategyA, () => new StrategyA());
            _strategies.Add(StrategyType.StrategyB, () => new StrategyB());
            _strategies.Add(StrategyType.StrategyC, () => new StrategyC());
        }

        public void RunStrategy(StrategyType strategyType)
        {
            _strategies[strategyType].Invoke().RunStrategy();
        }
    }
}
