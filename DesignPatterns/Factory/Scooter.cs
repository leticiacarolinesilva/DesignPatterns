using CreationalFactoryMethod.Concretes.Interfaces;

namespace CreationalFactoryMethod.Concretes;

public class Scooter : IDriveFactory
{
    public void Drive(int miles)
    {
        Console.WriteLine($"Drive the Scooter: {miles}");
    }
}
