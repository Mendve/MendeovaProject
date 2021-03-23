using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    class ItemDiscountOnFixedPrice
    {
        public double Price { get; set; }
        public double Discount { get; set; }

        public ItemDiscountOnFixedPrice(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }
    }
}
