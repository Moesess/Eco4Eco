using TMPro;
using UnityEngine;

namespace EcoGame
{
    public class CustomEventInstance : MonoBehaviour
    {
        [SerializeField] public GameObject EventPanel;
        [SerializeField] public GameObject TitlePlaceholder;
        [SerializeField] public GameObject DescriptionPlaceholder;
        [SerializeField] public GameObject InformationWindow;
        public CustomEvent Event;

        private void Start()
        {
			TitlePlaceholder.GetComponent<TMP_Text>().text = Event.Title;
			DescriptionPlaceholder.GetComponent<TMP_Text>().text = Event.Description;
		}
        public void YesAction()
        {
	        BuildingManager.Instance.Buildings[Event.BuildingKey].ProductionMultiplier += Event.YesProductionAmount;
            ResourceManager.Instance.HappyEffectPercent += Event.YesHappinessAmount;
            Destroy(EventPanel);
            var newInformationWindow = Instantiate(InformationWindow);
            newInformationWindow.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
			var title = newInformationWindow.transform.Find("Text Group/Title").GetComponent<TMP_Text>();
			var description = newInformationWindow.transform.Find("Text Group/Description").GetComponent<TMP_Text>();
			title.text = "Konsekwencja";
			description.text = Event.EffectYesDescription;
        }
        public void NoAction()
        {
	        BuildingManager.Instance.Buildings[Event.BuildingKey].ProductionMultiplier += Event.NoProductionAmount;
	        ResourceManager.Instance.HappyEffectPercent += Event.NoHappinessAmount;
			Destroy(EventPanel);
			var newInformationWindow = Instantiate(InformationWindow);
			newInformationWindow.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
			var title = newInformationWindow.transform.Find("Text Group/Title").GetComponent<TMP_Text>();
			var description = newInformationWindow.transform.Find("Text Group/Description").GetComponent<TMP_Text>();
			title.text = "Konsekwencja";
			description.text = Event.EffectNoDescription;
		}
    }
}
