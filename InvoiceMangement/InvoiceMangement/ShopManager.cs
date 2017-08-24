using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMangement
{
    public class ShopManager
    {
        public Customer Customer { get; set; }
        public string ServiceNeeded { get; set; }


        public int servicesProvided = 0;
        public double totalSales = 0;

        Purchase purchase = new Purchase();
        RentAndLease rent = new RentAndLease();
        Maintainence maintainence = new Maintainence();

        public ShopManager(Customer customer, Service service)
        {
            Customer = customer;
            ServiceNeeded = service.ToString();
        }
   
        public void ProvideService()
        {
            if (ServiceNeeded.Equals("Purchase"))
            {
                purchase.NewVehicleSold();
                servicesProvided++;
            }
            if (ServiceNeeded.Equals("Rent"))
            {
                rent.IsVehicleAvaliable();
                servicesProvided++;
            }
            if (ServiceNeeded.Equals("Lease"))
            {
                rent.IsVehicleAvaliable();
                servicesProvided++;
            }
            if (ServiceNeeded.Equals("TestDrive"))
            {
                TestDrive testDrive = new TestDrive();
                testDrive.IsVehicleAvaliable();
                servicesProvided++;
            }
            if (ServiceNeeded.Equals("Maintainence"))
            {
                maintainence.GetWorker();
                servicesProvided++;
            }
        }

        public string Checkout()
        {
            Invoice invoice = new Invoice();
            string generatedInvoice = invoice.GenerateInvoice();
            return generatedInvoice;
        }

        public int TotalServicesProvided()
        {
            return servicesProvided;
        }

        public void GetTotalSales()
        {
            rent.GetRentSales(totalSales);
            purchase.GetPurchaseSales(totalSales);
            maintainence.GetMaintainenceSales(totalSales);
        }
    }
}

    

