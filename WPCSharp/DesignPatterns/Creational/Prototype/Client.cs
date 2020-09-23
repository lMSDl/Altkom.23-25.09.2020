using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute() {
            var p1 = new Person()
            {
                FirstName = "Ewa",
                LastName = "Ewowska",
                Age = 26,
                IdInfo = new IdInfo()
            };
            Console.WriteLine(p1);

            var p2 = (Person)p1.Clone();

            Console.WriteLine(p2);
            p2.FirstName = "Adam";
            Console.WriteLine(p2);
            p1.IdInfo.IdNumber = 2;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
