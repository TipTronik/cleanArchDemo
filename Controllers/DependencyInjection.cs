using Microsoft.Extensions.DependencyInjection;

namespace Controllers;

public static class DependencyInjection
{
    public static IServiceCollection AddControllers(this IServiceCollection service)
    {
        service.AddControllers();

        return service;
    }
}