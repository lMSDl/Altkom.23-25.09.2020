using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.SOLID.L;

namespace WPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WPCSharp.DesignPatterns.Creational.FactoryMethod.Client.Execute();

            //int a = 3, b = 5;

            //Square shape = new Rectangle() {A = a, B = b };

            //Console.WriteLine($"Rectangle (a: {a}, b: {b}) area: {shape.Area}");
            Console.ReadKey();
        }
    }
}
