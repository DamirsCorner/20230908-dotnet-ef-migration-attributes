using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfCoreMigrationAttributes;
public class PersonDbContextFactory : IDesignTimeDbContextFactory<PersonDbContext>
{
    public PersonDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MigrationAttributes;Trusted_Connection=True;");

        return new PersonDbContext(optionsBuilder.Options);
    }
}
