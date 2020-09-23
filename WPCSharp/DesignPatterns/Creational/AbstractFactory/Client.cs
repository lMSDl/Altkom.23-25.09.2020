using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute() {
            Order order;
            order = new Order(new HondaFactory(), "full", typeof(ISedan));
            Console.WriteLine(order.GetManufacturedCarName());
            order = new Order(new ToyotaFactory(), "compact", typeof(ISuv));
            Console.WriteLine(order.GetManufacturedCarName());
        }
    }
}
