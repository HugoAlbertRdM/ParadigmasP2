namespace Practice2
{
    class VehicleWithPlate : Vehicle
    {
        private string plate;
        private static string typeOfVehicle = "Vehicle With Plate";

        public VehicleWithPlate(string plate, string typeOfVehicle) : base(typeOfVehicle)
        {
            this.plate = plate;
        }

        public string GetPlate()
        {
            return plate;
        }


        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }
    }
}