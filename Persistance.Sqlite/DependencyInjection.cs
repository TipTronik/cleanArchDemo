using Infrastructure.Contracts.DbContextContract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistance.Sqlite;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection service)
    {
        service.AddDbContext<DbContext>(options =>
        {
            options.UseSqlite("Filename=scat.db");
        }, ServiceLifetime.Transient, ServiceLifetime.Transient);

        service.AddScoped<IDemoDbContext, DemoDbContext>();

        return service;
    }
}