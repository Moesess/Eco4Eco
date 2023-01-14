using EcoGameCore.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CustomEventsManager : MonoBehaviour
{
	public static CustomEventsManager Instance;
	IList<CustomEvent> events;
	float deltaTime;
	[SerializeField]
	GameObject eventPanel;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("DisplayEvent", 60f, (float)Random.Range(900,1800));
	}


	void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
			events = LoadAllPossibleEvents();
		}
	}

	private IList<CustomEvent> LoadAllPossibleEvents()
	{
		return JsonConvert.DeserializeObject<IList<CustomEvent>>(JsonConsts.EVENT_FILE_NAME);
	}

	private CustomEvent DrawNewEvent()
	{
		int randomEventIndex = Random.Range(0, events.Count - 1);
		return events[randomEventIndex];
	}

	private void DisplayEvent(CustomEvent drawnEvent)
	{
		Instantiate(eventPanel);
		TextMeshPro title = eventPanel.GetComponent("Text Group").GetComponent("Title").GetComponent<TextMeshPro>();
		TextMeshPro description = eventPanel.GetComponent("Text Group").GetComponent("Description").GetComponent<TextMeshPro>();
		title.text = drawnEvent.Title;
	}
}
