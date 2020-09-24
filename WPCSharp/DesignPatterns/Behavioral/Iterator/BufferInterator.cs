using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class BufferInterator<T> : IEnumerator<T[]>
    {
        private T _buffer;
        private IEnumerator<T> _enumerator;

        public BufferInterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public T[] Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
            _enumerator = null;
            Current = null;
        }

        public bool MoveNext()
        {
            if (_enumerator.MoveNext())
            {
                Current = new[] { _buffer, _enumerator.Current };
                _buffer = _enumerator.Current;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if (_enumerator.MoveNext())
                _buffer = _enumerator.Current;
            else
                _buffer = default;
            Current = new T[2];
        }
    }
}
