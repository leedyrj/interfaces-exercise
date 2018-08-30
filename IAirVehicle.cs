using System;
using System.Collections.Generic;

namespace vehicles
{
    public interface IAirVehicle
    {
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        string Fly();
    }
}