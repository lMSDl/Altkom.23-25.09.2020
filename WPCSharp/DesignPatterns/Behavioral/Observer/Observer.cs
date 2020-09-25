using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        protected IDisposable Unsubscriber { get; set; }

        public void OnCompleted()
        {
            Console.WriteLine($"{this.GetType().Name}: completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{this.GetType().Name}: error: {error.Message}");
        }

        public void Subscribe(IObservable<T> observable)
        {
            Unsubscriber = observable.Subscribe(this);
        }

        public abstract void OnNext(T value);
    }
}
