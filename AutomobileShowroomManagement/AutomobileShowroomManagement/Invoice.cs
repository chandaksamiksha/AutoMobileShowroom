using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroomManagement
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public double MobileNumber { get; set; }
        public List<Vehicle> Purchase { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public string GenerateInvoice()
        {
            return "Invoice:" + CustomerName + " " + MobileNumber + "Purchase" + "" + Date + Price;
        }
    }
}
