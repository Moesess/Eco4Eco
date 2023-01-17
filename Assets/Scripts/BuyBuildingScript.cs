using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
	using static Buildings.BUILDINGS;
	public class BuyBuildingScript : MonoBehaviour
	{
		[SerializeField] public GameObject buyButton;
		[SerializeField] public GameObject buildingAmountText;
		
		public void ClickTheButton()
		{
			int budget = ResourceManager.Instance.Budget.Amount;
			int buildingCost = BuildingManager.Instance.Buildings[(int)BUILDING_MINE_OIL].Cost;
			if (budget >= buildingCost){
				BuildingManager.Instance.Buildings[(int)BUILDING_MINE_OIL].Amount += 1;
				ResourceManager.Instance.Budget.Amount -= buildingCost;
				//string amount = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount.ToString();
				//buildingAmountText.GetComponent<TMP_Text>().text = amount; #TODO debebu
			}
		}

        public void Update()
        {
			int budget = ResourceManager.Instance.Budget.Amount;
			int buildingCost = BuildingManager.Instance.Buildings[(int)BUILDING_MINE_OIL].Cost;
			if (budget >= buildingCost)
			{
				buyButton.GetComponent<Button>().enabled = true;
			}else
            {
				buyButton.GetComponent<Button>().enabled = false;
            }
		}
    }
}
