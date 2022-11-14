using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    internal class RoyalGuard
    {
        private string _name;
        public string Name { get { return _name; } }
        public RoyalGuard(string name)
        {
            _name = name;
        }

        public void Defend()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending");
        }
    }
}
