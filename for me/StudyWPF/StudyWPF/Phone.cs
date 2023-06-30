using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWPF
{
    public class Phone
    {
        public string Name { get; set; } = null!;
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Smartphone: {this.Name} Price: {this.Price}";
        }
    }
}
