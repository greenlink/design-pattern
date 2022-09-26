namespace CreationalPatterns.AbstractFactory
{
    internal abstract class ChairFactory
    {
        internal abstract IBack CreateBack();
        internal abstract ISeat CreateSeat();
    }
}
