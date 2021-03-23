using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    class ListOfItem
    {
        public static List<Item> items = new List<Item>{
            new Item("Jablka", 5.0),
            new Item("Banány", 10.0),
            new Item("Pomeranče", 6.0)
            };
    }
}
