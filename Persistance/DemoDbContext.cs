using Demo.Entities.DemoContext.Entites;
using Infrastructure.Contracts.DbContextContract;
using Microsoft.EntityFrameworkCore;

namespace Persistance;

public class DemoDbContext : DbContext, IDemoDbContext
{
    public DbSet<Car> Cars { get; }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}