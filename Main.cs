namespace Practice2
{
    internal class Program
    {

        static void Main()
        {
            City city = new City("Madrid");
            Console.WriteLine(city.WriteMessage($"created."));
            PoliceStation policeStation = new PoliceStation(city);
            Console.WriteLine(policeStation.WriteMessage($"Police station of {policeStation.GetCity().GetName()} created."));

            Taxi taxi1 = new Taxi("0001 T");
            Taxi taxi2 = new Taxi("0002 T");
            Taxi taxi3 = new Taxi("0003 T");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(taxi3.WriteMessage("Created"));
            city.registerLicense(taxi1);
            city.registerLicense(taxi1);
            city.registerLicense(taxi1);
            Console.WriteLine(taxi1.WriteMessage($"Registered in {city.GetName()}"));
            Console.WriteLine(taxi2.WriteMessage($"Registered in {city.GetName()}"));
            Console.WriteLine(taxi3.WriteMessage($"Registered in {city.GetName()}"));

            SpeedRadar speedRadar1 = new SpeedRadar();
            SpeedRadar speedRadar2 = new SpeedRadar();
            PoliceCar policeCarRadar1 = new PoliceCar("0001 P", policeStation, speedRadar1);
            PoliceCar policeCarRadar2 = new PoliceCar("0002 P", policeStation, speedRadar2);
            PoliceCar policeCarNoRadar = new PoliceCar("0003 P", policeStation);
            Console.WriteLine(policeCarRadar1.WriteMessage("Created"));
            Console.WriteLine(policeCarRadar2.WriteMessage("Created"));
            Console.WriteLine(policeCarNoRadar.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCarRadar1);
            policeStation.RegisterPoliceCar(policeCarRadar2);
            policeStation.RegisterPoliceCar(policeCarNoRadar);
            Console.WriteLine(policeCarRadar1.WriteMessage("Registered"));
            Console.WriteLine(policeCarRadar2.WriteMessage("Registered"));
            Console.WriteLine(policeCarNoRadar.WriteMessage("Registered"));

            policeCarNoRadar.UseRadar(taxi1);
            taxi1.StartRide();
            policeCarRadar1.StartPatrolling();
            policeCarRadar2.StartPatrolling();
            policeCarRadar1.UseRadar(taxi1);
            policeCarRadar1.ActivateAlarm(taxi1);
            policeStation.NotifyPlate(taxi1.GetPlate());

            city.unregisterLicense(taxi1);
            Console.WriteLine(taxi1.WriteMessage($"Unegistered in {city.GetName()}"));
        }
    }
}
    

