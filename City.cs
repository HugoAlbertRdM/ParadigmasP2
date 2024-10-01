using System;
using PoliceStation;
using Taxi;

namespace Practica2
{
	class City
	{
		private string name;
		private policeStation policeStation;
		private List<Taxi> taxiLicenses;

		public City(string name, PoliceStation policeStation)
		{
			this.name = name;
			this.policeStation = policeStation;
			taxiLicenses = new List<string>();
		}

		public string GetName()
		{ 
			return name;
		}

		public void SetName(string name)
		{
			this.name=name;
		}

		public PoliceStation GetPoliceStation()
		{ 
			return policeStation; 
		}

		public void SetPoliceStation(PoliceStation policeStation)
		{
			this.policeStation = policeStation;
		}

		public List<Taxi> GetTaxiLicenses():
		{
			return taxiLicenses; 
		}

		public void registerLicense(string taxiPlate)
		{
			taxi = new Taxi(taxiPlate);
			taxiLicenses.Add(taxi);
		}

		public void unregisterLicense(Taxi taxi) 
		{
			taxiLicenses.remove(taxi)
		}
}