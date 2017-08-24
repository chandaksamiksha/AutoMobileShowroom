using System.Collections.Generic;

namespace AutomobileShowroomManagement
{
    public class Purchase
    {
        public Vehicle Vehicle { get; set; }

        private Customer Customer { get; set; }

        Dictionary<Vehicle, Customer> vehicleSoldToCustomer = new Dictionary<Vehicle, Customer>();
        public double SaleFromNewVehicle = 0;
        public List<Vehicle> vehicleSold = new List<Vehicle>();

        public double GetTotalSales(double totalSale)
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