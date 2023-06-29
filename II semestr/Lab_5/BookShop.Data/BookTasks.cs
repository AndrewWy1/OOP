using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookShop.Data
{
    public class BooksTasks
    {
        private BookShopContext _context;

        public BooksTasks(DbContextOptionsBuilder<BookShopContext> optionsBuilder)
        {
            _context = new BookShopContext(optionsBuilder.Options);
        }   

        public string GetBooksByAgeRestriciton(string command)
        {
            var books = _context.Books
            .Where(book =>
               (book.AgeRestriction == AgeRestrictions.Teen && command.ToLower() == "teen") ||
               (book.AgeRestriction == AgeRestrictions.Adult && command.ToLower() == "adult") ||
               (book.AgeRestriction == AgeRestrictions.Minor && command.ToLower() == "minor"))
            .OrderBy(book => book.Title)
            .Select(book => book.Title)
            .ToList();

            if (books.Count == 0)
                return "Resilts not found";

            return string.Join("\n", books);
        }

        public string GetGoldenBooks()
        {
            var books = _context.Books
                .Where(b => b.EditionType == EditionTypes.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetBooksByPrice()
        {
            var books = _context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => b.Title + " - " + b.Price)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetBooksNotReleasedIn(int Year)
        {
            var books = _context.Books
                .Where(b => b.ReleaseDate.Year != Year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetBooksByCategory(string? category)
        {

            if (category is null)
                return "Category is null";


            var books = _context.Books.Join(
                _context.BookCategories.Join(
                    _context.Categories
                    .Where(c => c.Name == category),
                    bc => bc.CategoryId,
                    c => c.CategoryId,
                    (bc, c) => new
                    {
                        bc.BookId,
                        c.CategoryId
                    }),
                book => book.BookId,
                bookCategory => bookCategory.BookId,
                (b, bc) => new
                {
                    b.Title
                })
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();
                

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetBooksReleasedBefore(DateTime releasedDate)
        {
            var books = _context.Books
                .Where(b => b.ReleaseDate < releasedDate)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetAuthorNameEndingIn(string endFirstName)
        {
            var books = _context.Authors
                .Where(a => EF.Functions.Like(a.FirstName, $"%{endFirstName}"))
                .OrderBy(a => a.FirstName)
                .Select(a => a.FirstName + " " + a.LastName)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetbookTitlesContaining(string contain)
        {
            var books = _context.Books
                .Where(b => EF.Functions.Like(b.Title.ToLower(), $"%{contain.ToLower()}%"))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string GetBookByAuthor(string contain)
        {
            var books = _context.Books
                .Include(b => b.Author)
                .Where(b => EF.Functions.Like(b.Author.LastName.ToLower(), $"{contain.ToLower()}%"))
                .OrderBy(b => b.Title)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList();

            if (books.Count == 0)
                return "Results not found";

            return string.Join("\n", books);
        }

        public string CountBooks(int length)
        {
            var books = _context.Books
                .Where(b => b.Title.Length > length)
                .Count();

            return string.Join("\n", books);
        }

        public string CountCopiesByAuthor()
        {
            var result = _context.Books
                .Join(
                    _context.Authors,
                    b => b.AuthorId,
                    a => a.AuthorId,
                    (book, author) => new
                    {
                        book,
                        author
                    }
                )
                .GroupBy(o => o.author.FirstName + " " + o.author.LastName)
                .Select(o => o.Key + " - " + o.Sum(s => s.book.Copies))
                .ToList();

            return string.Join("\n", result);
        }
        public string GetTotalProfitByCategory()
        {
            var result = _context.Books
                .Include(b => b.BookCategories)
                    .ThenInclude(bc => bc.Category)
                .SelectMany(b => b.BookCategories, (book, bc) => new
                {
                    TotalPrice = (double)book.Copies * book.Price,
                    CategoryName = bc.Category.Name
                })
                .GroupBy(o => o.CategoryName)
                .OrderBy(o => o.Key)
                .ThenByDescending(o => o.Sum(s => s.TotalPrice))
                .Select(o => o.Key + "   $" + o.Sum(s => s.TotalPrice))
                .ToList();

            return string.Join("\n", result);
        }

        public string GetMostRecentBooks()
        {
            var result =
                _context.Books.Join(
                    _context.BookCategories.Join(
                        _context.Categories,
                        bc => bc.CategoryId,
                        c => c.CategoryId,
                        (BookCategory, Category) => new
                        {
                            BookCategory.BookId,
                            CategoryName = Category.Name
                        })
                        .ToList(),
                    b => b.BookId,
                    bc => bc.BookId,
                    (book, bc) => new
                    {
                        book.Title,
                        book.ReleaseDate,
                        book.Copies,
                        bc.CategoryName
                    })
                    .ToList()
                    .GroupBy(o => o.CategoryName)
                    .OrderBy(o => o.Sum(s => s.Copies))
                    .Select(group =>
                    $"--{group.Key}\n" +
                    $"{string.Join(
                                "\n",
                                group
                                .OrderByDescending(s => s.ReleaseDate)
                                .Select(b => b.Title + " (" +
                                    (b.ReleaseDate == null ? "Not released" : b.ReleaseDate.Year) + ")"
                                )
                                .Take(3)
                            )}")
                    .ToList();

            return string.Join("\n", result);
        }

        public string IncreasePrices()
        {
            var books = _context.Books
                .OrderBy(b => b.Title)
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Year > 2010)
                .Select(b => b.Title.PadRight(25, ' ') + " $" + b.Price)
                .Take(5)
                .ToList();

            _context.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Year > 2010)
                .ToList()
                ?.ForEach(book => book.Price *= 5);
            _context.SaveChanges();

            return string.Join("\n", books);
        }

        public  string RemoveBooks()
        {
            int count = 4200;
            int countDeleted = _context.Books.Where(book => book.Copies < count).Count();

            _context.RemoveRange(
                    _context.Books.Where(book => book.Copies < count).ToList()
                );
            _context.SaveChanges();

            return $"{countDeleted} books, {count} copies";
        }
    }
}
