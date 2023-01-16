using EcoGame;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
namespace EcoGame
{
	public class ResourcePresenter : MonoBehaviour
	{
		public static ResourcePresenter Instance;

		public void OnPowerChanged(int value)
		{
			powerValue.text = value.ToString();
		}
		public void OnBudgetChanged(int value)
		{
			budgetValue.text = value.ToString();
		}
		public void OnTrashChanged(int value)
		{
			trashValue.text = value.ToString();
		}
		public void OnFoodChanged(int value)
		{
			foodValue.text = value.ToString();
		}
		public void OnGoodsChanged(int value)
		{
			goodsValue.text = value.ToString();
		}

		// Start is called before the first frame update
		void Start()
		{
		}

		private void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
				this.budgetValue = GameObject.Find("Budget/Value").GetComponent<TMP_Text>();
				this.powerValue = GameObject.Find("Power/Value").GetComponent<TMP_Text>();
				this.trashValue = GameObject.Find("Trash/Value").GetComponent<TMP_Text>();
				this.foodValue = GameObject.Find("Food/Value").GetComponent<TMP_Text>();
				this.goodsValue = GameObject.Find("Goods/Value").GetComponent<TMP_Text>();

				budgetValue.text = "0";
				powerValue.text	 = "0";
				trashValue.text	 = "0";
				foodValue.text	 = "0";
				goodsValue.text = "0";
				//ResourceManager.Instance.Budget.OnIAmountChange += OnBudgetChanged;
			}
		}
		public TMP_Text budgetValue;
		public TMP_Text powerValue;
		public TMP_Text trashValue;
		public TMP_Text foodValue;
		public TMP_Text goodsValue;
	}
}
