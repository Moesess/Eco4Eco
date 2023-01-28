using System.Collections;
using System.Collections.Generic;
using EcoGame;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegulationListFiller : MonoBehaviour
{
	[SerializeField] public GameObject listElement;
	[SerializeField] public GameObject parentObject;

	[SerializeField] public Texture2D PriceTexture;

	// Start is called before the first frame update
	void Start()
	{
		foreach (var regulation in RegulationSystem.Instance.regulations)
		{
			var newListElement = Instantiate(listElement);
			newListElement.transform.SetParent(parentObject.transform);
			RegulationListElement listElementComponent = newListElement.GetComponent<RegulationListElement>();
			listElementComponent.title.GetComponent<TMP_Text>().text = regulation.Title;
			listElementComponent.description.GetComponent<TMP_Text>().text = regulation.Description;
			listElementComponent.PriceValue.GetComponent<TMP_Text>().text = regulation.Price.ToString();
			listElementComponent.Image.GetComponent<Image>().sprite = Sprite.Create(PriceTexture,
				new Rect(0f, 0f, PriceTexture.width, PriceTexture.height), new Vector2(0.5f, 0.5f));
			listElementComponent.regulation = regulation;
		}
	}
}
