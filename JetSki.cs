using System;
using System.Collections.Generic;
namespace vehicles
{
    public class JetSki : IVehicle, IWaterVehicle
    {
        public int PassengerCapacity
        { get; set; } = 2;
        public double EngineVolume
        { get; set; } = 1.5;
        public double MaxWaterSpeed
        { get; set; } = 60;

        public string Drive()
        {
            return "The jetski zips through the waves with the greatest of ease";
        }

        public string Start()
        {
            return "The engine turns over and water flows out";
        }

        public string Stop()
        {
            return "Fun is over";
        }
    }
}
