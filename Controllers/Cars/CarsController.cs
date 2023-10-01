using Logic.Cars.Commands.AddCar;
using Logic.Cars.Commands.WashCar;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Cars;

public class CarsController : ApiControllerBase
{
    [HttpGet("car/{carNumber}/wash")]
    public async Task WashCar(string carNumber)
    {
        WashCarCommandRequest command = new WashCarCommandRequest()
        {
            CarNumber = carNumber
        };

        await Mediator.Send(command);
    }

    [HttpPost]
    public async Task Add()
    {
        var command = new AddCarCommandRequest()
        {
            
        }

        await Mediator.Send(command);
    }
}