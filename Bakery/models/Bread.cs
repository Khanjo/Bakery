using System;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadCount { get; }
        public Bread(int count)
        {
            BreadCount = count;
        }
        public int BreadCost()
        {
            int price = 5 * BreadCount;
            return price;
        }
        public int BreadDiscount(int price)
        {
            int freeBread = (int)Math.Floor((double)BreadCount / 3);
            int freeBreadValue = freeBread * 5;
            int discountedPrice = price - freeBreadValue;
            return discountedPrice;
        }
    }
}