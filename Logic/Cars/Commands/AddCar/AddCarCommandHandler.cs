using Demo.Entities.DemoContext.Entites;
using Infrastructure.Contracts.DbContextContract;
using MediatR;

namespace Logic.Cars.Commands.AddCar;

public class AddCarCommandHandler : IRequestHandler<AddCarCommandRequest>
{
    private readonly IDemoDbContext _demoDbContext;

    public AddCarCommandHandler(IDemoDbContext demoDbContext)
    {
        _demoDbContext = demoDbContext;
    }

    public async Task<Unit> Handle(AddCarCommandRequest request, CancellationToken cancellationToken)
    {
        var car = new Car
        {
            EngineType = request.EngineType,
            Number = request.Number
        };

        await _demoDbContext.Cars.AddAsync(car,cancellationToken);

        await _demoDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}