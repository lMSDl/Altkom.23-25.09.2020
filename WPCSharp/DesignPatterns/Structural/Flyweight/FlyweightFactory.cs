using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory(IEnumerable<CarFlyweight> flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GenerateKey(x));
        }

        public string GenerateKey(CarFlyweight flyweight)
        {
            var elements = new List<string>
            {
                flyweight.Manufacturer,
                flyweight.Model,
                flyweight.Color
            };

            return string.Join("_", elements);
        }

        public CarFlyweight GetFlyweight(CarFlyweight flyweight)
        {
            var key = GenerateKey(flyweight);

            if (_flyweights.ContainsKey(key))
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight");
                return _flyweights[key];
            }

            Console.WriteLine("FlyweightFactory: Adding new flyweight");
            _flyweights.Add(key, flyweight);
            return flyweight;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"FlyweightFactory has {_flyweights.Count} elements");
            _flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
