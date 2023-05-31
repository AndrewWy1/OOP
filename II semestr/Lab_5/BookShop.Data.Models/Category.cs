using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.Models
{
    public class Category
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = null!;


        //connections
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}
