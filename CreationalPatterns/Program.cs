// See https://aka.ms/new-console-template for more information

using CreationalPatterns.AbstractFactory;

Console.WriteLine("---------- Choose your application ----------");
Console.WriteLine("1 - Customized gamer chair retailer");
Console.WriteLine("2 - Mouse clicker command");
Console.WriteLine("3 - Internet provider availability");
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

