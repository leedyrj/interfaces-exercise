using System;
using System.Collections.Generic;

namespace vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()

            Airplane Boeing747 = new Airplane();
            Helicopter Heli = new Helicopter();
            Motorcycle Ninja = new Motorcycle();
            Car Civic = new Car();
            JetSki SeaDoo = new JetSki();
            CruiseShip Viking = new CruiseShip();


            List<IAirVehicle> FlyingVehicles = new List<IAirVehicle>()
            {
                Heli,
                Boeing747
            };

            List<IWaterVehicle> SailingVehicles = new List<IWaterVehicle>()
            {
                Viking,
                SeaDoo
            };

            List<ILandVehicle> DrivingVehicle = new List<ILandVehicle>()
            {
                Civic,
                Ninja
            };


            foreach (IAirVehicle Flyer in FlyingVehicles)
            {
                Console.WriteLine(Flyer.Fly());
            };

            foreach (IWaterVehicle Sailer in SailingVehicles)
            {
                Console.WriteLine(Sailer.Drive());
            }

            foreach (ILandVehicle Driver in DrivingVehicle)
            {
                Console.WriteLine(Driver.Drive());
            }



            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
