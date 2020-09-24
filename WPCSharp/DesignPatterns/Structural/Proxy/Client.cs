
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            var database = new DatabaseProxy(new Database());

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}
