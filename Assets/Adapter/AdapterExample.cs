namespace adapter.pattern.vlyx
{
    public class AdapterExample : IAdapterExample
    {
        public string Example()
        {
            return AdaptedClass.nameExample;
        }
    }
}