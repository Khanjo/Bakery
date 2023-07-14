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