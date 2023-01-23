using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EcoGame
{
	public class RegulationListFiller : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
			foreach (var regulation in RegulationsSystem.Instance.regulations)
			{
				var newlistElement = Instantiate(listElement);
				newlistElement.transform.SetParent(parentObject.transform);
				RegulationListElement listElementComponent = newlistElement.GetComponent<RegulationListElement>();
				listElementComponent.title.GetComponent<TMP_Text>().text = regulation.Title;
				listElementComponent.description.GetComponent<TMP_Text>().text = regulation.Description;
				listElementComponent.price.GetComponent<TMP_Text>().text = "1 listek";
				listElementComponent.regulation = regulation;
			}
		}

		[SerializeField]
		public GameObject listElement;
		[SerializeField]
		public GameObject parentObject;
	}

}