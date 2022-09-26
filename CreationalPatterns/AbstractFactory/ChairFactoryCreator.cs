namespace CreationalPatterns.AbstractFactory
{
    internal static class ChairFactoryCreator
    {
        internal static ChairFactory CreateFactory(int height, int weight)
        {
            if (height >= 181 || weight >= 101)
                return new BigChairFactory();
            else if (height >= 151 || weight >= 71)
                return new MediumChairFactory();
            else
                return new SmallChairFactory();
        }
    }
}
