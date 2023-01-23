using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace EcoGame
{
	public struct Regulation
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public int CostAmount { get; set; }
		public int ProductionAmount { get; set; }
		public int HappyAmount { get; set; }
		public int BuildingKey { get; set; }
	}
	public class RegulationsSystem : MonoBehaviour
	{
		public IList<Regulation> regulations;
		public static RegulationsSystem Instance;

		private void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
			}

			FillRegulations(File.ReadAllText($"{Application.dataPath}/json/{Json.JsonConsts.REGULATION_FILE_NAME}"));
		}

		public void FillRegulations(string json)
		{
			regulations = JsonConvert.DeserializeObject<IList<Regulation>>(json);
		}
	}
}
