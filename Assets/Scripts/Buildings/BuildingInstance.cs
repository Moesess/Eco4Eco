using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
    public class BuildingInstance : MonoBehaviour
    {
        [SerializeField] public GameObject BuildingName;
        [SerializeField] public GameObject SellButton;
        [SerializeField] public GameObject AmountText;
        [SerializeField] public GameObject BuyButton;
        [SerializeField] public GameObject GenerateText;
        [SerializeField] public AudioSource Click;
        public int iBuildCost;
        public int iBuildAmount;
        public int iBuildKey;

        private void Awake()
        {
            //this.iBuildCost = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Cost;
            //this.iBuildAmount = BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Amount;
            //this.iBudget = ResourceManager.Instance.Budget.iAmount;
        }

        // Start is called before the first frame update
        void Start()
        {
            BuildingManager.Instance.Buildings[iBuildKey].OnIAmountChange += OnAmountChange;
        }

        // Update is called once per frame
        void Update()
        {
            if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost)
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
            if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost)
            {
                BuildingManager.Instance.Buildings[iBuildKey].IncreaseAmount(1);
                ResourceManager.Instance.Budget.Amount -= this.iBuildCost;
                Click.Play();
            }
        }

        public void SellButtonClick()
        {
            BuildingManager.Instance.Buildings[iBuildKey].DecreaseAmount();
            ResourceManager.Instance.Budget.Amount += this.iBuildCost;
            Click.Play();   
        }

        void OnAmountChange(int _iVal)
        {
            this.AmountText.GetComponent<TMP_Text>().text = _iVal.ToString();
            BuildingManager.Instance.Buildings[iBuildKey].RecalculateCost();
            BuildingManager.Instance.Buildings[iBuildKey].RecalculateProduction();
            this.GenerateText.GetComponent<TMP_Text>().text = BuildingManager.Instance.Buildings[iBuildKey].Production.ToString() + "/s";
        }
    }

}
