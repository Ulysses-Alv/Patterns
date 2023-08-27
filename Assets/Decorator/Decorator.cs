public abstract class Decorator : IComponent
{
    private IComponent component;

    public Decorator(IComponent component) { this.component = component; }
    public virtual void Operation() { component.Operation(); }
}
