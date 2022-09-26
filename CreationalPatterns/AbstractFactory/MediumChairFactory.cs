namespace CreationalPatterns.AbstractFactory
{
    internal class MediumChairFactory : ChairFactory
    {
        internal override IBack CreateBack() => new MediumBack();

        internal override ISeat CreateSeat() => new MediumSeat();
    }
}
