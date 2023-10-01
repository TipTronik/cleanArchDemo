using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Services.CarsMoving.ManyCarsMoves;

namespace Logic;

public static class DependencyInjection
{
    public static IServiceCollection AddLogic(this IServiceCollection service)
    {
        var assembly = Assembly.GetExecutingAssembly();

        service.AddMediatR(assembly);
        service.AddTransient<ICarsService, CarsService>();

        return service;
    }
}