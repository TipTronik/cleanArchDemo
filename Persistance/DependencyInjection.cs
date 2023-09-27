using Infrastructure.Contracts.DbContextContract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection service)
    {
        service.AddDbContext<DbContext>();

        service.AddScoped<IDemoDbContext, DemoDbContext>();

        return service;
    }
}