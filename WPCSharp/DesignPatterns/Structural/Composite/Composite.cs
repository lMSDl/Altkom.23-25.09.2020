using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Composite
{
    public class Container : IComponent
    {
        public Container(string name)
        {
            Name = name;
        }

        public List<IComponent> Components { get; } = new List<IComponent>();
        public string Name { get; }



        public float GetPrice()
        {
            var price = Components.ToList().Sum(x => x.GetPrice());
            Console.WriteLine($"Wartość {Name} to: {price}");
            return price;
        }
    }
}
