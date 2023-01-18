/// Klasa podstawowa budynku, kazdy budynek musi dziedziczyc po niej
namespace EcoGame
{
    using static Resources.RESOURCES;
    public class _BaseBuilding : IBuilding
    {
        private int iBaseCost; // Podstawowy koszt
        private int iTechLevel; // Poziom technologiczny budynku, budynki podzieli³bym na kategorie technologiczne, kolejne poziomy sa wydajniejsze ale jednoczesnie drozsze
        private int iCost; // Koszt budowy
        private int iAmount; // Iloœæ posiadanych budynkow - technicznie mnoznik
        private int iProduction; // Produkcja surowca
        private int iUsedResource; // Uzycie surowca
        private int iUsedResourceAmount; // Uzycie surowca
        private int iPollution; // Produkcja surowca Pollution
        private int iResource; // Surowiec produkowany
        private int iCostMultiplier; // Mno¿nik kosztów budowy
        private int iProductionMultiplier; // Mno¿nik produkcji
        private string sName; // Nazwa budynku
        private string spanelName; // Nazwa panelu, w jakim budynek ma siê wyœwietlaæ

        public delegate void OnIChangeDelegate(int newAmount);
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
                OnIAmountChange?.Invoke(iAmount);
            }
        }
        public int Production
        {
            get { return this.iProduction; }
            set 
            { 
                this.iProduction = value;
                OnIProductionChange?.Invoke(iProduction);
            }
        }

        public int Resource
        {
            get { return this.iResource; }
            set { this.iResource = value; }
        }

        public int UsedResource
        {
            get { return this.iUsedResource; }
            set { this.iUsedResource = value; }
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

        public _BaseBuilding(
            string sName = "", string spanelName = "", int iResource = 0, int iUsedResource = 0, int iUsedResourceAmount = 0,
            int iBaseCost = 0, int iCost = 0, int iTechLevel = 0, 
            int iAmount = 0, int iProduction = 0, int iPollution = 0,
            int iCostMultiplier = 0, int iProductionMultiplier = 0)
        {
            this.Cost = iCost;
            this.Amount = iAmount;
            this.Production = iProduction;
            this.Resource = iResource;
            this.UsedResource = iUsedResource;
            this.UsedResourceAmount = iUsedResourceAmount;
            this.CostMultiplier = iCostMultiplier;
            this.ProductionMultiplier = iProductionMultiplier;
            this.Name = sName;
            this.Pollution = iPollution;
            this.TechLevel = iTechLevel;
            this.BaseCost = iBaseCost;
            this.PanelName = spanelName;
        }

        public virtual void Tick()
        {
            ResourceManager.Instance.Resources[this.Resource].Add(this.Production);
            ResourceManager.Instance.Resources[(int)R_POLLUTION].Add(this.Pollution);
        }
        
        public virtual void RecalculateCost() 
        {
            this.Cost = (int)(this.BaseCost * System.Math.Pow(this.TechLevel + 1, this.CostMultiplier));
        }

        public virtual void RecalculateProduction() 
        {
            this.Production = (int)System.Math.Pow(this.TechLevel + 1, this.ProductionMultiplier) * this.Amount;
        } 

        // Methods
        public void SetCost(int _iVal)
        {
            this.iCost = _iVal;
        }

        public void IncreaseAmount(int _iVal)
        {
            this.iAmount += _iVal;
            RecalculateCost();
            RecalculateProduction();
        }

        public void IncreaseAmount()
        {
            this.iAmount++;
            RecalculateCost();
            RecalculateProduction();
        }
    }
}
