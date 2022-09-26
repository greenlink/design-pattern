namespace CreationalPatterns.FactoryMethod
{
    internal class ChocolateIceCreamMaker : IceCreamMaker
    {
        internal override void MakeIceCream() => _iceCream = new IceCream("chocolate");
    }
}
