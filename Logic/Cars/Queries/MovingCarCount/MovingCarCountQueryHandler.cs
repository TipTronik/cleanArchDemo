using MediatR;
using Services.CarsMoving.ManyCarsMoves;

namespace Logic.Cars.Queries.MovingCarCount;

public class MovingCarCountQueryHandler : IRequestHandler<MovingCarCountQuery, int>
{
    private readonly ICarsService _carsService;

    public MovingCarCountQueryHandler(ICarsService carsService)
    {
        _carsService = carsService;
    }

    public Task<int> Handle(MovingCarCountQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}