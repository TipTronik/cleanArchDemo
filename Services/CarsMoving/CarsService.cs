using Demo.Entities.DemoContext.Entites;

namespace Services.CarsMoving.ManyCarsMoves;

public class CarsService : ICarsService
{
    public async Task ManyCarsMoving(IEnumerable<Car> cars)
    {
        var tasks = new List<Task>();
        
        foreach (var car in cars)
        {
            tasks.Add(car.Move());
        }

        await Task.WhenAll(tasks);
    }

    public async Task WashCar(Car car)
    {
        //wash car
    }

    public async Task<decimal> RefuelCar(int fuelValue)
    {
        //return price of refuel
        return Decimal.One;
    }
}