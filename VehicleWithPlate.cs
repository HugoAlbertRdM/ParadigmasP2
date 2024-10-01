using System;
using Vehicle

public class VehicleWithPlate : Vehicle
{
    private string plate;

    public VehicleWithPlate() : base(typeOfVehicle)
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
