using UnityEngine;
namespace EcoGame
{
    using EcoGame.Resources;
    using System.Security.Cryptography;
    using TMPro;
    using UnityEngine.UI;

    public class SellResourcePanel : MonoBehaviour
    {
        [SerializeField] public RESOURCES eResource;
        [SerializeField] public GameObject ResourceName;
        [SerializeField] public GameObject IncButton;
        [SerializeField] public GameObject DecButton;
        [SerializeField] public GameObject AmountText;
        [SerializeField] public GameObject EarningsText;
        [SerializeField] public GameObject PriceText;
        [SerializeField] public Texture2D ImageTex;
        [SerializeField] public GameObject Image;

        private int iSellAmount;

        private void Awake()
        {
            iSellAmount = 0;
        }

        private void Start()
        {
            this.ResourceName.GetComponent<TMP_Text>().text = ResourceManager.Instance.Resources[(int)this.eResource].Name;
            this.PriceText.GetComponent<TMP_Text>().text = ResourceManager.Instance.Resources[(int)this.eResource].Price.ToString() + " $";
            this.Image.GetComponent<Image>().sprite = Sprite.Create(this.ImageTex, new Rect(0f, 0f, this.ImageTex.width, this.ImageTex.height), new Vector2(0.5f, 0.5f));

            InvokeRepeating("Sell", 1f, 1f); // Sprzedajemy co sekunde
        }

        public void IncButtonClick()
        {
            Resource Res = ResourceManager.Instance.Resources[(int)this.eResource];

            if(Res.Amount - Res.UsedAmount > 0)
            {
                this.iSellAmount++;
                Res.UsedAmount++;
                TextUpdate();
            }

            SfxManager.Instance.PlayClick();
        }

        public void DecButtonClick()
        {
            Resource Res = ResourceManager.Instance.Resources[(int)this.eResource];

            if (this.iSellAmount > 0)
            {
                this.iSellAmount--;
                Res.UsedAmount--;
                TextUpdate();
            }

            SfxManager.Instance.PlayClick();
        }

        private void TextUpdate()
        {
            this.AmountText.GetComponent<TMP_Text>().text = this.iSellAmount.ToString() + " /j";
            this.EarningsText.GetComponent<TMP_Text>().text = (ResourceManager.Instance.Resources[(int)eResource].Price * this.iSellAmount).ToString() + " $/s";
        }

        public void Sell()
        {
            ResourceManager.Instance.Budget.Amount += ResourceManager.Instance.Resources[(int)eResource].Price * this.iSellAmount;
        }
    }
}
