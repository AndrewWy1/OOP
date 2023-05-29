using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Aquarium
{
    internal class SaltwaterAquarium : Aquarium
    {
        public override int Capacity { get; set; } = 50;
        public SaltwaterAquarium(string name) : base(name) { }

    }
}
