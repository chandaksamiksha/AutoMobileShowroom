using System;
using System.Collections.Generic;

namespace InvoiceMangement
{
    public class RentAndLease
    {
        public Vehicle Vehicle { get; set; }
        public DateTime Duration { get; set; }
        public int NumberOfDays { get; set; }
        public double RentPrice { get; set; }
        public Customer Customer { get; set; }
        public double SaleFromRent = 0;
        public List<Vehicle> vehicleOnRent = new List<Vehicle>();

        Dictionary<Vehicle,Customer> vehicleOnRentToCustomer = new Dictionary<Vehicle, Customer>();
        public RentAndLease(Vehicle vehicle, DateTime time, int numberofdays, double rent)
        {
            Vehicle = vehicle;
            Duration = time;
            NumberOfDays = numberofdays;
            RentPrice = rent;
        }

        public RentAndLease()
        {
        }

        public void IsVehicleAvaliable()
        {
            if (Vehicle.Status)
            {
                OnRentVehicle();
            }

        }

        public double GetRentSales(double totalSales)
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