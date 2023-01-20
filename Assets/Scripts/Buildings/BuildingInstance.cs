using EcoGame.Buildings;
using EcoGame.Resources;
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

        // Start is called before the first frame update
        void Start()
        {
            BuildingManager.Instance.Buildings[iBuildKey].OnIAmountChange += OnAmountChange;
            CheckButtonInteractable();
        }

        public void BuyButtonClick()
        {
            _BaseBuilding Building = BuildingManager.Instance.Buildings[iBuildKey];
            //Jezeli budynek nie korzysta z surowcow
            if (Building.UsedResource == RESOURCES.R_NULL)
            {
                if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost)
                {
                    Building.IncreaseAmount();
                    ResourceManager.Instance.Budget.Amount -= this.iBuildCost;
                }
            }
            else
            {
                Resource UsedRes = ResourceManager.Instance.Resources[(int)Building.UsedResource];

                if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost && (UsedRes.Amount - UsedRes.UsedAmount) > 0)
                {
                    Building.IncreaseAmount();
                    ResourceManager.Instance.Budget.Amount -= this.iBuildCost;
                }
            }
            Click.Play();
        }

        public void SellButtonClick()
        {
            _BaseBuilding Building = BuildingManager.Instance.Buildings[iBuildKey];

            if (Building.Resource == RESOURCES.R_NULL)
            {
                if (Building.Amount > 0)
                {
                    Building.DecreaseAmount();
                    ResourceManager.Instance.Budget.Amount += this.iBuildCost;
                }
            }
            else
            {
                Resource UsedRes = ResourceManager.Instance.Resources[(int)Building.Resource];

                if (Building.Amount > 0 && UsedRes.Amount - UsedRes.UsedAmount > 0)
                {
                    Building.DecreaseAmount();
                    ResourceManager.Instance.Budget.Amount += this.iBuildCost;
                   
                }
            }
            Click.Play();
        }

        public void OnAmountChange()
        {
            _BaseBuilding Building = BuildingManager.Instance.Buildings[iBuildKey];
            BuildingManager.Instance.Recalculate();
            this.AmountText.GetComponent<TMP_Text>().text = Building.Amount.ToString();
            this.GenerateText.GetComponent<TMP_Text>().text = Building.Production.ToString() + " j.";

            CheckButtonInteractable();
        }

        public void CheckButtonInteractable() 
        {
            _BaseBuilding Building = BuildingManager.Instance.Buildings[iBuildKey];
            if (Building.Resource == RESOURCES.R_NULL)
            {
                if (Building.Amount > 0)
                {
                    SellButton.GetComponent<Button>().interactable = true;
                }
                else
                    SellButton.GetComponent<Button>().interactable = false;

                if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost)
                {
                    BuyButton.GetComponent<Button>().interactable = true;
                }
                else
                    BuyButton.GetComponent<Button>().interactable = false;
            }
            else
            {
                Resource UsedRes = ResourceManager.Instance.Resources[(int)Building.Resource];

                if (Building.Amount > 0 && UsedRes.Amount - UsedRes.UsedAmount > 0)
                {
                    SellButton.GetComponent<Button>().interactable = true;

                }
                else
                    SellButton.GetComponent<Button>().interactable = false;

                if (ResourceManager.Instance.Budget.Amount >= this.iBuildCost && (UsedRes.Amount - UsedRes.UsedAmount) > 0)
                {
                    BuyButton.GetComponent<Button>().interactable = true;
                }
                else
                    BuyButton.GetComponent<Button>().interactable = false;

            }
        }
    }

}
