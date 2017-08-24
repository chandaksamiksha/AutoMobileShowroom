using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroomManagement
{
    public class ShopManager
    {
        public string CustomerName { get; set; }
        public string ServiceNeeded{ get; set; }
        public int serviceProvided = 0;
        public double totalSales=0;

        Purchase purchase = new Purchase();
        RentAndLease rent = new RentAndLease();
        Maintainence maintainence = new Maintainence();

        public ShopManager(string customername,Service service)
        {
            CustomerName = customername;
            ServiceNeeded = service.ToString();
        }


        public void ProvideService()
        {
            if (ServiceNeeded.Equals("Purchase"))
            {
                purchase.NewVehicleSold();
                serviceProvided++;
            }
            if (ServiceNeeded.Equals("Rent"))
            {
                rent.IsAvaliable();
                serviceProvided++;
            }
            if (ServiceNeeded.Equals("TestDrive"))
            {
                TestDrive testDrive = new TestDrive();
                testDrive.IsAvaliable();
                serviceProvided++;
            }
            if (ServiceNeeded.Equals("Maintainence"))
            {
                maintainence.GetWorker();
            }
        }

        public string Checkout()
        {
            Invoice invoice = new Invoice();
            string generatedInvoice=invoice.GenerateInvoice();
            return generatedInvoice;
        }


        public int TotalServicesProvided()
        {
            return serviceProvided;
        }

        public void GetAllSales()
        {
            rent.GetTotalSales(totalSales);
            purchase.GetTotalSales(totalSales);
            maintainence.GetTotalSales(totalSales);
        }
    }
}
