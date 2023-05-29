using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Decorations
{
    abstract internal class Decoration
    {
        abstract public int Comfort { get; set; }
        abstract public decimal Price { get; set; }

        public Decoration(int Comfort, decimal Price)
        {
            this.Comfort = Comfort;
            this.Price = Price;
        }
        public Decoration() { }
    }
}
