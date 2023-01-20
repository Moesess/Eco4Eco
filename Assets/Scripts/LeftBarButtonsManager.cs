using System.Linq;
using UnityEngine;
using UnityEngine.UI;
namespace EcoGame
{
	public class LeftBarButtonsManager : MonoBehaviour
	{
		public delegate void OnClickButtonSwapPanelDelegate(GameObject newPanel);
		public event OnClickButtonSwapPanelDelegate OnClickButtonSwapPanel;
		private void Awake()
		{
			foreach(GameObject panel in panels)
			{
                panel.GetComponent<CanvasGroup>().interactable = false;
                panel.GetComponent<CanvasGroup>().alpha = 0;
                panel.GetComponent<CanvasGroup>().blocksRaycasts = false;

            }
		}

		// Start is called before the first frame update
		void Start()
		{
            panels[0].GetComponent<CanvasGroup>().interactable = true;
            panels[0].GetComponent<CanvasGroup>().alpha = 1;
            panels[0].GetComponent<CanvasGroup>().blocksRaycasts = true;
            currentPanel = panels[0];
			OnClickButtonSwapPanel += SwapPanel;

			foreach(var button in buttons.Select((value, i) => new { i, value }))
			{
				button.value.onClick.AddListener(delegate { OnClickButtonSwapPanel(panels[button.i]); });
			}

		}

		[SerializeField]
		GameObject[] panels;
		[SerializeField]
		Button[] buttons;
		GameObject currentPanel;

		void SwapPanel(GameObject panel)
		{
            currentPanel.GetComponent<CanvasGroup>().interactable = false;
            currentPanel.GetComponent<CanvasGroup>().alpha = 0;
            currentPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;

			currentPanel = panel;

            currentPanel.GetComponent<CanvasGroup>().interactable = true;
            currentPanel.GetComponent<CanvasGroup>().alpha = 1;
            currentPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
	}
}
