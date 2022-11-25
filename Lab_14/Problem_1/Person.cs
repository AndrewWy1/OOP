using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    internal class Person 
    {
        private string _name;
        private string _lastname;
        private int _group;

        public string Name { get { return _name; } }
        public string Lastname { get { return _lastname; } }
        public int Group { get { return _group; } }

        public Person(string name, string lastname, int group)
        {
            _name = name;
            _lastname = lastname;
            _group = group;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.Lastname}, Group: {this.Group}";
        }

    }
}
