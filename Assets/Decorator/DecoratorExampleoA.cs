namespace Decorator
{
    public class DecoratorExampleoA : Decorator
    {
        public DecoratorExampleoA(IComponent component) : base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
        }

    }
}