using BookShop.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BookShopContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
    options => options.MigrationsAssembly("BookShop")));


var app = builder.Build();


var optionsBuilder = new DbContextOptionsBuilder<BookShopContext>();
optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
BooksTasks booksTasks = new BooksTasks(optionsBuilder);

//---------FirstTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetBooksByAgeRestriciton(Console.ReadLine()!)}");

//---------SecondTask---------
//Console.WriteLine($"Books: {booksTasks.GetGoldenBooks()}");

//---------ThirdTask---------
//Console.WriteLine($"Books: {booksTasks.GetBooksByPrice()}");

//---------FourthTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetBooksNotReleasedIn(Convert.ToInt32(Console.ReadLine()!))}");

//---------FifthTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetBooksByCategory(Console.ReadLine()!)}");

//---------SixthTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetBooksReleasedBefore(Convert.ToDateTime(Console.ReadLine()!))}");

//---------SeventhTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetAuthorNameEndingIn(Console.ReadLine()!)}");

//---------EighthTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetbookTitlesContaining(Console.ReadLine()!)}");

//---------NinethTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.GetBookByAuthor(Console.ReadLine()!)}");

//---------TenthTask---------
//Console.WriteLine("Enter command");
//Console.WriteLine($"Books: {booksTasks.CountBooks(Convert.ToInt32(Console.ReadLine()!))}");

//---------EleventhTask---------
//Console.WriteLine($"Books: {booksTasks.CountCopiesByAuthor()}");

//---------TwentyhTask---------
//Console.WriteLine($"Books: {booksTasks.GetTotalProfitByCategory()}");

//---------ThirteenthTask---------
//Console.WriteLine($"Books: {booksTasks.GetMostRecentBooks()}");

//---------FourteenthTask---------
Console.WriteLine($"Books: {booksTasks.IncreasePrices()}");

//---------FifteenthTask---------
Console.WriteLine($"Books: {booksTasks.RemoveBooks()}");