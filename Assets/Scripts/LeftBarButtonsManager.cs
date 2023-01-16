using System.Linq;
using UnityEngine;
using UnityEngine.UI;
namespace EcoGame
{
	public class LeftBarButtonsManager : MonoBehaviour
	{
		public delegate void OnClickButtonSwapPanelDelegate(GameObject newPanel);
		public event OnClickButtonSwapPanelDelegate OnClickButtonSwapPanel;
		// Start is called before the first frame update
		void Start()
		{
			panels[2].SetActive(true);
			currentPanel = panels[2];
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
			currentPanel.SetActive(false);
			currentPanel = panel;
			currentPanel.SetActive(true);
		}
	}
}
