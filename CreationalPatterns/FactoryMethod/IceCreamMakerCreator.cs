namespace CreationalPatterns.FactoryMethod
{
    internal static class IceCreamMakerCreator
    {
        internal static IceCreamMaker CreateIceCreamMaker(int option)
        {
            if(option == 1)
                return new VanillaIceCreamMaker();
            else if(option == 2)
                return new ChocolateIceCreamMaker();
            else if (option == 3)
                return new StrawberryIceCreamMaker();

            throw new Exception();
        }
    }
}
