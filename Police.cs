﻿namespace Practice2
{
	class Police
	{
		private string id;
		private PoliceStation policeStation;

		public Police(string id, PoliceStation policeStation)
		{
			this.id = id;
			this.policeStation = policeStation;
		}
		
		public string GetId()
		{
			return id;
		}

		public void SetId(string id)
		{
			this.id = id;
		}
	}
}
