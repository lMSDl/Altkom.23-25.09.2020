using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Composite
{
    public class Product : IComponent, ICloneable
    {
        public string Name { get; }
        public float Price { get; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public float GetPrice()
        {
            Console.WriteLine($"{Name} jest w cenie {Price}");
            return Price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
