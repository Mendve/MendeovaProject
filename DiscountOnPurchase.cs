using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    public class DiscountOnPurchase : ISpecialOffers
    {
        private static List<ItemDiscountOnPurchase> items = new List<ItemDiscountOnPurchase>{
            new ItemDiscountOnPurchase(DayOfWeek.Monday, 10.0),
            new ItemDiscountOnPurchase(DayOfWeek.Sunday, 20.0)
            };

        public DiscountOnPurchase()
        {

        }

        public double ApplySpecialOffer(List<Item> receipt, double totalPrice)
        {
            DateTime date = DateTime.Now;

            items.ForEach(i =>
            {
                if (date.DayOfWeek.Equals(i.Day)) totalPrice -= ((i.Discount * totalPrice) / 100);
            });

            return totalPrice;
        }
    }
}
