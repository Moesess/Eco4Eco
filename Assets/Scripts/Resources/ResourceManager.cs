using UnityEngine;

namespace EcoGame
{
    using System.Collections.Generic;
    using static Resources.RESOURCES;
    using static Resources.RESOURCE_PRICES;

    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;

        public Dictionary<int, Resource> Resources = new();
        public float PollutionEffectPercent;
        public float HappyEffectPercent;
		public Resource Power // Energia
        {
            get { return Resources[(int)R_POWER]; }
            set { this.Resources[(int)R_POWER] = value; }
        }
        public Resource Budget // Budzet
        {
            get { return Resources[(int)R_BUDGET]; }
            set { this.Resources[(int)R_BUDGET] = value; }
        }
        public Resource Trash // Smieci
        {
            get { return Resources[(int)R_TRASH]; }
            set { this.Resources[(int)R_TRASH] = value; }
        }
        public Resource Food // Zywnosc
        {
            get { return Resources[(int)R_FOOD]; }
            set { this.Resources[(int)R_FOOD] = value; }
        }
        public Resource Goods // Towary konsumpcyjne
        {
            get { return Resources[(int)R_GOODS]; }
            set { this.Resources[(int)R_GOODS] = value; }
        }
        public Resource Oil // Ropa naftowa
        {
            get { return Resources[(int)R_OIL]; }
            set { this.Resources[(int)R_OIL] = value; }
        }
        public Resource Coal // Wegiel
        {
            get { return Resources[(int)R_COAL]; }
            set { this.Resources[(int)R_COAL] = value; }
        }
        public Resource Gas // Gaz ziemny
        {
            get { return Resources[(int)R_GAS]; }
            set { this.Resources[(int)R_GAS] = value; }
        }
        public Resource Pollution // Œmieci
        {
            get { return Resources[(int)R_POLLUTION]; }
            set { this.Resources[(int)R_POLLUTION] = value; }
        }

        public Resource Uranium // Uran
        {
	        get { return Resources[(int)R_URANIUM]; }
	        set { this.Resources[(int)R_URANIUM] = value; }
        }
        public Resource Peat // Torf
        {
	        get { return Resources[(int)R_PEAT]; }
	        set { this.Resources[(int)R_PEAT] = value; }
        }
        public Resource Leaf // Listki
        {
	        get { return Resources[(int)R_LEAF]; }
	        set { this.Resources[(int)R_LEAF] = value; }
        }

        public int iPower;
        public int iBudget;
        public int iTrash;
        public int iFood;
        public int iGoods;
        public int iOil;
        public int iCoal;
        public int iGas;
        public int iPollution;
        public int iUranium;
        public int iPeat;
        public int iLeaf;
        public int iHappy;

        public int iUsedPower;
        public int iUsedBudget;
        public int iUsedTrash;
        public int iUsedFood;
        public int iUsedGoods;
        public int iUsedOil;
        public int iUsedCoal;
        public int iUsedGas;
        public int iUsedPollution;
        public int iUsedUranium;
        public int iUsedPeat;
        public int iUsedLeaf;
        public int iUsedHappy;

        private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
            {
	            Instance = this;
                this.PollutionEffectPercent = 1f;
                this.HappyEffectPercent = 1f;
                this.Resources.Add((int)R_POWER, new Resource("Pr¹d", 0, R_PRICE_POWER));
                this.Resources.Add((int)R_BUDGET, new Resource("Bud¿et", 1000));
                this.Resources.Add((int)R_TRASH, new Resource("Œmieci", 0));
                this.Resources.Add((int)R_FOOD, new Resource("¯ywnoœæ", 0, R_PRICE_FOOD));
                this.Resources.Add((int)R_GOODS, new Resource("Towary konsumpcyjne", 0,R_PRICE_GOODS));
                this.Resources.Add((int)R_OIL, new Resource("Ropa naftowa", 0, R_PRICE_OIL));
                this.Resources.Add((int)R_COAL, new Resource("Wêgiel", 0, R_PRICE_COAL));
                this.Resources.Add((int)R_GAS, new Resource("Gaz ziemny", 0, R_PRICE_GAS));
                this.Resources.Add((int)R_POLLUTION, new Resource("Zanieczyszczenie œrodowiska", 5000, (int)R_POLLUTION_MAXIMUM, 0, 0));
                this.Resources.Add((int)R_URANIUM, new Resource("Uran", 0, R_PRICE_URANIUM));
                this.Resources.Add((int)R_PEAT, new Resource("Torf", 0, R_PRICE_PEAT));
                this.Resources.Add((int)R_LEAF, new Resource("Listek", 0));
                this.Resources.Add((int)R_HAPPY, new Resource("Zadowolenie", 50, 100, 0, 0));
            }
        }

        private void Start()
        {
            this.Resources[(int)R_POLLUTION].OnAmountChange += PollutionChecker;
            this.Resources[(int)R_HAPPY].OnAmountChange += HappyChecker;

            foreach (Resource Res in this.Resources.Values)
            {
                Res.SetValue(Res.Amount);
            }
        }

        private void Update()
        {
            iPower = this.Resources[(int)R_POWER].Amount;
            iBudget = this.Resources[(int)R_BUDGET].Amount;
            iTrash = this.Resources[(int)R_TRASH].Amount;
            iFood = this.Resources[(int)R_FOOD].Amount;
            iGoods = this.Resources[(int)R_GOODS].Amount;
            iOil = this.Resources[(int)R_OIL].Amount;
            iCoal = this.Resources[(int)R_COAL].Amount;
            iGas = this.Resources[(int)R_GAS].Amount;
            iPollution = this.Resources[(int)R_POLLUTION].Amount;
            iUranium = this.Resources[(int)R_URANIUM].Amount;
            iPeat = this.Resources[(int)R_PEAT].Amount;
            iLeaf = this.Resources[(int)R_LEAF].Amount;
            iHappy = this.Resources[(int)R_HAPPY].Amount;

            iUsedPower = this.Resources[(int)R_POWER].UsedAmount;
            iUsedBudget = this.Resources[(int)R_BUDGET].UsedAmount;
            iUsedTrash = this.Resources[(int)R_TRASH].UsedAmount;
            iUsedFood = this.Resources[(int)R_FOOD].UsedAmount;
            iUsedGoods = this.Resources[(int)R_GOODS].UsedAmount;
            iUsedOil = this.Resources[(int)R_OIL].UsedAmount;
            iUsedCoal = this.Resources[(int)R_COAL].UsedAmount;
            iUsedGas = this.Resources[(int)R_GAS].UsedAmount;
            iUsedPollution = this.Resources[(int)R_POLLUTION].UsedAmount;
            iUsedUranium = this.Resources[(int)R_URANIUM].UsedAmount;
            iUsedPeat = this.Resources[(int)R_PEAT].UsedAmount;
            iUsedLeaf = this.Resources[(int)R_LEAF].UsedAmount;
            iUsedHappy = this.Resources[(int)R_HAPPY].UsedAmount;
        }

        public void ResetResourceForRecalculation()
        {
            this.Resources[(int)R_POWER].SetValue(0);
            this.Resources[(int)R_FOOD].SetValue(0);
            this.Resources[(int)R_GOODS].SetValue(0);
            this.Resources[(int)R_OIL].SetValue(0);
            this.Resources[(int)R_COAL].SetValue(0);
            this.Resources[(int)R_GAS].SetValue(0);
            this.Resources[(int)R_URANIUM].SetValue(0);
            this.Resources[(int)R_PEAT].SetValue(0);

            this.Resources[(int)R_POWER].SetUsedValue(0);
            this.Resources[(int)R_FOOD].SetUsedValue(0);
            this.Resources[(int)R_GOODS].SetUsedValue(0);
            this.Resources[(int)R_OIL].SetUsedValue(0);
            this.Resources[(int)R_COAL].SetUsedValue(0);
            this.Resources[(int)R_GAS].SetUsedValue(0);
            this.Resources[(int)R_URANIUM].SetUsedValue(0);
            this.Resources[(int)R_PEAT].SetUsedValue(0);
        }

        public void PollutionChecker()
        {
            float fPercent = (float)this.Resources[(int)R_POLLUTION].Amount / (float)this.Resources[(int)R_POLLUTION].MaxAmount;

            if (fPercent >= 0.75f)
                this.PollutionEffectPercent = 0.8f;
            else if (fPercent < 0.75f && fPercent > 0.5f)
                this.PollutionEffectPercent = 0.9f;
            else
                this.PollutionEffectPercent = 1f;

            if (this.Resources[(int)R_POLLUTION].Amount == this.Resources[(int)R_POLLUTION].MaxAmount)
            {
                // TODO PRZEGRANKO
            } 
            else if(this.Resources[(int)R_POLLUTION].Amount == 0)
            {
                // TODO WYGRANKO
            }
        }

        public void HappyChecker()
        {
            if (Resources[(int)R_HAPPY].Amount >= 75)
                this.HappyEffectPercent = 1.1f;
            else if (Resources[(int)R_HAPPY].Amount < 75 && Resources[(int)R_HAPPY].Amount >= 45)
                this.PollutionEffectPercent = 1f;
            else
                this.PollutionEffectPercent = 0.9f;

            if(Resources[(int)R_HAPPY].Amount == 0)
            {
                // TODO RESET PRZEGRANKO LUDZIE CIE NA WIDLACH WYNOSZA 
            }
        }
    }
}