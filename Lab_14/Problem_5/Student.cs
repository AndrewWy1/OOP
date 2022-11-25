using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{

    internal class Student
    {
        private string _name;
        private string _lastName;
        private string _email;

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public string Email { get { return _email; } }

        public Student(string name, string lastName, string email)
        {
            this._name = name;
            this._lastName = lastName;
            this._email = email;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.LastName}, Email: {this.Email}";
        }
    }
}
