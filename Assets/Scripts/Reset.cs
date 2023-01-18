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
			ResourceManager.Instance.Resources[(int)RESOURCES.R_COAL].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_GAS].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_OIL].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_URANIUM].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_PEAT].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_POWER].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_FOOD].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_GOODS].SetValue(0);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_POLLUTION].SetValue(1000);
			ResourceManager.Instance.Resources[(int)RESOURCES.R_BUDGET].SetValue(1000000); ;
			ResourceManager.Instance.Resources[(int)RESOURCES.R_LEAF].Amount += 1;
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

		[SerializeField] private Button resetButton;
	}
}