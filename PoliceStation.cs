namespace Practice2
{
	class PoliceStation: IMessageWritter
	{
		private List<PoliceCar> policeCars;
		private bool alert;
		private City city;
		public PoliceStation(City city)
		{
			this.city = city;
			policeCars = new List<PoliceCar>();
			alert = false;
		}
		public City GetCity()
		{
			return city;
		}
		public void SetAlarm(bool alert) 
		{
			this.alert = alert;
		}
		public void RegisterPoliceCar(PoliceCar policeCar)
		{
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
			else
			{
				Console.WriteLine(WriteMessage("No alert received"));
			}
		}
		public string WriteMessage(string message)
		{
			return $"Police station of {city.GetName()}: {message}";
		}
	}
}
