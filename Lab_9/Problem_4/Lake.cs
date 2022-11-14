using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    public class Lake : IEnumerable<int>
    {
        private int[] _rocks;

        public Lake(int[] rocks)
        {
            this._rocks = rocks;
        }


        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < _rocks.Length; i++)
            {
                if (_rocks[i] % 2 != 0)
                    yield return _rocks[i];
            }
            for(int i = _rocks.Length-1; i >= 0; i--)
            {
                if (_rocks[i] % 2 == 0) 
                    yield return _rocks[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
