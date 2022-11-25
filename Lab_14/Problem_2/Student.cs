using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    internal class Student
    {
        private string _name;
        private string _lastName;
        private int age;

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public int Age { get { return age; } }

        public Student(string name, string lastName, int age)
        {
            _name = name;
            _lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.LastName}, Age: {this.Age}";
        }
    }
}
