using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    internal class Citizen : IPerson
    {
        private string _name;
        private int _age;
        public string Name { get;}

        public int Age { get;}

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
