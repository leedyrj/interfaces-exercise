using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Car : IVehicle, ILandVehicle
    {
        public int PassengerCapacity { get; set; } = 5;
        public double EngineVolume { get; set; } = 14;
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public string TransmissionType { get; set; } = "automatic";
        public double MaxLandSpeed { get; set; } = 180;

        public string Drive()
        {
            return "The car goes responsibly down the highway";
        }

        public string Start()
        {
            return "The engine starts. Nothing exciting happens";
        }

        public string Stop()
        {
            return "We're home";
        }
    }
}