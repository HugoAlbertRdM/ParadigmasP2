namespace Practice2
{
	class City: IMessageWritter
	{
		private string name;
		private List<Taxi> taxiLicenses;

		public City(string name)
		{
			this.name = name;
			taxiLicenses = new List<Taxi>();
		}

		public string GetName()
		{
			return name;
		}

		public void SetName(string name)
		{
			this.name = name;
		}

		public List<Taxi> GetTaxiLicenses()
		{
			return taxiLicenses;
		}

		public void registerLicense(Taxi taxi)
		{;
			taxiLicenses.Add(taxi);
		}

		public void unregisterLicense(Taxi taxi)
		{
			taxiLicenses.Remove(taxi);
		}

		public string WriteMessage(string message)
		{
			return $"City {name}: message";
		}
	}
}