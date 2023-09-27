using Logic.Cars.Commands.WashCar;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Cars;

public class CarsController : ApiControllerBase
{
    [HttpPost("car/{carNumber}/wash")]
    public async Task WashCar(string carNumber)
    {
        WashCarCommandRequest command = new WashCarCommandRequest()
        {
            CarNumber = carNumber
        };

        await Mediator.Send(command);
    }
}