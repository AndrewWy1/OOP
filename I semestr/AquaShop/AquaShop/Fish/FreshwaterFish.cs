using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Fish
{
    internal class FreshwaterFish : Fish
    {
        public override int Size { get; protected set; } = 3;

        public FreshwaterFish(string name, string species, decimal price) : base(name, species, price) { }

        public override void Eat()
        {
            Size += 3;
        }
    }
}
