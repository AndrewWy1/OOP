using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    internal class Student
    {
        private string _name;
        private string _lastName;
        private List<int> _marks = new List<int>();

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public List<int> Marks { get { return _marks; } }

        public Student(string name, string lastName, List<int> marks)
        {
            this._name = name;
            this._lastName = lastName;
            this._marks = marks;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, LastName: {this.LastName}, Marks: {String.Join(" ", this.Marks)}";
        }
    }
}
