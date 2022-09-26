// See https://aka.ms/new-console-template for more information

using CreationalPatterns.AbstractFactory;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.Singleton;

Console.WriteLine("---------- Choose your application ----------");
Console.WriteLine("1 - Customized gamer chair retailer");
Console.WriteLine("2 - Order Ice Cream");
Console.WriteLine("3 - Internet Protocol status");
Console.WriteLine("");
Console.WriteLine("Input the number of the choosen application: ");

if(!int.TryParse(Console.ReadLine(), out var option))
    Console.WriteLine("Please type a number.");

Console.WriteLine("");
Console.WriteLine($"Option choosed: {option}");

if(option == 1)
{
    new CustomizedGamerChairRetailerRunner().RunProgram();
}
else if (option == 2)
{
    new OrderIceCreamRunner().RunProgram();
}
else if (option == 3)
{
    new InternetProtocolRunner().RunProgram();
}
else
{
    Console.WriteLine("Option unavailable.");
}
