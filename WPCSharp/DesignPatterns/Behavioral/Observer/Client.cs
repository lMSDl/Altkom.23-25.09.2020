
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var subject = new Subject())
            {
                var observerA = new ObserverA();
                var observerB = new ObserverB();

                observerA.Subscribe(subject);
                //observerB.Subscribe(subject);
                //subject.Subscribe(observerA);
                var unsubscribeB = subject.Subscribe(observerB);

                subject.SomeBusinessLogic();
                subject.SomeBusinessLogic();
                unsubscribeB.Dispose();

                subject.SomeBusinessLogic();

                Console.WriteLine("Ręczna zmiana stanu");
                subject.Index = -1;
            }
        }
    }
}
