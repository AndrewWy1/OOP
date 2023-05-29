using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Classes
{
    internal class ShareForBuyer
    {
        public int share_id { get; set; }
        public int buyer_id { get; set; }
        public int product_id { get; set; }
        public int country_id { get; set; }

        public override string ToString()
        {
            return $"{this.share_id} {this.buyer_id} {this.product_id} {this.country_id}";
        }

    }
}
