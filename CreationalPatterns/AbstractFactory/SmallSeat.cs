namespace CreationalPatterns.AbstractFactory
{
    internal class SmallSeat : ISeat
    {
        string ISeat.GetSeatFunction() => "small seat";
    }
}
