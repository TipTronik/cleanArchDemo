using MediatR;

namespace Logic.Cars.Commands.WashCar;

public record WashCarCommandRequest : IRequest<Unit>
{
    public string CarNumber { get; init; }
}