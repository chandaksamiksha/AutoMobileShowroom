using System;
using System.Collections.Generic;

namespace InvoiceMangement
{
    public class Purchase
    {
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }

        Dictionary<Vehicle, Customer> vehicleSoldToCustomer = new Dictionary<Vehicle, Customer>();
        public double SaleFromNewVehicle = 0;
        public List<Vehicle> vehicleSold = new List<Vehicle>();

        public double GetPurchaseSales(double totalSale)
        {
            return totalSale += SaleFromNewVehicle;
        }

        public void NewVehicleSold()
        {
            vehicleSold.Add(Vehicle);
            vehicleSoldToCustomer.Add(Vehicle, Customer);
        }

        public List<Vehicle> AllVehiclesSold()
        {
            return vehicleSold;
        }
    }
}