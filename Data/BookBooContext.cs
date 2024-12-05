using Microsoft.EntityFrameworkCore;
using BookBoo.Models;

namespace BookBoo.Data;

    public class BookBooContext: DbContext
    {   
        public BookBooContext(DbContextOptions<BookBooContext> options) : base(options) {}

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors {get; set;}
    }  