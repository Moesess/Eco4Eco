using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
    public class ResourceInstance : MonoBehaviour
    {
        [SerializeField] public TMP_Text Value;
        [SerializeField] public GameObject Image;
        [SerializeField] public Texture2D ImageTex;
        public Resources.RESOURCES eResource;

        void Start()
        {
            ResourceManager.Instance.Resources[(int)eResource].OnAmountChange += OnValueChange;
            ResourceManager.Instance.Resources[(int)eResource].OnUsedAmountChange += OnUsedChange;
            this.Image.GetComponent<Image>().sprite = Sprite.Create(this.ImageTex, new Rect(0f, 0f, ImageTex.width, ImageTex.height), new Vector2(0.5f, 0.5f));
        }

        public void OnValueChange() 
        {
            if(eResource != Resources.RESOURCES.R_NULL)
            {
                int iMaxAmount = ResourceManager.Instance.Resources[(int)eResource].MaxAmount;
                int iAmount = ResourceManager.Instance.Resources[(int)eResource].Amount;
                int iUsedAmount = ResourceManager.Instance.Resources[(int)eResource].UsedAmount;

                if (this.eResource == Resources.RESOURCES.R_HAPPY)
                {
                    // Dla zadowolenia zmieniamy kolor ikonki
                    if (((float)iAmount / (float)iMaxAmount) >= 0.75f)
                    {
                        this.Image.GetComponent<Image>().color = Colors.Good;
                        this.Value.color = Colors.Good;
                    }
                    else if (((float)iAmount / (float)iMaxAmount) < 0.75f && ((float)iAmount / (float)iMaxAmount) > 0.30f)
                    {
                        this.Image.GetComponent<Image>().color = Colors.Medium;
                        this.Value.color = Colors.Medium;
                    }
                    else
                    {
                        this.Image.GetComponent<Image>().color = Colors.Bad;
                        this.Value.color = Colors.Bad;
                    }

                    this.Value.text = iAmount.ToString() + " / " + iMaxAmount.ToString();
                }
                else if (this.eResource == Resources.RESOURCES.R_BUDGET)
                {
                    this.Value.text = iAmount.ToString();
                }
                else
                    this.Value.text = (iAmount - iUsedAmount).ToString() + " / " + iAmount.ToString();
            }
        }

        public void OnUsedChange()
        {
            if (this.eResource != Resources.RESOURCES.R_HAPPY || this.eResource != Resources.RESOURCES.R_BUDGET)
            {
                int iUsedAmount = ResourceManager.Instance.Resources[(int)eResource].UsedAmount;
                int iAmount = ResourceManager.Instance.Resources[(int)eResource].Amount;
                this.Value.text = (iAmount - iUsedAmount).ToString() + " / " + iAmount.ToString();

                if (iAmount - iUsedAmount < 0)
                    this.Value.color = Colors.Bad;
                else
                    this.Value.color = Colors.Good;
            }
        }
    }
}
