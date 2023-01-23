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
				newlistElement.transform.Find("Title").GetComponent<TMP_Text>().text = technology.Title;
				newlistElement.transform.Find("Description").GetComponent<TMP_Text>().text = technology.Description;
				newlistElement.transform.Find("Prices").GetComponent<TMP_Text>().text = "1 listek";
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
