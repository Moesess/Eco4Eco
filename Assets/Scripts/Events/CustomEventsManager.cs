using System.Collections.Generic;
using TMPro;
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
			// Pobierz nowy event
			CustomEvent drawnEvent = new CustomEvent();

			// Ustaw placeholdery
            CustomEventInstance EventInstance = tempEventPanel.GetComponent<CustomEventInstance>();
            EventInstance.TitlePlaceholder.GetComponent<TMP_Text>().text = drawnEvent.Title;
            EventInstance.DescriptionPlaceholder.GetComponent<TMP_Text>().text = drawnEvent.Description;

            // Zainicjuj event jako game object
            GameObject eventPanel = Instantiate(tempEventPanel);
            eventPanel.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
        }
    }
}
