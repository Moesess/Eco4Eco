using UnityEngine;

namespace EcoGameCore
{
    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;

        private Resource Power // Energia
        {
            get { return Power; }
            set { this.Power = value; }
        }
        private Resource Budget // Budzet
        {
            get { return Power; }
            set { this.Power = value; }
        }
        private Resource Trash // Smieci
        {
            get { return Power; }
            set { this.Power = value; }
        }
        private Resource Food // Zywnosc
        {
            get { return Power; }
            set { this.Power = value; }
        }
        private Resource Goods // Towary konsumpcyjne
        {
            get { return Power; }
            set { this.Power = value; }
        }
        private Resource Oil // Ropa naftowa
        {
            get { return Oil; }
            set { this.Oil = value; }
        }
        private Resource Coal // Wegiel
        {
            get { return Coal; }
            set { this.Coal = value; }
        }  
        private Resource Gas // Gaz ziemny
        {
            get { return Gas; }
            set { this.Gas = value; }
        }
        private Resource Pollution // Gaz ziemny
        {
            get { return Pollution; }
            set { this.Pollution = value; }
        }

        private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
                Instance = this;
        }

        /// Metody odpowiadajace za pozyskiwanie aktualnego stanu zasobu
        public int GetPowerVal() { return this.Power.iAmount; }
        public int GetBudgetVal() { return this.Budget.iAmount; }
        public int GetTrashVal() { return this.Trash.iAmount; }
        public int GetFoodVal() { return this.Food.iAmount; }
        public int GetGoodsVal() { return this.Goods.iAmount; }
        public int GetOilVal() { return this.Oil.iAmount; }
        public int GetCoalVal() { return this.Coal.iAmount; }
        public int GetGasVal() { return this.Gas.iAmount; }
        public int GetPollutionVal() { return this.Pollution.iAmount; }

        /// Metody odpowiadajace za ustawienie aktualnego stanu zasobu
        public void SetPowerVal(int _iVal) { this.Power = new Resource(_iVal); }
        public void SetBudgetVal(int _iVal) { this.Budget = new Resource(_iVal); }
        public void SetTrashVal(int _iVal) { this.Trash = new Resource(_iVal); }
        public void SetFoodVal(int _iVal) { this.Food = new Resource(_iVal); }
        public void SetGoodsVal(int _iVal) { this.Goods = new Resource(_iVal); }
        public void SetOilVal(int _iVal) { this.Oil = new Resource(_iVal); }
        public void SetCoalVal(int _iVal) { this.Coal = new Resource(_iVal); }
        public void SetGasVal(int _iVal) { this.Gas = new Resource(_iVal); }
        public void SetPollutionVal(int _iVal) { this.Pollution = new Resource(_iVal); }

        /// Metody odpowiadajace za dodanie odpowiedniej wartosci zasobu, mozna za ich pomoca rowniez go odjac przekazujac wartosc ujemna
        public void AddPower(int _iVal)
        {
            this.Power += _iVal;

            if (this.Power < 0) this.Power = new Resource(0);
        }

        public void AddBudget(int _iVal)
        {
            this.Budget += _iVal;

            if (this.Budget < 0) this.Budget = new Resource(0);
        }

        public void AddTrash(int _iVal)
        {
            this.Trash += _iVal;

            if (this.Trash < 0) this.Trash = new Resource(0);
        }

        public void AddFood(int _iVal)
        {
            this.Food += _iVal;

            if (this.Food < 0) this.Food = new Resource(0);
        }

        public void AddGoods(int _iVal)
        {
            this.Goods += _iVal;

            if (this.Goods < 0) this.Goods = new Resource(0);
        }

        public void AddOil(int _iVal)
        {
            this.Oil += _iVal;

            if (this.Oil < 0) this.Oil = new Resource(0);
        }

        public void AddCoal(int _iVal)
        {
            this.Coal += _iVal;

            if (this.Coal < 0) this.Coal = new Resource(0);
        }

        public void AddGas(int _iVal)
        {
            this.Gas += _iVal;

            if (this.Gas < 0) this.Gas = new Resource(0);
        }

        public void AddPollution(int _iVal)
        {
            this.Pollution += _iVal;

            if (this.Pollution < 0) this.Pollution = new Resource(0);
        }
    }
}
