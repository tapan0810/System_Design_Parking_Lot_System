using Parking_Lot.Enums;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_Lot.Services
{
    public class DisplayService
    {

        public void UpdateDisplay(List<ParkingSpot> spots)
        {
            Console.WriteLine();

            Console.WriteLine("Display Board");

            foreach (var group in spots.GroupBy(x => x.SpotType))
            {
                Console.WriteLine($"{group.Key} => {group.Count(x => x.SpotStatus == SpotStatus.Free)}");
            }

            Console.WriteLine();
        }
    }
}
