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
            WPCSharp.DesignPatterns.Behavioral.Visitor.II.Client.Execute();

            Console.ReadKey();

        }

        private static void Test()
        {


            int a = 3, b = 5;

            Square shape = new Rectangle() { A = a, B = b };

            Console.WriteLine($"Rectangle (a: {a}, b: {b}) area: {shape.Area}");
        }
    }
}
