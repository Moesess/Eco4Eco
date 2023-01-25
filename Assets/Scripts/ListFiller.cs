using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
	public class ListFiller : MonoBehaviour
	{

        [SerializeField]
        public GameObject listElement;
        [SerializeField]
        public int numberOfObjects;
        [SerializeField]
        public GameObject parentObject;
        [SerializeField]
        public Texture2D PriceTexture;

        // Start is called before the first frame update
        void Start()
		{
			foreach (var technology in TechnologySystem.Instance.technologies)
			{
				var newlistElement = Instantiate(listElement);
				newlistElement.transform.SetParent(parentObject.transform);
				ListElement listElementComponent = newlistElement.GetComponent<ListElement>();
				listElementComponent.title.GetComponent<TMP_Text>().text = technology.Title;
				listElementComponent.description.GetComponent<TMP_Text>().text = technology.Description;
				listElementComponent.PriceValue.GetComponent<TMP_Text>().text = "1";
				listElementComponent.Image.GetComponent<Image>().sprite = Sprite.Create(PriceTexture, new Rect(0f, 0f, PriceTexture.width, PriceTexture.height), new Vector2(0.5f, 0.5f));
                listElementComponent.technology = technology;
			}
		}
<<<<<<< HEAD

		[SerializeField]
		public GameObject listElement;
		[SerializeField]
		public GameObject parentObject;
	}
=======
    }
>>>>>>> stable
}
