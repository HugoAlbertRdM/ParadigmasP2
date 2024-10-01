using System;
using PoliceCar;

namespace Practica2
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

		public void RegisterPoliceCar(string policePlate)
		{
			policeCar = new PoliceCar(string policePlate);
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
{