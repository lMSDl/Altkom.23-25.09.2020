using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public class Order
    {
        private ICar Car { get; }

        public Order(IFactory factory, string segment, Type type)
        {
            switch(type.Name)
            {
                case nameof(ISedan):
                    Car = factory.CreateSedan(segment);
                    break;
                case nameof(ISuv):
                    Car = factory.CreateSuv(segment);
                    break;
            }
        }

        public string GetManufacturedCarName()
        {
            return Car.Name();
        }
    }
}
