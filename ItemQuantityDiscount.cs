using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    class ItemQuantityDiscount
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public ItemQuantityDiscount(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}
