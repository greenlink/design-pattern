namespace CreationalPatterns.FactoryMethod
{
    internal class StrawberryIceCreamMaker : IceCreamMaker
    {
        internal override void MakeIceCream() => _iceCream = new IceCream("strawberry");
    }
}
