using System;
using System.Collections.Generic;

namespace vehicles
{
    public interface IVehicle
    {

        int PassengerCapacity { get; set; }

        double EngineVolume { get; set; }

        string Start();

        string Stop();
    }
}