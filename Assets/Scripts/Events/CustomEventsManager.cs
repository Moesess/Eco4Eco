using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
	public class CustomEventsManager : MonoBehaviour
	{
		public static CustomEventsManager Instance;
		IList<CustomEvent> events;
		float deltaTime;
		[SerializeField]
		GameObject tempEventPanel;

		// Start is called before the first frame update
		void Start()
		{
			InvokeRepeating("DisplayEvent", 1f, (float)Random.Range(900, 1800));
		}


		void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
				events = LoadAllPossibleEvents();
			}
		}

		private IList<CustomEvent> LoadAllPossibleEvents()
		{
			//return JsonConvert.DeserializeObject<IList<CustomEvent>>(JsonConsts.EVENT_FILE_NAME);
			return new List<CustomEvent>();
		}

		private CustomEvent DrawNewEvent()
		{
			int randomEventIndex = Random.Range(0, events.Count - 1);
			return events[randomEventIndex];
		}

		private void DisplayEvent()
		{
			CustomEvent drawnEvent = new CustomEvent();
			GameObject eventPanel = PrefabUtility.InstantiatePrefab(tempEventPanel) as GameObject;
			eventPanel.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
			TMP_Text title = GameObject.Find("Event Panel/Text Group/Title").GetComponent<TMP_Text>();
			TMP_Text description = GameObject.Find("Event Panel/Text Group/Description").GetComponent<TMP_Text>();
			Button yesButton = GameObject.Find("Event Panel/Button Group/Yes Button").GetComponent<Button>();
			Button noButton = GameObject.Find("Event Panel/Button Group/No Button").GetComponent<Button>();

			yesButton.onClick.AddListener(YesAction);
			noButton.onClick.AddListener(NoAction);

			title.text = drawnEvent.Title;
			description.text = drawnEvent.Description;

		}

		private void YesAction()
		{
			//something happens
			Destroy(GameObject.Find("Event Panel"));
		}
		private void NoAction()
		{
			//something happens
			Destroy(GameObject.Find("Event Panel"));
		}
	}
}
