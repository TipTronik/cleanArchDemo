using Demo.Entities.DemoContext.Enums;
using MediatR;

namespace Logic.Cars.Commands.AddCar;

public record AddCarCommandRequest : IRequest<Unit>
{
    public EngineType EngineType { get; set; }
    
    public string Number { get; set; }
}