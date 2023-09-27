using Demo.Entities.DemoContext.Entites;

namespace Services.CarsMoving.ManyCarsMoves;

public interface ICarsService
{
    Task ManyCarsMoving(IEnumerable<Car> cars);
    
    Task WashCar(Car car);
    
    Task<decimal> RefuelCar(int fuelValue);
}