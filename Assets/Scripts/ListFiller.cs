using System.Collections;
using System.Collections.Generic;
using EcoGame;
using TMPro;
using UnityEngine;

namespace EcoGame
{
	public class ListFiller : MonoBehaviour
	{
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
				listElementComponent.price.GetComponent<TMP_Text>().text = "1 listek";
				listElementComponent.technology = technology;
			}
		}

		[SerializeField]
		public GameObject listElement;
		[SerializeField]
		public int numberOfObjects;
		[SerializeField]
		public GameObject parentObject;
	}
}
