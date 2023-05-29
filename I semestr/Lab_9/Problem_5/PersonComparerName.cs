using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Problem_5_6
{
    internal class PersonComparerName : IComparer<Person>
    {
        public int Compare(Person one, Person two)
        {
            if (one.Name.Length.CompareTo(two.Name.Length) != 0)
                return one.Name.Length.CompareTo(two.Name.Length);

            else
            {
                string oneName = one.Name.ToLower();
                string twoName = two.Name.ToLower();

                return oneName[0].CompareTo(twoName[0]);
            }
        }
    }
}
