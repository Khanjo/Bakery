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
            Console.WriteLine(WelcomeBanner.Welcome);
            Console.WriteLine("Hello!");
            int discountBreadPrice = 0;
            int discountPastryPrice = 0;
            int total = discountBreadPrice + discountPastryPrice;
            Console.WriteLine("The total for your order will be:");
            Console.WriteLine("$" + total);
            Console.Read();
        }
        static int Bread()
        {
            Console.WriteLine("Please enter how many loaves of bread you would like, they are $5 each and we currently have a buy 2 get 1 free deal going on!");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int breadCount))
            {
                Bread breadOrder = new Bread(breadCount);
                int breadPrice = breadOrder.BreadCost();
                int discountBreadPrice = breadOrder.BreadDiscount(breadPrice);
                return discountBreadPrice;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                Bread();
                return 0;
            }
        }
        static int Pastry()
        {
            Console.WriteLine("Please enter how many pastries you would like, they are $2 each and we currently have a buy 3 get 1 free deal going on!");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int pastryCount))
            {
                Pastry pastryOrder = new Pastry(pastryCount);
                int pastryPrice = pastryOrder.PastryCost();
                int discountPastryPrice = pastryOrder.PastryDiscount(pastryPrice);
                return discountPastryPrice;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                Pastry();
                return 0;

            }
        }
    }
}