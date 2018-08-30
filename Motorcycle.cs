using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Motorcycle : IVehicle, ILandVehicle
    {
        public int PassengerCapacity { get; set; } = 2;
        public double EngineVolume { get; set; } = 1.5;
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public string TransmissionType { get; set; } = "Manual";
        public double MaxLandSpeed { get; set; } = 200;

        public string Drive()
        {
            return "The motorcycle screams down the highway";
        }

        public string Start()
        {
            return "The motorcycle rumbles to a start";
        }

        public string Stop()
        {
            return "Time to get the bugs out of your teeth";
        }
    }
}