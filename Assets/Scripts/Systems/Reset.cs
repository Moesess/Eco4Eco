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
	using static Resources.START_RESOURCE_VALUES;
	public class Reset : MonoBehaviour
	{
		private bool isReset = false;
		[SerializeField] public GameObject resetButton;
		public void CallReset()
		{
			if (this.isReset == true)
			{
				ResourceManager.Instance.Resources[(int)RESOURCES.R_COAL].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_GAS].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_OIL].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_URANIUM].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_PEAT].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_POWER].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_FOOD].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_GOODS].SetValue(0);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_POLLUTION].SetValue((int)S_POLLUTION);
				ResourceManager.Instance.Resources[(int)RESOURCES.R_BUDGET].SetValue((int)S_BUDGET * 5); ;
				ResourceManager.Instance.Resources[(int)RESOURCES.R_LEAF].Amount += 1;
				foreach (var VARIABLE in BuildingManager.Instance.Buildings)
				{
					VARIABLE.Value.Amount = 0;
				}
				this.isReset = false;
				resetButton.GetComponent<Button>().interactable = false;
				resetButton.GetComponent<Image>().color = Colors.Bad;
			}
		}
		public void Start()
		{
			ResourceManager.Instance.Resources[(int)RESOURCES.R_POLLUTION].OnAmountChange += IsReset;
			ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].OnAmountChange += IsReset;
		}

		public void IsReset()
		{
			if(this.isReset == true)
            {
				return;
            }
			if (ResourceManager.Instance.Resources[(int)RESOURCES.R_POLLUTION].Amount <= 0
			&& ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].Amount - ResourceManager.Instance.Resources[(int)RESOURCES.R_TRASH].UsedAmount >= 0)
			{
				isReset = true;
				resetButton.GetComponent<Button>().interactable = true;
				resetButton.GetComponent<Image>().color = Colors.Good;
			}
			else
			{
				isReset = false;
				resetButton.GetComponent<Button>().interactable = false;
				resetButton.GetComponent<Image>().color = Colors.Bad;
			}
		}

		
	}
}