using CreationalFactoryMethod.Concretes;
using CreationalFactoryMethod.Concretes.Interfaces;
using CreationalFactoryMethod.Factory;

VehicleAbstractFactory factory = new VehicleFactory();

IDriveFactory scooter = factory.GetVehicle("Scooter");
scooter.Drive(10);

IDriveFactory bike = factory.GetVehicle("Bike");
bike.Drive(20);

//IDriveFactory sea = factory.GetVehicle("Sea");
//bike.Drive(6); throw

Console.ReadKey();