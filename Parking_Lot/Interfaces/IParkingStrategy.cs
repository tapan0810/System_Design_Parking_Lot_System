using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Interfaces
{
    public interface IParkingStrategy
    {
        ParkingSpot FindSpot(List<ParkingSpot> spots);
    }
}
