namespace CreationalPatterns.AbstractFactory
{
    internal class LowBack : IBack
    {
        string IBack.GetBackFuntion() => "low back";
    }
}
