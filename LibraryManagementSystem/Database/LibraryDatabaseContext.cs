using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Entities;
namespace LibraryManagementSystem.Database
{
    public class LibraryDatabaseContext : DbContext
    {
        public LibraryDatabaseContext(DbContextOptions<LibraryDatabaseContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Loans> Loans { get; set; }
    }
}
