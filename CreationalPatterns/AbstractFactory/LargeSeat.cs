namespace CreationalPatterns.AbstractFactory
{
    internal class LargeSeat : ISeat
    {
        string ISeat.GetSeatFunction() => "large seat";
    }
}
