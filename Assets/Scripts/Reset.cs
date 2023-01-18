using System.Collections;
using System.Collections.Generic;
using EcoGame;
using EcoGame.Buildings;
using EcoGame.Resources;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MyNamespace
{
	public class Reset : MonoBehaviour
	{
		public delegate void OnClickResetDelegate();
		public event OnClickResetDelegate onClickReset;
		public void CallReset()
		{
			//if (ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_POLLUTION].Amount == 0
			//&& ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_TRASH].Amount <= 25)
			//{
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_COAL].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_GAS].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_OIL].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_URANIUM].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_PEAT].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_POWER].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_TRASH].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_FOOD].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_GOODS].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_POLLUTION].SetValue(1000);
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_BUDGET].SetValue(1000000); ;
			ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_LEAF].Amount += 1;
			foreach (var VARIABLE in BuildingManager.Instance.Buildings)
			{
				VARIABLE.Value.Amount = 0;
			}
			//}
		}

		private void Start()
		{
			onClickReset += CallReset;
			if(resetButton != null)
				resetButton.onClick.AddListener(delegate { onClickReset(); });

		}
		private void Update()
		{
			if(Input.GetKeyDown(KeyCode.A))
				CallReset();
		}

		[SerializeField] private Button resetButton;
	}
}