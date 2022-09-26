namespace CreationalPatterns.AbstractFactory
{
    internal class BigChairFactory : ChairFactory
    {
        internal override IBack CreateBack() => new TallBack();

        internal override ISeat CreateSeat() => new LargeSeat();
    }
}
