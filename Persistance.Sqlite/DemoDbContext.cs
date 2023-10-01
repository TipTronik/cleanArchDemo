using Demo.Entities.DemoContext.Entites;
using Infrastructure.Contracts.DbContextContract;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Sqlite;

public class DemoDbContext : DbContext, IDemoDbContext
{
    public DemoDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Car> Cars { get; protected set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}