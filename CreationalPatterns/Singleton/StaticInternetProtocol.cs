namespace CreationalPatterns.Singleton
{
    public class StaticInternetProtocol : IInternetProtocol
    {
        private static Guid _id;
        private static StaticInternetProtocol _instance;

        private StaticInternetProtocol() => _id = Guid.NewGuid();

        public static StaticInternetProtocol Instance => GetInstance();

        private static StaticInternetProtocol GetInstance()
        {
            if(_instance == null)
                _instance = new StaticInternetProtocol();

            return _instance;
        }

        public Guid GetProtocolIndentification() => _id;
    }
}
