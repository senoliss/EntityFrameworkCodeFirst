using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();

            // Insert:
            //var page = new Page(1, "Belekiek Mozes atnestu pasakeciu parode kas ira kas.");
            //dbContext.Pages.Add(page);
            //dbContext.SaveChanges();

            // Dispose:
            //var page = new Page(new Guid("1F2FE6A4-6402-4334-133B-08DBE53219C0"));
            //dbContext.Pages.Remove(page);
            //dbContext.SaveChanges();

            // Select:
            //var page = dbContext.Pages.Select(page => page.Number == 1);
            //var page = dbContext.Pages.Where(p => p.Number == 2).ToList();
            //Console.WriteLine(page);

            // Update:
            //var page = dbContext.Pages.First(p => p.Id  == Guid.Parse("33059EE3-26BE-4791-EBD7-08DBE5364051"));
            //page.Content += "tiririri";
            //dbContext.SaveChanges();

            // create new book together with child pages in book table and in page table
            var book = new Book("Harry Potter");
            for (int i = 0; i < 565; i++)
            {
                book.Pages.Add(new Page(i, $"Content - {i}"));
            }

            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            // delete previously created book and page tables
            //var book = dbContext.Books.FirstOrDefault(b => b.Id == new Guid("0D0B106E-FFC1-4F5A-AA71-48C500FD7DB7")); // without .Include(p => p.Pages)
            //dbContext.Books.Remove(book);
            //dbContext.SaveChanges();
        }
    }
}