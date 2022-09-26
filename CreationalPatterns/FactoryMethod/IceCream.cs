namespace CreationalPatterns.FactoryMethod
{
    internal class IceCream : IIceCream
    {
        private string _flavor;

        public IceCream(string flavor) => _flavor = flavor;

        string IIceCream.GetFlavor() => _flavor;
    }
}
