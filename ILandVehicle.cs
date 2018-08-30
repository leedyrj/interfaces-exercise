using System;
using System.Collections.Generic;

namespace vehicles
{
    public interface ILandVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        string TransmissionType { get; set; }
        double MaxLandSpeed { get; set; }
        string Drive();
    }
}