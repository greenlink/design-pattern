namespace CreationalPatterns.FactoryMethod
{
    internal abstract class IceCreamMaker
    {
        protected IIceCream _iceCream;
        
        internal abstract void MakeIceCream();

        internal IIceCream DeliverIceCream() => _iceCream;
    }
}
