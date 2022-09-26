namespace CreationalPatterns.AbstractFactory
{
    internal class MediumSeat : ISeat
    {
        string ISeat.GetSeatFunction() => "medium seat";
    }
}
