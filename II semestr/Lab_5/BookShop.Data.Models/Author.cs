using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.Models
{
    public class Author
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;


        //connections
        public ICollection<Book> Books { get; set; } = new List<Book>(); 
    }
}
