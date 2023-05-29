using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Decorations
{
    internal interface IRepository<T>
    {
        public void Add(T decoration);
        public bool Remove(T decoration);

        public Decoration FindByType(string type);
    }
}
