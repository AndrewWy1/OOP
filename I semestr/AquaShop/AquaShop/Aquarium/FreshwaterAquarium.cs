using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Aquarium
{
    internal class FreshwaterAquarium : Aquarium
    {
        public override int Capacity { get; set; } = 50;

        public FreshwaterAquarium(string name) : base(name) { }


    }
}
