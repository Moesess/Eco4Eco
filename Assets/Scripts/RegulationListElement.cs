using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
	public class RegulationListElement : MonoBehaviour
	{
		// Start is called before the first frame update
		[SerializeField]
		public GameObject title;

		[SerializeField]
		public GameObject description;

		[SerializeField]
		public GameObject price;

		public Regulation regulation;

		public void BuyRegulation()
		{
			if (ResourceManager.Instance.Leaf.Amount > 0)
			{
				ResourceManager.Instance.Leaf.Amount -= 1;
				BuildingManager.Instance.Buildings[regulation.BuildingKey].CostMultiplier += regulation.CostAmount;
				BuildingManager.Instance.Buildings[regulation.BuildingKey].ProductionMultiplier += regulation.ProductionAmount;
				ResourceManager.Instance.HappyEffectPercent += regulation.HappyAmount;
				BuildingManager.Instance.Buildings[regulation.BuildingKey].Amount =
					BuildingManager.Instance.Buildings[regulation.BuildingKey].Amount;
				Destroy(gameObject);
			}
		}
	}
}
