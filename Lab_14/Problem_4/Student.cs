using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{   
    internal class Student
    {
        private string _name;
        private string _lastName;

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }

        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.LastName}";
        }
    }
}
