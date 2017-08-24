namespace InvoiceMangement
{
    public class Vehicle
    {

        public string Name { get; private set; }
        public string Color { get; private set; }
        public VehicleCondition Condition { get; set; }
        public bool Status { get; set; }
        public int Milege { get; set; }
        public string VehicleNumber { get; set; }

        public Vehicle(string name, string color, VehicleCondition condition, bool status, int milege, string vehicleNumber)
        {
            Name = name;
            Color = color;
            Condition = condition;
            Status = status;
            Milege = milege;
            VehicleNumber = vehicleNumber;
        }

    }
}