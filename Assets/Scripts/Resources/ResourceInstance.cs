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
            this.Image.GetComponent<Image>().sprite = Sprite.Create(this.ImageTex, new Rect(0f, 0f, ImageTex.width, ImageTex.height), new Vector2(0.5f, 0.5f));
            OnValueChange(ResourceManager.Instance.Resources[(int)eResource].Amount);
        }

        public void OnValueChange(int iAmount) 
        {
            int iMaxAmount = ResourceManager.Instance.Resources[(int)eResource].MaxAmount;
            int iUsedAmount = ResourceManager.Instance.Resources[(int)eResource].UsedAmount;

            if (eResource == Resources.RESOURCES.R_HAPPY)
            {
                // Dla zadowolenia zmieniamy kolor ikonki
                if (((float)iAmount / (float)iMaxAmount) >= 0.75f)
                    this.Image.GetComponent<Image>().color = Colors.Good;
                else if (((float)iAmount / (float)iMaxAmount) < 0.75f && ((float)iAmount / (float)iMaxAmount) > 0.30f)
                    this.Image.GetComponent<Image>().color = Colors.Medium;
                else
                    this.Image.GetComponent<Image>().color = Colors.Bad;

                Value.text = iAmount.ToString() + " / " + iMaxAmount.ToString();
            }
            else
                Value.text = (iAmount - iUsedAmount).ToString() + " / " + iAmount.ToString();
        }
    }
}
