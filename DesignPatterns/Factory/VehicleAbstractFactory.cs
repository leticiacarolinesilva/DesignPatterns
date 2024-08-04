using CreationalFactoryMethod.Concretes.Interfaces;

namespace CreationalFactoryMethod.Factory;

public abstract class VehicleAbstractFactory
{
    public abstract IDriveFactory GetVehicle(string vehicle);
}