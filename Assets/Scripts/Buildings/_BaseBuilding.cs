/// Klasa podstawowa budynku, kazdy budynek musi dziedziczyc po niej
namespace EcoGame
{
    using static Resources.RESOURCES;
    using Resources;

    public class _BaseBuilding : IBuilding
    {
        private int iBaseCost; // Podstawowy koszt
        private int iTechLevel; // Poziom technologiczny budynku, budynki podzieli³bym na kategorie technologiczne, kolejne poziomy sa wydajniejsze ale jednoczesnie drozsze
        private int iCost; // Koszt budowy
        private int iAmount; // Iloœæ posiadanych budynkow - technicznie mnoznik
        private int iProduction; // Produkcja surowca
        private int iBaseProduction; // Podstawowa produkcja surowca
        private RESOURCES eUsedResource; // Uzycie surowca
        private int iUsedResourceAmount; // Ilosc uzytego surowca do produkcji
        private int iPollution; // Produkcja surowca Pollution
        private RESOURCES eResource; // Surowiec produkowany
        private int iCostMultiplier; // Mno¿nik kosztów budowy
        private int iProductionMultiplier; // Mno¿nik produkcji
        private string sName; // Nazwa budynku
        private string spanelName; // Nazwa panelu, w jakim budynek ma siê wyœwietlaæ
        private string sDescription; // Opis danego budynku

        public delegate void OnIChangeDelegate();
        public event OnIChangeDelegate OnIAmountChange;
        public event OnIChangeDelegate OnIProductionChange;

        // Gettery settery
        public int Cost
        {
            get { return this.iCost; }
            set { this.iCost = value; }
        }

        public int Amount
        {
            get { return this.iAmount; }
            set 
            { 
                this.iAmount = value;
                OnIAmountChange?.Invoke();
            }
        }

        public int Production
        {
            get { return this.iProduction; }
            set 
            {
                this.iProduction = value;
                OnIProductionChange?.Invoke();
            }
        }

        public int BaseProduction
        {
            get { return this.iBaseProduction; }
            set { this.iBaseProduction = value; }
        }

        public RESOURCES Resource
        {
            get { return this.eResource; }
            set { this.eResource = value; }
        }

        public RESOURCES UsedResource
        {
            get { return this.eUsedResource; }
            set { this.eUsedResource = value; }
        }

        public int UsedResourceAmount
        {
            get { return this.iUsedResourceAmount; }
            set { this.iUsedResourceAmount = value; }
        }

        public int CostMultiplier
        {
            get { return this.iCostMultiplier; }
            set { this.iCostMultiplier = value; }
        }

        public int ProductionMultiplier
        {
            get { return this.iProductionMultiplier; }
            set { this.iProductionMultiplier = value; }
        }

        public string Name
        {
            get { return this.sName; }
            set { this.sName = value; }
        }

        public int Pollution
        {
            get { return this.iPollution; }
            set { this.iPollution = value; }
        }

        public int TechLevel
        {
            get { return this.iTechLevel; }
            set { this.iTechLevel = value; }
        }
        public int BaseCost
        {
            get { return this.iBaseCost; }
            set { this.iBaseCost = value; }
        }
        public string PanelName
        {
			get { return this.spanelName; }
			set { this.spanelName = value; }
		}

        public string Description
        {
	        get { return this.sDescription;}
            set { this.sDescription = value; }
        }

        public _BaseBuilding(
            string sName = "", string sPanelName = "", RESOURCES eResource = 0, RESOURCES eUsedResource = 0, int iUsedResourceAmount = 0,
            int iBaseCost = 0, int iCost = 0, int iTechLevel = 0, 
            int iAmount = 0, int iBaseProduction = 0, int iPollution = 0,
            int iCostMultiplier = 0, int iProductionMultiplier = 0, string sDescription = "")
        {
            this.Cost = 0;
            this.Amount = iAmount;
            this.BaseProduction = iBaseProduction;
            this.Resource = eResource;
            this.UsedResource = eUsedResource;
            this.UsedResourceAmount = iUsedResourceAmount;
            this.CostMultiplier = iCostMultiplier;
            this.ProductionMultiplier = iProductionMultiplier;
            this.Name = sName;
            this.Pollution = iPollution;
            this.TechLevel = iTechLevel;
            this.BaseCost = iBaseCost;
            this.PanelName = sPanelName;
            this.Production = Production;
            this.Description = sDescription;
        }

        public virtual void TickPollution()
        {
            ResourceManager.Instance.Resources[(int)R_POLLUTION].Add(this.Pollution * this.Amount);
        }

        public virtual void RecalculateCost() 
        {
            this.Cost = (int)(((this.Amount + 1) * this.BaseCost * 13) / 100 * System.Math.Pow(this.TechLevel + 1, (float)this.CostMultiplier/100f));
        }

        public int GetFutureCost()
        {
            return (int)(((this.Amount + 2) * this.BaseCost * 13) / 100 * System.Math.Pow(this.TechLevel + 1, (float)this.CostMultiplier/100f));
        }

        public virtual void RecalculateProduction()
        {
            Production = calcProduction();
        }

        // Methods
        public void SetCost(int _iVal)
        {
            this.Cost = _iVal;
        }

        public int calcProduction()
        {
            return (int)(this.BaseProduction * this.Amount * (float)this.ProductionMultiplier / 100f * ResourceManager.Instance.PollutionEffectPercent * ResourceManager.Instance.HappyEffectPercent);
        }

        public void IncreaseAmount()
        {
            this.Amount++;
            //RecalculateCost();
            //RecalculateProduction();
        }

        public void DecreaseAmount()
        {
            if (this.Amount - 1 < 0)
                return;
            else
            {
                this.Amount--;
                //RecalculateCost();
                //RecalculateProduction();
            }
        }
    }
}
