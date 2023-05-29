using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Decorations
{
    internal class Ornament : Decoration
    {
        public override int Comfort { get; set; } = 1;
        public override decimal Price { get; set; } = 5;
        
        public Ornament() : base() { }
    }
}
