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
        public Resources.RESOURCES ResourceName;

        void Start()
        {
            ResourceManager.Instance.Resources[(int)ResourceName].OnAmountChange += OnValueChange;
            this.Image.GetComponent<Image>().sprite = Sprite.Create(this.ImageTex, new Rect(0f, 0f, ImageTex.width, ImageTex.height), new Vector2(0.5f, 0.5f));
        }

        public void OnValueChange(int _iVal) 
        {
            Value.text = _iVal.ToString();

            if (ResourceName == Resources.RESOURCES.R_HAPPY)
            {
                int iAmount = ResourceManager.Instance.Resources[(int)ResourceName].Amount;
                int iMaxAmount = ResourceManager.Instance.Resources[(int)ResourceName].MaxAmount;

                // Dla zadowolenia zmieniamy kolor ikonki
                if (((float)iAmount / (float)iMaxAmount) >= 0.75f)
                    this.Image.GetComponent<Image>().color = Colors.Colors.Good;
                else if (((float)iAmount / (float)iMaxAmount) < 0.75f && ((float)iAmount / (float)iMaxAmount) > 0.30f)
                    this.Image.GetComponent<Image>().color = Colors.Colors.Medium;
                else
                    this.Image.GetComponent<Image>().color = Colors.Colors.Bad;
                
            }
        }
    }
}
