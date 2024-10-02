﻿namespace Practice2
{
	class City: IMessageWritter
	{
		private string name;
		private PoliceStation policeStation;
		private List<Taxi> taxiLicenses;

		public City(string name, PoliceStation policeStation)
		{
			this.name = name;
			this.policeStation = policeStation;
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

		public PoliceStation GetPoliceStation()
		{
			return policeStation;
		}

		public void SetPoliceStation(PoliceStation policeStation)
		{
			this.policeStation = policeStation;
		}

		public List<Taxi> GetTaxiLicenses()
		{
			return taxiLicenses;
		}

		public void registerLicense(string taxiPlate)
		{
			Taxi taxi = new Taxi(taxiPlate);
			taxiLicenses.Add(taxi);
		}

		public void unregisterLicense(Taxi taxi)
		{
			taxiLicenses.Remove(taxi);
		}

		public string WriteMessage(string message)
		{
			return message;
		}
	}
}