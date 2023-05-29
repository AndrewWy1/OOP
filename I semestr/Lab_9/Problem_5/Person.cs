using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5_6
{
    internal class Person : IComparable<Person>
    {
        private string _name;
        private int _age;
        private string _town;

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }

        public Person(string name, int age, string town)
        {
            _name = name;
            _age = age;
            _town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            if (this._name.CompareTo(otherPerson._name) == 0 &&
                this._age.CompareTo(otherPerson._age) == 0 &&
                this._town.CompareTo(otherPerson._town) == 0)

                return 1;

            return 0;
        }


        //Problem 6
        public Person(string name, int age)
        {
            this._age = age;
            this._name = name;
            this._town = null;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
