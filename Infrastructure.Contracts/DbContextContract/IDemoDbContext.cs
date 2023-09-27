using Demo.Entities.DemoContext.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contracts.DbContextContract;

public interface IDemoDbContext
{
    public DbSet<Car> Cars { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}