namespace MyApp2.DesignPatterns;

interface IVehicle
{
    public void Drive();
}

class Car : IVehicle
{
    public void Drive()
    {
        System.Console.WriteLine("Car is driving!");
    }
}

class Bike : IVehicle
{
    public void Drive()
    {
        System.Console.WriteLine("Bike is driving!");
    }
}
#nullable disable
class VehicleFactory
{
    public IVehicle GetVehicle(string type)
    {
        if(type == "car")
        {
            return new Car();
        }

        if(type == "bike")
        {
            return new Bike();
        }
        return null;
    }
}

public static class FactoryPattern
{
    public static void Run()
    {
        VehicleFactory vehicleFactory = new VehicleFactory();
        IVehicle bike = vehicleFactory.GetVehicle("bike");
        IVehicle car = vehicleFactory.GetVehicle("car");
        bike.Drive();
        car.Drive();
    }
}

// Factory Pattern says
// Don't create objects directly, Ask the factory create them

// Factory pattern hides the object creation logic and gives the right object that client needs.
// Use factory when object creation complex or varies based some conditions
