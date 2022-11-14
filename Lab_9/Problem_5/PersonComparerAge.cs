using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5_6
{
    internal class PersonComparerAge : IComparer<Person>
    {
        public int Compare(Person one, Person two)
        {
            return one.Age.CompareTo(two.Age);
        }
    }
}
