using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    interface ISpecialOffers
    {
        double ApplySpecialOffer(List<Item> receipt, double totalPrice);
    }
}
