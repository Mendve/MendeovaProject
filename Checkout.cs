using System;
using System.Collections.Generic;
using System.Linq;

namespace Mendeova
{
    public class Checkout : ICheckout
    {
        public List<Item> Receipt { get; set; } = new List<Item>();

        public Checkout()
        {
            Receipt = new List<Item>();
        }
        public void Scan(Item item)
        {
            Receipt.Add(item);
        }

        public double Total()
        { 
            double totalPrice = Receipt.Sum(item => item.Price);
            
            ApplySpecialOffers applySpecialOffers = new ApplySpecialOffers(Receipt, totalPrice); 
        
            return applySpecialOffers.TotalPrice;
        }
    }
}
