using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrationAttributes;
public class PersonDbContext : DbContext
{
    public PersonDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Person> Persons => Set<Person>();
}
