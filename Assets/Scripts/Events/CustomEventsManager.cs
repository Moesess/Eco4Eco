using System.Collections.Generic;
using System.IO;
using EcoGame.Json;
using Newtonsoft.Json;
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

		public IList<CustomEvent> LoadAllPossibleEvents()
		{
			return JsonConvert.DeserializeObject<IList<CustomEvent>>(File.ReadAllText($"{Application.dataPath}/json/{Json.JsonConsts.EVENT_FILE_NAME}"));
		}

		private CustomEvent DrawNewEvent()
		{
			int randomEventIndex = Random.Range(0, events.Count);
			return events[randomEventIndex];
		}

		private void DisplayEvent()
		{
			// Pobierz nowy event
			CustomEvent drawnEvent = DrawNewEvent();
			

            // Zainicjuj event jako game object
            GameObject eventPanel = Instantiate(tempEventPanel);
            eventPanel.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
            CustomEventInstance EventInstance = eventPanel.GetComponent<CustomEventInstance>();
            EventInstance.Event = drawnEvent;
		}
    }
}
