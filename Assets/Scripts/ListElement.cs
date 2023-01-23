using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
	public class ListElement : MonoBehaviour
	{
		// Start is called before the first frame update
		[SerializeField]
		public GameObject title;

		[SerializeField]
		public GameObject description;

		[SerializeField]
		public GameObject price;

		public Technology technology;

		public void BuyTechnology()
		{
			if (ResourceManager.Instance.Leaf.Amount > 0)
			{
				ResourceManager.Instance.Leaf.Amount -= 1;
				BuildingManager.Instance.Buildings[technology.BuildingKey].CostMultiplier += technology.CostAmount;
				BuildingManager.Instance.Buildings[technology.BuildingKey].ProductionMultiplier += technology.ProductionAmount;
				BuildingManager.Instance.Buildings[technology.BuildingKey].Amount =
					BuildingManager.Instance.Buildings[technology.BuildingKey].Amount;
				Destroy(gameObject);
			}
		}
	}
}
