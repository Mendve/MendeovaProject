using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mendeova
{
    public class Program
    {
        private static void AddItemToCheckout(Checkout checkout, string name)
        {
            Item item = GetItemByName(name);
            checkout.Scan(new Item(item.Name, item.Price));
            Console.WriteLine("Naskenováno");
        }

        public static Item GetItemByName(string name)
        {
            double price = 0.0;
            ListOfItem.items.ForEach(item =>
            {
                if (item.Name.Equals(name)) price = item.Price;
            });
 
            return new Item(name, price);
        }

        static void Main(string[] args)
        {
            string input;
            bool scanning = true;
            Checkout checkout = new Checkout();

            while (scanning)
            {      
                Console.WriteLine("Seznam zboží:\n");
                Console.WriteLine("Index\tNázev");
                Console.WriteLine("1\tJablka");
                Console.WriteLine("2\tBanány");
                Console.WriteLine("3\tPomeranče");
                Console.WriteLine("--------------------");
                Console.WriteLine("4\tUkončit skenování\n");

                Console.Write("Vložte index pro naskenování zboží: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out int index);

                switch (index)
                {
                    case 1:
                        AddItemToCheckout(checkout, "Jablka");
                        break;
                    case 2:
                        AddItemToCheckout(checkout, "Banány");
                        break;
                    case 3:
                        AddItemToCheckout(checkout, "Pomeranče");
                        break;
                    case 4:
                        scanning = false;
                        Console.WriteLine(checkout.Total());
                        break;
                    default:
                        Console.WriteLine("Nebyl správně zadán vstup, zkuste to znovu.");
                        break;
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
