using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using EcoGame;
using EcoGame.Buildings;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowInformations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] 
	public Button showInformationsButton;

	[SerializeField] 
	public GameObject informationsPanelPrefab;

	[SerializeField] 
	public Texture2D arrowCursor;

	[SerializeField] 
	public Texture2D handCursor;
	
	[SerializeField]
	public GameObject Building;

	private GameObject informationPanel;
	// Start is called before the first frame update
	private void Start()
    {
        showInformationsButton.onClick.AddListener(DisplayInformations);
    }
    public void DisplayInformations()
    {
		informationPanel = PrefabUtility.InstantiatePrefab(informationsPanelPrefab) as GameObject;
		informationPanel.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
		var title = informationPanel.transform.Find("Text Group/Title").GetComponent<TMP_Text>();
		var description = informationPanel.transform.Find("Text Group/Description").GetComponent<TMP_Text>();
		title.text = BuildingManager.Instance.Buildings[Building.GetComponent<BuildingInstance>().iBuildKey].Name;
		description.text = BuildingManager.Instance.Buildings[Building.GetComponent<BuildingInstance>().iBuildKey].Description;
        informationPanel.GetComponentInChildren<Button>().onClick.AddListener(CloseWindow);
    }

    public void CloseWindow()
    {
        Destroy(informationPanel);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
		Cursor.SetCursor(handCursor, Vector2.zero, CursorMode.Auto);
	}

    public void OnPointerExit(PointerEventData eventData)
    {
		Cursor.SetCursor(arrowCursor, Vector2.zero, CursorMode.Auto);
	}
}
