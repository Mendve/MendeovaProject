using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    interface ICheckout
    {
        void Scan(Item item);
        double Total();
    }
}
