using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace LibraryManagementSystem.Database
{
    public class LibraryDbContextFactory : IDesignTimeDbContextFactory<LibraryDatabaseContext>
    {
        public LibraryDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryDatabaseContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-ID23M5J;Database=LibraryDatabase;Integrated Security=true;TrustServerCertificate = True;");
            return new LibraryDatabaseContext(optionsBuilder.Options);
        }
    }
}
