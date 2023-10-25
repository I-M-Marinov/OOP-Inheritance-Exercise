using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(300, 60);

            vehicle.Drive(25);
            Console.WriteLine(vehicle.Fuel);

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(250, 30);

            raceMotorcycle.Drive(2);
            Console.WriteLine(raceMotorcycle.Fuel);

            Car car = new Car(140, 60);
            car.Drive(15);
            Console.WriteLine(car.Fuel);
        }
    }
}
