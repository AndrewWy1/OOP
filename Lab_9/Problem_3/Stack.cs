using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> _items = new List<T>();

       private int _lastIndex = -1;

        public void Push(T item)
        {
            _lastIndex++;
            _items.Add(item);
        }

        public T Pop()
        {
            if (_lastIndex < 0)
                throw new Exception("Stack is empty");

            return _items[_lastIndex--];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _lastIndex; i >= 0; i--)
                yield return _items[i];

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
