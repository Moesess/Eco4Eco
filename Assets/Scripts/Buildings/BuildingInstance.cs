using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
    using EcoGame.Buildings;

    public class BuildingInstance : MonoBehaviour
    {
        [SerializeField] public GameObject BuildingName;
        [SerializeField] public GameObject SellButton;
        [SerializeField] public GameObject AmountText;
        [SerializeField] public GameObject BuyButton;
        [SerializeField] public GameObject GenerateText;
        public int iBuildCost;
        public int iBuildAmount;

        private void Awake()
        {
            Debug.Log("STARTUJE");
            //this.iBuildCost = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Cost;
            //this.iBuildAmount = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount;
            //this.iBudget = ResourceManager.Instance.Budget.iAmount;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (ResourceManager.Instance.Budget.iAmount >= this.iBuildCost)
            {
                BuyButton.GetComponent<Button>().enabled = true;
            } else
            {
                BuyButton.GetComponent<Button>().enabled = false;
            }

            if (iBuildAmount >= 1)
            {
                SellButton.GetComponent<Button>().enabled = true;
            } else
            {
                SellButton.GetComponent<Button>().enabled = false;
            }
        }

        public void BuyButtonClick()
        {
            if (ResourceManager.Instance.Budget.iAmount >= this.iBuildCost)
            {
                BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount += 1;
                ResourceManager.Instance.Budget.iAmount -= this.iBuildCost;
            }
        }

        public void SellButtonClick()
        {
            if (iBuildAmount >= 1)
            {
                BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount -= 1;
                ResourceManager.Instance.Budget.iAmount += this.iBuildCost;
            }
        }
    }

}
