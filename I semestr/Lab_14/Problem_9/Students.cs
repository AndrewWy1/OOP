using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    internal class Student
    {
        private string _facultyNumber;
        private List<int> _marks = new List<int>();

        public string FacultyNumber { get { return _facultyNumber; } }
        public List<int> Marks { get { return _marks; } }

        public Student(string facultyNumber, List<int> marks)
        {
            this._facultyNumber = facultyNumber;
            this._marks = marks;
        }

        public override string ToString()
        {
            return $"Faculty: {this.FacultyNumber}, Marks: {String.Join(" ", this.Marks)}";
        }
    }
}
