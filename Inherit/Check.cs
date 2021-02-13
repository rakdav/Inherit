using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Check
    {
        public decimal Price { get; set; }
        public int Count { get; set; }
        public Check(decimal price, int count)
        {
            Price = price;
            Count = count;
        }
        public decimal Total()
        {
            return Price * Count;
        }
    }
}
