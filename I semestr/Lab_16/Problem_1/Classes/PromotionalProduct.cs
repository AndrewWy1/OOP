using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Classes
{
    internal class PromotionalProduct
    {
        public int product_id { get; set; }
        public string product_name { get; set;}
        public int section_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set;}

        public override string ToString()
        {
            return $"{this.product_id} {this.product_name} {this.section_id} {this.start_date} {this.end_date}";
        }
    }
}
