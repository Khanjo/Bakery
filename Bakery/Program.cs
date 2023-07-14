using System;
using System.Collections.Generic;
using Bakery.Models;
using Bakery.UserInterfaceModels;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(WelcomeBanner.Welcome);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Hello!");
            int discountBreadPrice = Bread();
            int discountPastryPrice = Pastry();
            int total = discountBreadPrice + discountPastryPrice;
            Console.WriteLine("The total for your order will be:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + total);
            Console.ResetColor();
            Console.Read();
        }
        static int Bread()
        {
            Console.WriteLine("Bread loaves $5 each and we currently have a buy 2 get 1 free deal going on!");
            Console.WriteLine("Please enter how many loaves of bread you would like.");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int breadCount))
            {
                Bread breadOrder = new Bread(breadCount);
                int breadPrice = breadOrder.BreadCost();
                int discountBreadPrice = breadOrder.BreadDiscount(breadPrice);
                Console.WriteLine("");
                Console.WriteLine("The total for your bread will be:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$" + discountBreadPrice);
                Console.ResetColor();
                Console.WriteLine("");
                return discountBreadPrice;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return Bread();
            }
        }
        static int Pastry()
        {
            Console.WriteLine("Pastries are $2 each and we currently have a buy 3 get 1 free deal going on!");
            Console.WriteLine("Please enter how many pastries you would like.");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int pastryCount))
            {
                Pastry pastryOrder = new Pastry(pastryCount);
                int pastryPrice = pastryOrder.PastryCost();
                int discountPastryPrice = pastryOrder.PastryDiscount(pastryPrice);
                Console.WriteLine("");
                Console.WriteLine("The total for your pastries will be:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$" + discountPastryPrice);
                Console.ResetColor();
                Console.WriteLine("");
                return discountPastryPrice;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return Pastry();
            }
        }
    }
}