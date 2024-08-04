using CreationalFactoryMethod.Concretes.Interfaces;

namespace CreationalFactoryMethod.Concretes;

public class Bike : IDriveFactory
{
    public void Drive(int miles)
    {
        Console.WriteLine($"Drive the Bike: {miles}");
    }
}
