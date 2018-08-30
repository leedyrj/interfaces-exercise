using System;
using System.Collections.Generic;

namespace vehicles
{
    public class CruiseShip : IVehicle, IWaterVehicle
    {
        public int PassengerCapacity { get; set; } = 5000;
        public double EngineVolume { get; set; } = 80000;
        public double MaxWaterSpeed { get; set; } = 23;

        public string Drive()
        {
            return "The ship plods along the waves";
        }

        public string Start()
        {
            return "All aboard!";
        }

        public string Stop()
        {
            return "Vacation is over";
        }
    }
}