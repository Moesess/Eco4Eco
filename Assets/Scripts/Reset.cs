using System.Collections;
using System.Collections.Generic;
using EcoGame;
using EcoGame.Buildings;
using EcoGame.Resources;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
	public class Reset : MonoBehaviour
	{
		public void CallReset()
		{
			/*if (ResourceManager.Instance.Resources[(int)RESOURCES.R_POLLUTION].Amount == 0
			&& ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].Amount <= 25)
			{*/
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

		[SerializeField] private Button resetButton;
	}
}