using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Composite
{
    public class Client
    {
        public static void Execute()
        {
            var storage = new Container("Storage 1");
            var shelf1 = new Container("Shelf 1");
            var shelf2 = new Container("Shelf 2");
            var box1 = new Container("Box 1");
            var box2 = new Container("Box 2");
            var box3 = new Container("Box 3");
            var box4 = new Container("Box 4");
            var box5 = new Container("Box 5");

            var product1 = new Product("Kawa", 15.3f);
            var product2 = new Product("Herbata", 10f);
            var product3 = new Product("Ciastka", 12f);

            storage.Components.Add(shelf1);
            storage.Components.Add(shelf2);

            shelf1.Components.Add(box1);
            shelf1.Components.Add(box3);
            shelf1.Components.Add(box5);
            shelf1.Components.Add((IComponent)product1.Clone());

            shelf2.Components.Add(box2);
            shelf2.Components.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Components.Add((IComponent)product1.Clone());
            }
            for (int i = 0; i < 10; i++)
            {
                box2.Components.Add((IComponent)product2.Clone());
            }
            for (int i = 0; i < 10; i++)
            {
                box3.Components.Add((IComponent)product3.Clone());
            }
            for (int i = 0; i < 5; i++)
            {
                box4.Components.Add((IComponent)product1.Clone());
                box4.Components.Add((IComponent)product2.Clone());
            }
            for (int i = 0; i < 3; i++)
            {
                box5.Components.Add((IComponent)product1.Clone());
                box5.Components.Add((IComponent)product2.Clone());
                box5.Components.Add((IComponent)product3.Clone());
            }
            shelf2.Components.Add((IComponent)product3.Clone());

            CheckPrice(storage);
            CheckPrice(shelf1);
            CheckPrice(product1);

        }

        private static void CheckPrice(IComponent component)
        {
            var price = component.GetPrice();
            Console.WriteLine($"Cena sumaryczna {price}");
        }
    }
}
