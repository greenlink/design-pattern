namespace CreationalPatterns.AbstractFactory
{
    internal class SmallChairFactory : ChairFactory
    {
        internal override IBack CreateBack() => new LowBack();

        internal override ISeat CreateSeat() => new SmallSeat();
    }
}
