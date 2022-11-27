using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    internal class Student
    {
        private int _group;
        private string _firstName;
        private string _lastName;

        public int Group { get { return _group; } }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }

        public Student(string firstName, string lastName, int group)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._group = group;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}, Last Name: {this.LastName}, Group: {this.Group}";
        }
    }
}
