using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public class Truck : Vehicle
    {
        public Truck(string number) : base(number, Enums.VehicleType.Truck) { }
    }
}
