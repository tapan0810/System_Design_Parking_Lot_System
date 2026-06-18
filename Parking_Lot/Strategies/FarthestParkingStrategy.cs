using Parking_Lot.Interfaces;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Strategies
{
    public class FarthestParkingStrategy : IParkingStrategy
    {
        public ParkingSpot FindSpot(List<ParkingSpot> spots)
        {
            return spots.LastOrDefault(spot => spot.IsFree())!;
        }
    }
}
