using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    public class DiscountOnFixedPrice : ISpecialOffers
    {
        private static List<ItemDiscountOnFixedPrice> items = new List<ItemDiscountOnFixedPrice>{
            new ItemDiscountOnFixedPrice(100.0, 10.0),
            new ItemDiscountOnFixedPrice(500.0, 20.0),
            new ItemDiscountOnFixedPrice(200.0, 15.0)
            };

        public DiscountOnFixedPrice()
        {

        }

        public double ApplySpecialOffer(List<Item> receipt, double totalPrice)
        {

            foreach (ItemDiscountOnFixedPrice itemDiscount in items.OrderByDescending(item => item.Price).ToList())
            {
                if (totalPrice >= itemDiscount.Price)
                {
                    totalPrice -= ((itemDiscount.Discount * totalPrice) / 100);
                    break;
                }
            }

            return totalPrice;
        }
    }
}
