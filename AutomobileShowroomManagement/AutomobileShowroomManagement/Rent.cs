using System;
using System.Collections.Generic;

namespace AutomobileShowroomManagement
{
    public class RentAndLease
    {
        public Vehicle Vehicle { get; set; }
        public DateTime Duration { get; set; }
        public int NumberOfDays { get; set; }
        public double RentPrice { get; set; }
        public double SaleFromRent = 0;
        public List<Vehicle> vehicleOnRent = new List<Vehicle>();

        public  Customer Customer { get; set; }
        Dictionary<Vehicle, Customer> vehicleOnRentToCustomer = new Dictionary<Vehicle, Customer>();
        public RentAndLease(Vehicle vehicle, DateTime time,int numberofdays ,double rent)
        {
            Vehicle = vehicle;
            Duration = time;
            NumberOfDays = numberofdays;
            RentPrice = rent;
        }

        public void IsAvaliable()
        {
            if (Vehicle.Status)
            {
               OnRentVehicle();
            }

        }

        public double GetTotalSales(double totalSales)
        {
            return totalSales += RentPrice;
        }

        public void OnRentVehicle()
        {
            vehicleOnRent.Add(Vehicle);
            vehicleOnRentToCustomer.Add(Vehicle, Customer);
            Vehicle.Status = false;
        }

        public void VehicleReturned()
        {
            vehicleOnRent.Remove(Vehicle);
            Vehicle.Status = true;
        }

        public List<Vehicle> AllAllotedVehicles()
        {
            return vehicleOnRent;
        }

    }
}