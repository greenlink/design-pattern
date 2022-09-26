namespace CreationalPatterns.FactoryMethod
{
    internal class OrderIceCreamRunner
    {
        internal void RunProgram()
        {
            Console.WriteLine("---------- Welcome to Our Ice Cream Store ----------");
            Console.WriteLine("Choose an ice cream flavor: ");
            Console.WriteLine("1 - Vanilla");
            Console.WriteLine("2 - Chocolate");
            Console.WriteLine("3 - Strawberry");

            if (!int.TryParse(Console.ReadLine(), out var option))
                Console.WriteLine("Please type a number.");

            Console.WriteLine("-------------- Manufacturing Ice Cream --------------");

            try
            {
                var iceCreamMaker = IceCreamMakerCreator.CreateIceCreamMaker(option);
                iceCreamMaker.MakeIceCream();
                var iceCream = iceCreamMaker.DeliverIceCream();
                Console.WriteLine($"Here is your ice cream with a {iceCream.GetFlavor()} flavor.");
            }
            catch
            {
                Console.WriteLine("There is no flavor with this option.");
            }
        }
    }
}
