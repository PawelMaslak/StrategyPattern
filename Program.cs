#region Description

//Strategy is a behavioral design pattern that turns a set of behaviors into objects and makes them interchangeable inside original context object.

//The original object, called context, holds a reference to a strategy object.
//The context delegates executing the behavior to the linked strategy object.
//In order to change the way the context performs its work, other objects may replace the currently linked strategy object with another one.

#endregion

#region BasicStrategyExample

using BusinessLogic.Models.ConcreteImplementations;
using BusinessLogic.Models.Enums;
using Strategy.BasicExample;
using Strategy.ImprovedContext;
using static System.Console;

WriteLine($"Basic Strategy Example:");

BasicStrategyContext context = new BasicStrategyContext();
context.SetStrategy(new StrategyA());
context.RunStrategy();
context.SetStrategy(new StrategyB());
context.RunStrategy();

#endregion

#region UpdatedStrategyContext

WriteLine($"Updated Strategy Example:");
UpdatedStrategyContext updatedStrategyContext = new UpdatedStrategyContext();
updatedStrategyContext.RunStrategy(StrategyType.StrategyA);
updatedStrategyContext.RunStrategy(StrategyType.StrategyB);

#endregion

#region DelegateStrategyContext

WriteLine($"Delegate Strategy Example using generic Func<T> delegate:");
DelegateStrategyContext delegateStrategyContext = new DelegateStrategyContext();
delegateStrategyContext.RunStrategy(StrategyType.StrategyA);
delegateStrategyContext.RunStrategy(StrategyType.StrategyB);

#endregion