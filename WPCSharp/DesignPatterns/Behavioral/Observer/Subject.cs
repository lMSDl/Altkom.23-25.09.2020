using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = new List<IObserver<int>>();
        private int _index;

        public int Index { get => _index; set { _index = value; Notify(); } }

        private void Notify()
        {

            _observers.ToList().ForEach(x =>
            {
                if (Index < 0)
                    x.OnError(new IndexOutOfRangeException(Index.ToString()));
                else
                    x.OnNext(Index);
            });
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(() => { _observers?.Remove(observer); Console.WriteLine($"Odłączenie {observer.GetType().Name}"); });
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Robię coś super ważnego!");
            Thread.Sleep(2500);
            Index = new Random().Next(-1, 10);
            Console.WriteLine($"Mój stan zmienił się na {Index}");
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
            _observers = null;
        }
    }
}
