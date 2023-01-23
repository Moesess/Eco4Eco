using System.Collections;
using System.Collections.Generic;
using System.IO;
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
			FillTechnologies(File.ReadAllText($"{Application.dataPath}/json/{Json.JsonConsts.TECHNOLOGY_FILE_NAME}"));
		}

		public void FillTechnologies(string json)
		{
			technologies = JsonConvert.DeserializeObject<IList<Technology>>(json);
		}
	}
}
