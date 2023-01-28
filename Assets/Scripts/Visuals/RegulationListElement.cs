using EcoGame;
using System.Collections;
using System.Collections.Generic;
using EcoGame.Resources;
using UnityEngine;

public class RegulationListElement : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField]
	public GameObject title;

	[SerializeField]
	public GameObject description;

	[SerializeField]
	public GameObject PriceValue;

	[SerializeField]
	public GameObject Image;

	public Regulation regulation;

	public void BuyRegulation()
	{
		if (ResourceManager.Instance.Resources[(int)RESOURCES.R_BUDGET].Amount >= regulation.Price)
		{
			ResourceManager.Instance.Resources[(int)RESOURCES.R_BUDGET].Amount -= regulation.Price;
			BuildingManager.Instance.Buildings[regulation.BuildingKey].CostMultiplier += regulation.CostAmount;
			BuildingManager.Instance.Buildings[regulation.BuildingKey].ProductionMultiplier += regulation.ProductionAmount;
			ResourceManager.Instance.Resources[(int)RESOURCES.R_HAPPY].Amount += regulation.HappinessAmount;
			BuildingManager.Instance.Buildings[regulation.BuildingKey].Amount = BuildingManager.Instance.Buildings[regulation.BuildingKey].Amount;
			Destroy(gameObject);
		}
	}
}
