using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var context = Context.Instance;
            context.SetSettings("1", "G");
            Console.WriteLine(context.GetSettings("1"));
            Console.WriteLine(Context.Instance.GetSettings("1"));
        }
    }
}
