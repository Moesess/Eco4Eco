using EcoGame;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ResourcePresenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("UpdateResources", 1f, 1f);
	}

	// Update is called once per frame
	private void Awake()
	{
		this.budgetValue = GameObject.Find("Budget/Value").GetComponent<TMP_Text>();
		this.powerValue = GameObject.Find("Power/Value").GetComponent<TMP_Text>();
		this.trashValue = GameObject.Find("Trash/Value").GetComponent<TMP_Text>();
		this.foodValue = GameObject.Find("Food/Value").GetComponent<TMP_Text>();
		this.goodsValue = GameObject.Find("Goods/Value").GetComponent<TMP_Text>();
	}

	private void UpdateResources()
	{
		this.budgetValue.text = ResourceManager.Instance.Budget.iAmount.ToString();
		this.powerValue.text = ResourceManager.Instance.Power.iAmount.ToString();
		this.trashValue.text = ResourceManager.Instance.Trash.iAmount.ToString();
		this.foodValue.text = ResourceManager.Instance.Food.iAmount.ToString();
		this.goodsValue.text = ResourceManager.Instance.Goods.iAmount.ToString();
	}

	private TMP_Text budgetValue;
	private TMP_Text powerValue;
	private TMP_Text trashValue;
	private TMP_Text foodValue;
	private TMP_Text goodsValue;
}
