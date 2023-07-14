using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int PastryCount { get; }
        public Pastry(int count)
        {
            PastryCount = count;
        }
        public int PastryCost()
        {
            int price = 2 * PastryCount;
            return price;
        }
        public int PastryDiscount(int price)
        {
            int freePastry = (int)Math.Floor((double)PastryCount / 4);
            int freePastryValue = freePastry * 2;
            int discountedPrice = price - freePastryValue;
            return discountedPrice;
        }
    }
}

// static int Pastry()
// {
//     Console.WriteLine("Pastries are $2 each and we currently have a buy 3 get 1 free deal going on!");
//     Console.WriteLine("Please enter how many pastries you would like.");
//     string input = Console.ReadLine();
//     if (Int32.TryParse(input, out int pastryCount))
//     {
//         Pastry pastryOrder = new Pastry(pastryCount);
//         int pastryPrice = pastryOrder.PastryCost();
//         int discountPastryPrice = pastryOrder.PastryDiscount(pastryPrice);
//         Console.WriteLine("The total for your pastries will be:");
//         Console.WriteLine("$" + discountPastryPrice);
//         Console.Read();
//         return discountPastryPrice;
//     }
//     else
//     {
//         Console.WriteLine("Please enter a number");
//         return Pastry();
//     }
// }