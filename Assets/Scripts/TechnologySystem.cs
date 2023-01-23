using System.Collections;
using System.Collections.Generic;
using EcoGame;
using Newtonsoft.Json;
using Unity.VisualScripting;
using UnityEngine;

namespace EcoGame
{
	public struct Technology
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public int CostAmount { get; set; }
		public int ProductionAmount { get; set; }
		public int BuildingKey { get; set; }
	}
	public class TechnologySystem : MonoBehaviour
	{
		public IList<Technology> technologies;
		public static TechnologySystem Instance;
		private void Start()
		{
			if (Instance == null)
			{
				Instance = this;

			}
			FillTechnologies($"[\r\n   {{\r\n      \"Title\":\"Opis\",\r\n      \"Description\":\"Opis\",\r\n      \"CostAmount\":10,\r\n      \"ProductionAmount\":0,\r\n      \"BuildingKey\":0\r\n   }},\r\n   {{\r\n      \"Title\":\"Opis\",\r\n      \"Description\":\"Opis\",\r\n      \"CostAmount\":10,\r\n      \"ProductionAmount\":0,\r\n      \"BuildingKey\":0\r\n   }}\r\n]");
		}
		public void BuyTechnology(Technology technology)
		{
			BuildingManager.Instance.Buildings[technology.BuildingKey].CostMultiplier += technology.CostAmount;
			BuildingManager.Instance.Buildings[technology.BuildingKey].ProductionMultiplier += technology.ProductionAmount;
		}

		public void FillTechnologies(string json)
		{
			technologies = JsonConvert.DeserializeObject<IList<Technology>>(json);
		}
	}
}
