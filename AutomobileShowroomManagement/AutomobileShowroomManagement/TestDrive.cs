using System;
using System.Collections.Generic;

namespace AutomobileShowroomManagement
{
    internal class TestDrive
    {
        public Vehicle Vehicle { get; set; }
        public List<Vehicle> allotedVehicle = new List<Vehicle>();

        public void IsAvaliable()
        {
            if (Vehicle.Status)
            {
                AllotVehicle();
            }
            
        }

        public void AllotVehicle()
        {
            allotedVehicle.Add(Vehicle);
            Vehicle.Status = false;
        }

        public void VehicleReturned()
        {
            allotedVehicle.Remove(Vehicle);
            Vehicle.Status = true;
        }

        public List<Vehicle> AllAllotedVehicles()
        {
            return allotedVehicle;
        }
    }
}