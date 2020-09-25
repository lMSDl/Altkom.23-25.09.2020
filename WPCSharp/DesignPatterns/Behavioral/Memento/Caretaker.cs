using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private T _originator;
        private Stack<IMemento<T>> _mementos = new Stack<IMemento<T>>();

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            var memento = new Memento<T>((T)_originator.Clone());
            Console.WriteLine("Caretaker: Saving state...");
            _mementos.Push(memento);
        }

        public void RestoreState()
        {
            if (!_mementos.Any())
                return;
            var memento = _mementos.Pop();
            Console.WriteLine($"Caretaker: Restoring state from {memento.DateTime}...");
            _originator.Restore(memento.State);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: List of mementos:");
            _mementos.ToList().ForEach(x => Console.WriteLine(x.DateTime));
        }
    }
}
