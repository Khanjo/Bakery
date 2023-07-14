using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadCount { get; }
        public Bread(int count)
        {
            BreadCount = count;
        }
    }
}