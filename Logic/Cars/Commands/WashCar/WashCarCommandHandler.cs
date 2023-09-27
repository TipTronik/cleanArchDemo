using Infrastructure.Contracts.DbContextContract;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.CarsMoving.ManyCarsMoves;

namespace Logic.Cars.Commands.WashCar;

public class WashCarCommandHandler : IRequestHandler<WashCarCommandRequest>
{
    private readonly IDemoDbContext _demoDbContext;
    private readonly ICarsService _carsService;

    public WashCarCommandHandler(IDemoDbContext demoDbContext, ICarsService carsService)
    {
        _demoDbContext = demoDbContext;
        _carsService = carsService;
    }

    public async Task<Unit> Handle(WashCarCommandRequest request, CancellationToken cancellationToken)
    {
        var car = await _demoDbContext.Cars.SingleOrDefaultAsync(c => c.Number == request.CarNumber);

        await _carsService.WashCar(car);
        
        return Unit.Value;
    }
}