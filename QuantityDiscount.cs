using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    public class QuantityDiscount : ISpecialOffers
    {
        private static List<ItemQuantityDiscount> items = new List<ItemQuantityDiscount>{
            new ItemQuantityDiscount("Banány", 2, 15.0),
            new ItemQuantityDiscount("Pomeranče", 3, 14.0)
            };

        public QuantityDiscount()
        {

        }

        public double ApplySpecialOffer(List<Item> receipt, double totalPrice)
        {
            int countItem = 0;

            foreach (ItemQuantityDiscount item in items)
            {
                foreach (Item i in receipt)
                {
                    if (item.Name.Contains(i.Name))
                    {
                        countItem = receipt.Count(n => n.Name.Equals(item.Name));
                        totalPrice -= (countItem / item.Amount) * ((item.Amount * i.Price) - item.Price);
                        break;
                    }
                }
            }

            return totalPrice;
        }
    }
}
