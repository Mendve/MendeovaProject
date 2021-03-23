using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    class ItemDiscountOnPurchase
    {
        public DayOfWeek Day { get; set; }
        public double Discount { get; set; }

        public ItemDiscountOnPurchase(DayOfWeek day, double discount)
        {
            Day = day;
            Discount = discount;
        }
    }
}
