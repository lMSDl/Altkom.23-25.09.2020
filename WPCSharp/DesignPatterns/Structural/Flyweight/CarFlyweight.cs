using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Operation(Car uniqueState)
        {
            Console.WriteLine($"Flyweight:\nShared:\n{JsonConvert.SerializeObject(this)}\nUnique:\n{JsonConvert.SerializeObject(uniqueState)}");
        }
    }
}
