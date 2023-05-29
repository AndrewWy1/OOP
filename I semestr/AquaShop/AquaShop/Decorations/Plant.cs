using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Decorations
{
    internal class Plant : Decoration
    {
        public override int Comfort { get; set; } = 5;
        public override decimal Price { get; set; } = 10;

        public Plant() : base() { }
    }
}
