using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    internal class Footman
    {
        private string _name;
        public string Name { get { return _name; } }
        public Footman(string name)
        {
            _name = name;
        }

        public void Panic()
        {
            Console.WriteLine($"Footman {this.Name} is paniking");
        }
    }
}
