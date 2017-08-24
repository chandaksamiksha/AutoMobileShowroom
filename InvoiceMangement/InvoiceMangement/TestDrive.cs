using System;
using System.Collections.Generic;

namespace InvoiceMangement
{
    public class TestDrive
    { 
    public Vehicle Vehicle { get; set; }
    public Customer Customer { get; set; }
    public List<Vehicle> allotedVehicle = new List<Vehicle>();
        
    Dictionary<Vehicle, Customer> vehicleForTestDriveToCustomer = new Dictionary<Vehicle, Customer>();

    public void IsVehicleAvaliable()
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