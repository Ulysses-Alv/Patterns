namespace StrategyPattern
{
    public class Consumer
    {
        Strategy strategy;

        public Consumer(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoFunction()
        {
            strategy.ExampleFunction();
        }
    }
}