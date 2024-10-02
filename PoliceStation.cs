namespace Practice2
{
	class PoliceStation
	{
		private List<PoliceCar> policeCars;
		private bool alert;

		public PoliceStation()
		{
			policeCars = new List<PoliceCar>();
			alert = false;
		}

		public void SetAlarm(bool alert) 
		{
			this.alert = alert;
		}
		public void RegisterPoliceCar(string policePlate)
		{
			PoliceCar policeCar = new PoliceCar(policePlate, this);
			policeCars.Add(policeCar);
		}

		public void NotifyPlate(string plate)
		{
			if (alert)
			{
				foreach (PoliceCar policeCar in policeCars)
				{
					policeCar.PersecuteVehicle(plate);
				}
			}
		}
	}
}
