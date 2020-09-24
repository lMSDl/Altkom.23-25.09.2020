using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(new List<CarFlyweight>
            {
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro", Color = "Orange" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" },
                new CarFlyweight { Manufacturer = "Opel", Model = "Astra I", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Opel", Model = "Astra II", Color = "Blue" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "Orange" }
            });

            factory.ListFlyweights();

            var car1 = new Car
            {
                Owner = "John Doe",
                Number = "AMS8786",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Pink"
            };
            car1.Flyweight = factory.GetFlyweight(car1.Flyweight);
            factory.ListFlyweights();

            var car2 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "AAMS886",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car2.Flyweight = factory.GetFlyweight(car2.Flyweight);
            factory.ListFlyweights();

            var car3 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "ASK99210",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car3.Flyweight = factory.GetFlyweight(car3.Flyweight);
            factory.ListFlyweights();

            car2.Flyweight.Operation(car2);
            car3.Flyweight.Operation(car3);

            //car3.Manufacturer = "ABC";
            var newFlyweight = new CarFlyweight() { Color = car3.Color, Manufacturer = "ABC", Model = car3.Model };
            car3.Flyweight = factory.GetFlyweight(newFlyweight);
            car2.Flyweight.Operation(car2);
            car3.Flyweight.Operation(car3);
        }
    }
}
