using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace EcoGame
{
	using static ResourceManager;
	using static BuildingManager;
	
	using Buildings;
	public class SellBuildingScript : MonoBehaviour
	{
		[SerializeField] public GameObject sellButton;
		[SerializeField] public GameObject buildingAmountText;
		
		public void ClickTheButton()
		{
			int buildingAmount = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount;
			int buildingCost = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Cost;
			if (buildingAmount >= 1){
				BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount -= 1;
				ResourceManager.Instance.Budget.iAmount += buildingCost;
			}
		}

        public void Update()
        {
			int buildingAmount = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount;
			if (buildingAmount >= 1)
			{
				sellButton.GetComponent<Button>().enabled = true;
			}else
            {
				sellButton.GetComponent<Button>().enabled = false;
            }
		}
    }
}
