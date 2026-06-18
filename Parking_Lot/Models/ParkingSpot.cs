using Parking_Lot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public class ParkingSpot
    {
        public int SpotId { get; set; }
        public SpotType SpotType { get; set; }
        public SpotStatus SpotStatus { get; set; }
        public Vehicle vehicle { get; set; }
        public ParkingSpot(int spotId, SpotType spotType)
        {
            SpotId = spotId;
            SpotType = spotType;
            SpotStatus = SpotStatus.Free;
        }

        public bool IsFree()
        {
            return SpotStatus == SpotStatus.Free;
        }

        public void AssignVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            SpotStatus = SpotStatus.Occupied;
        }

        public void RemoveVehicle()
        {
            vehicle = null;
            SpotStatus = SpotStatus.Free;
        }
    }
}
