using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class ObserverA : Observer<int>
    {
        public override void OnNext(int value)
        {
            if (value > 3)
            {
                Console.WriteLine($"ObserverA: zareagował na wartość {value}");
                Unsubscriber.Dispose();
            }
        }
    }
}
