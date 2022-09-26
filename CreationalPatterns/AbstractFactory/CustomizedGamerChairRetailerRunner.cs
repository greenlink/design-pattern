using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    internal class CustomizedGamerChairRetailerRunner
    {
        internal void RunProgram()
        {
            Console.WriteLine("---------- Welcome to Our Custom Gamer Chair Shop ----------");
            Console.WriteLine("Type your height in centimeters: ");

            if (!int.TryParse(Console.ReadLine(), out var height))
                Console.WriteLine("Please type a number.");

            Console.WriteLine($"Your height is {height} cm.");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Type your weight in kilos: ");

            if (!int.TryParse(Console.ReadLine(), out var weight))
                Console.WriteLine("Please type a number.");

            Console.WriteLine($"Your weight is {weight} Kg.");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("-------------- Manufacturing your gamer chair --------------");
            var chairFactory = ChairFactoryCreator.CreateFactory(height, weight);
            var chairBack = chairFactory.CreateBack();
            var chairSeat = chairFactory.CreateSeat();
            Console.WriteLine("------------------------ Completed -------------------------");
            Console.WriteLine($"Your gamer chair has a {chairBack.GetBackFuntion()}, and a {chairSeat.GetSeatFunction()}.");
        }
    }
}
