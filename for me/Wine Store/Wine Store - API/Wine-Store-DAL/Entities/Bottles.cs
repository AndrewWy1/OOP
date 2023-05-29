using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wine_Store_DAL.Base_Entity;

namespace Wine_Store_DAL.Entities
{
    public class Bottles : Entity
    {
        public string? Full_name { get; set; }
        public int Category_Id { get; set; }
        public string? Label { get; set; }
        public decimal Volume { get; set; }
        public int Producer_Id { get; set; }
        public int Year_Produced { get; set; }
        public decimal Alcohol_Percentage { get; set; }
        public decimal Current_Price { get; set; }
    }
}
