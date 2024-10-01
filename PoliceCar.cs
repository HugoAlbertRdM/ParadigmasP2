using PoliceStation

namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private PoliceStation policeStation;
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool persecutingVehicle;

        public PoliceCar(string plate, PoliceStation policeStation, SpeedRadar speedRadar) : base(typeOfVehicle, plate)
        {
            this.policeStation = policeStation;
            this.speedRadar = speedRadar;
            isPatrolling = false;
            persecutingVehicle = false;
        }

        public PoliceCar(string plate, PoliceStation policeStation) : base(typeOfVehicle, plate)
        {
            this.policeStation = policeStation;
            speedRadar = null;
            isPatrolling = false;
            persecutingVehicle = false;
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (speedRadar != null)
            {
                if (isPatrolling)
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("has no radar."))
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void ActivateAlarm(VehicleWithPlate vehicle)
        {
            policeStation.SetAlarm(true);
            policeStation.NotifyPlate(vehicle.GetPlate());
        }
        

        public void PersecuteVehicle(string plate):
            persecutingVehicle = true;
            /// falta acabar este método y decidir qué hacemos para 
            /// dejar de perseguir
    }
}