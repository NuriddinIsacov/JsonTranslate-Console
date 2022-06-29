using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"{Name} nomli mahsulot narxi {amount} miqdorga oshirildi.");
        }

        public bool DecreasePrice(int amount)
        {
            if (Price>=amount)
            {
                Price -= amount;
                Console.WriteLine($"{Name} nomli mahsulot narxi {amount} miqdorga kamaytirildi.");
                return true;
            }

            return true;
        }


        public override string ToString() => $"{Name} mahsulot narxi {Price}";
    }
}
