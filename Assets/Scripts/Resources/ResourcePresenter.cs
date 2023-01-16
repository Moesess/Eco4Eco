using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
	public class ResourcePresenter : MonoBehaviour
	{
		public static ResourcePresenter Instance;
        
		public TMP_Text budgetValue;
        public TMP_Text powerValue;
        public TMP_Text trashValue;
        public TMP_Text foodValue;
        public TMP_Text goodsValue;
		public GameObject BudgetImage;
		public GameObject PowerImage;
		public GameObject TrashImage;
		public GameObject FoodImage;
		public GameObject GoodsImage;

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
			ResourceManager.Instance.Power.OnIAmountChange += OnPowerChanged;
			ResourceManager.Instance.Budget.OnIAmountChange += OnBudgetChanged;
			ResourceManager.Instance.Trash.OnIAmountChange += OnTrashChanged;
			ResourceManager.Instance.Food.OnIAmountChange += OnFoodChanged;
			ResourceManager.Instance.Goods.OnIAmountChange += OnGoodsChanged;


			// Seting Resources sprites
			float TexY = ResourceManager.Instance.BudgetImage.height;
			float TexX = ResourceManager.Instance.BudgetImage.width;
            this.BudgetImage.GetComponent<Image>().sprite = Sprite.Create(ResourceManager.Instance.BudgetImage, new Rect(0f, 0f, TexX, TexY), new Vector2(0.5f, 0.5f));
            this.PowerImage.GetComponent<Image>().sprite = Sprite.Create(ResourceManager.Instance.PowerImage, new Rect(0f, 0f, TexX, TexY), new Vector2(0.5f, 0.5f));
            this.TrashImage.GetComponent<Image>().sprite = Sprite.Create(ResourceManager.Instance.TrashImage, new Rect(0f, 0f, TexX, TexY), new Vector2(0.5f, 0.5f));
            this.FoodImage.GetComponent<Image>().sprite = Sprite.Create(ResourceManager.Instance.FoodImage, new Rect(0f, 0f, TexX, TexY), new Vector2(0.5f, 0.5f));
            this.GoodsImage.GetComponent<Image>().sprite = Sprite.Create(ResourceManager.Instance.GoodsImage, new Rect(0f, 0f, TexX, TexY), new Vector2(0.5f, 0.5f));
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
			}
		}
	}
}
