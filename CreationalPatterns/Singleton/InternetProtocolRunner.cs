namespace CreationalPatterns.Singleton
{
    internal class InternetProtocolRunner
    {
        internal void RunProgram()
        {
            Console.WriteLine("---------- Creating Internet Connections ----------");
            Console.WriteLine("---------- We have three static connections and three dynamic ----------");
            var staticConnection1 = StaticInternetProtocol.Instance;
            var staticConnection2 = StaticInternetProtocol.Instance;
            var staticConnection3 = StaticInternetProtocol.Instance;

            var dynamicConnection1 = new DynamicInternetProtocol();
            var dynamicConnection2 = new DynamicInternetProtocol();
            var dynamicConnection3 = new DynamicInternetProtocol();
            Console.WriteLine($"Static connection 1 ID: {staticConnection1.GetProtocolIndentification()}");
            Console.WriteLine($"Dynamic connection 1 ID: {dynamicConnection1.GetProtocolIndentification()}");
            Console.WriteLine($"Static connection 2 ID: {staticConnection2.GetProtocolIndentification()}");
            Console.WriteLine($"Dynamic connection 2 ID: {dynamicConnection2.GetProtocolIndentification()}");
            Console.WriteLine($"Static connection 3 ID: {staticConnection3.GetProtocolIndentification()}");
            Console.WriteLine($"Dynamic connection 3 ID: {dynamicConnection3.GetProtocolIndentification()}");
        }
    }
}
