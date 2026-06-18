using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Models
{
    public class ParkingTicket
    {
        public Guid TicketId { get; set; }
        public Vehicle Vehicle { get; set; }
        public ParkingSpot ParkingSpot { get; set; }
        public DateTime EntryTime { get; set; }
        public ParkingTicket(Vehicle vehicle, ParkingSpot parkingSpot)
        {
            TicketId = Guid.NewGuid();
            Vehicle = vehicle;
            ParkingSpot = parkingSpot;
            EntryTime = DateTime.Now;
        }
    }
}
