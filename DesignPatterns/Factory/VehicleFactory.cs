using CreationalFactoryMethod.Concretes.Interfaces;
using CreationalFactoryMethod.Factory;

namespace CreationalFactoryMethod.Concretes;

public class VehicleFactory : VehicleAbstractFactory
{
    public override IDriveFactory GetVehicle(string Vehicle)
    {
        switch (Vehicle)
        {
            case "Scooter":
                return new Scooter();
            case "Bike":
                return new Bike();
            default:
                throw new ApplicationException($"Vehicle {Vehicle} cannot be created");
        }
    }
}