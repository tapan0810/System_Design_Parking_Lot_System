using Parking_Lot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public abstract class Vehicle
    {
        public string LicenseNumber { get; set; }
        public VehicleType VehicleType { get; set; }

        protected Vehicle(string licenseNumber, VehicleType vehicleType)
        {
            LicenseNumber = licenseNumber;
            VehicleType = vehicleType;
        }
    }
}
