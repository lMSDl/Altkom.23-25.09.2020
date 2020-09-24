using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var shape1 = new Circle(new RedColor());
            var shape2 = new Circle(new BlueColor());
            var shape3 = new Square(new RedColor(new LightBrightness()));
            var shape4 = new Square(new BlueColor());

            Console.WriteLine(shape1);
            Console.WriteLine(shape2);
            Console.WriteLine(shape3);
            Console.WriteLine(shape4);
        }
    }
}
