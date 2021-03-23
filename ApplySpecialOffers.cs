using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    public class ApplySpecialOffers
    {
        public List<Item> Receipt { get; set; } = new List<Item>();
        public double TotalPrice { get; set; }

        public ApplySpecialOffers(List<Item> receipt, double totalPrice)
        {
            Receipt = receipt;
            TotalPrice = totalPrice;

            ApplyAllSpecialOffers();
        }

        public void ApplyAllSpecialOffers()
        {
            ISpecialOffers specialOffers;

            specialOffers = new QuantityDiscount();
            TotalPrice = specialOffers.ApplySpecialOffer(Receipt, TotalPrice);

            specialOffers = new DiscountOnFixedPrice();
            TotalPrice = specialOffers.ApplySpecialOffer(Receipt, TotalPrice);

            specialOffers = new DiscountOnPurchase();
            TotalPrice = specialOffers.ApplySpecialOffer(Receipt, TotalPrice);
        }


    }
}
