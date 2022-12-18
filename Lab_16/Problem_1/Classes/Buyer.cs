using System;


namespace Problem_1
{
    internal class Buyer
    {
        public int buyer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set;}
        public DateTime birthdate { get; set; }
        public char sex { get; set; }
        public string email { get; set; }
        public int country_id { get; set; }
        public int town_id { get; set; }


        public override string ToString()
        {
            return $"{this.buyer_id} {this.first_name} {this.last_name} {this.birthdate} {this.sex} {this.email} " +
                $"{this.country_id} {this.town_id}";
        }
    }
}
