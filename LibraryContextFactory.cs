using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ngducanh
{
    public class LibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
          
            optionsBuilder.UseSqlServer(
                @"Data Source=MSI\DOAN;Initial Catalog=QLTV;Integrated Security=True;TrustServerCertificate=True;"
            );
            return new LibraryContext(optionsBuilder.Options);
        }
    }
}
