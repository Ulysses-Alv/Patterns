namespace adapter.pattern.vlyx
{
    public class User
    {
        private readonly IAdapterExample adapterExample;
        public User(IAdapterExample adapterExample) => this.adapterExample = adapterExample;
    }

}
