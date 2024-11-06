using Libreria_EMO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria_EMO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
