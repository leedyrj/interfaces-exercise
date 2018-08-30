using System;
using System.Collections.Generic;

namespace vehicles
{
    public interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }
        string Drive();
    }
}