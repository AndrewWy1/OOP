using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_2
{
    internal class MyList<T>  : IEnumerable<T>
    {
        private List<T> _list;
        private int position = 0;

        public MyList(T[] list)
        {
            this._list = new List<T>(list);
        }

        public bool MoveNext()
        {
            if(position < _list.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public T ReturnValue()
        {
            if (_list.Count == 0)
                throw new ArgumentOutOfRangeException("List is empty");

            return _list[position];

        }
        public bool HasNext()
        {
            if (position < _list.Count - 1)
                return true;

            else
                return false;
        }

        //Problem_2
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < _list.Count; i++)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
