using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Helicopter : IVehicle, IAirVehicle
    {
        public int PassengerCapacity { get; set; } = 6;
        public double EngineVolume { get; set; } = 50;
        public bool Winged { get; set; } = false;
        public double MaxAirSpeed { get; set; } = 125;

        public string Fly()
        {
            return "The helicopter hovers and dives";
        }

        public string Start()
        {
            return "The rotors spin";
        }

        public string Stop()
        {
            return "A gentle touchdown";
        }
    }
}