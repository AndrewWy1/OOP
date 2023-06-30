
using System.Collections;

namespace LINq
{
    public class Example1
    {
        public void Func()
        {
            var arr = new int[] { 1, 2, 3 };

            foreach (var item in new ArrayEnumerable<int>(arr)) 
            {
                Console.WriteLine(item);
            }
        }
    }

    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private int _current = -1;
        private readonly T[] _array;

        public ArrayEnumerator(T[] array)
        {
            _array = array;
        }

        public T Current => _array[_current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++_current < _array.Length;
        }

        public void Reset()
        {
            _current = 0;
        }
    }

    public class ArrayEnumerable<T> : IEnumerable<T>
    {
        private readonly T[] _array;

        public ArrayEnumerable(T[] array)
        {
            _array = array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(_array);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
