namespace CreationalPatterns.Singleton
{
    public class DynamicInternetProtocol : IInternetProtocol
    {
        private Guid _id;

        public DynamicInternetProtocol() => _id = Guid.NewGuid();

        public Guid GetProtocolIndentification() => _id;
    }
}
