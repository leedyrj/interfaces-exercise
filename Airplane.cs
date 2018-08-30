using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Airplane : IVehicle, IAirVehicle
    {
        public int PassengerCapacity { get; set; } = 200;
        public double EngineVolume { get; set; } = 500;
        public bool Winged { get; set; } = true;
        public double MaxAirSpeed { get; set; } = 600;

        public string Fly()
        {
            return "The Cessna effortlessly glides through the clouds like a gleaming god of the Sun";
        }

        public string Start()
        {
            return "Jet turbines are spinning";
        }

        public string Stop()
        {
            return "Make sure you land first";
        }
    }
}