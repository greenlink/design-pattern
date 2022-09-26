namespace CreationalPatterns.FactoryMethod
{
    internal class VanillaIceCreamMaker : IceCreamMaker
    {
        internal override void MakeIceCream() => _iceCream = new IceCream("vanilla");
    }
}
