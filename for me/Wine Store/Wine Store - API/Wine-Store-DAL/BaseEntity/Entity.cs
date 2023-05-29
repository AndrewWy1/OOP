using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_Store_DAL.Base_Entity
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
