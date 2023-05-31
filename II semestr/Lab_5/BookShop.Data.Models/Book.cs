using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.Models
{
    public class Book
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int Copies { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public EditionTypes EditionType { get; set; }
        [Required]
        public AgeRestrictions AgeRestriction { get; set; }

        //connections
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}
