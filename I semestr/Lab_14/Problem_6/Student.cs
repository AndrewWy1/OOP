using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6
{
    internal class Student
    {
        private string _name;
        private string _lastName;
        private string _phone;

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public string Phone { get { return _phone; } }

        public Student(string name, string lastName, string phone)
        {
            this._name = name;
            this._lastName = lastName;
            this._phone = phone;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.LastName}, Phone: {this.Phone}";
        }
    }
}
