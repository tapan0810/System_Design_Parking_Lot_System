using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public class Bike :Vehicle
    {
        public Bike(string number) : base(number , Enums.VehicleType.Bike) { }
    }
}
