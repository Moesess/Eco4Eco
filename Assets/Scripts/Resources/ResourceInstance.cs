using System.Collections;
using System.Collections.Generic;
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
        public int iResourceName;

        void Start()
        {
            ResourceManager.Instance.Resources[iResourceName].OnIAmountChange += OnValueChange;
            this.Image.GetComponent<Image>().sprite = Sprite.Create(this.ImageTex, new Rect(0f, 0f, ImageTex.width, ImageTex.height), new Vector2(0.5f, 0.5f));
        }

        public void OnValueChange(int _iVal) 
        {
            Value.text = _iVal.ToString();
        }
    }
}
