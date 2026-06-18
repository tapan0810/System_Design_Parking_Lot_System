using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public class Car : Vehicle
    {
        public Car(string number) : base(number, Enums.VehicleType.Car) { }
    }
    
}
