﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public interface IVehicle
    {
        public string VehicleType { get; }
        public bool IsTollFree { get; }
    }
}