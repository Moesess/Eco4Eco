using UnityEngine;

namespace EcoGameCore
{
    using Resources;
    using System.Collections.Generic;

    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;
        public Dictionary<string, Resource> Resources = new();

        public Resource Power // Energia
        {
            get { return Resources[ResourcesConsts.RESOURCE_POWER]; }
            set { this.Resources[ResourcesConsts.RESOURCE_POWER] = value; }
        }
        public Resource Budget // Budzet
        {
            get { return Resources[ResourcesConsts.RESOURCE_BUDGET]; }
            set { this.Resources[ResourcesConsts.RESOURCE_BUDGET] = value; }
        }
        public Resource Trash // Smieci
        {
            get { return Resources[ResourcesConsts.RESOURCE_TRASH]; }
            set { this.Resources[ResourcesConsts.RESOURCE_TRASH] = value; }
        }
        public Resource Food // Zywnosc
        {
            get { return Resources[ResourcesConsts.RESOURCE_FOOD]; }
            set { this.Resources[ResourcesConsts.RESOURCE_FOOD] = value; }
        }
        public Resource Goods // Towary konsumpcyjne
        {
            get { return Resources[ResourcesConsts.RESOURCE_GOODS]; }
            set { this.Resources[ResourcesConsts.RESOURCE_GOODS] = value; }
        }
        public Resource Oil // Ropa naftowa
        {
            get { return Resources[ResourcesConsts.RESOURCE_OIL]; }
            set { this.Resources[ResourcesConsts.RESOURCE_OIL] = value; }
        }
        public Resource Coal // Wegiel
        {
            get { return Resources[ResourcesConsts.RESOURCE_COAL]; }
            set { this.Resources[ResourcesConsts.RESOURCE_COAL] = value; }
        }
        public Resource Gas // Gaz ziemny
        {
            get { return Resources[ResourcesConsts.RESOURCE_GAS]; }
            set { this.Resources[ResourcesConsts.RESOURCE_GAS] = value; }
        }
        public Resource Pollution // Gaz ziemny
        {
            get { return Resources[ResourcesConsts.RESOURCE_POLLUTION]; }
            set { this.Resources[ResourcesConsts.RESOURCE_POLLUTION] = value; }
        }

        private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
            {
                Instance = this;
                Resources.Add(ResourcesConsts.RESOURCE_POWER, new Resource("Pr¹d", 0));
                Resources.Add(ResourcesConsts.RESOURCE_BUDGET, new Resource("Bud¿et", 0));
                Resources.Add(ResourcesConsts.RESOURCE_TRASH, new Resource("Œmieci", 0));
                Resources.Add(ResourcesConsts.RESOURCE_FOOD, new Resource("¯ywnoœæ", 0));
                Resources.Add(ResourcesConsts.RESOURCE_GOODS, new Resource("Towary konsumpcyjne", 0));
                Resources.Add(ResourcesConsts.RESOURCE_OIL, new Resource("Ropa naftowa", 0));
                Resources.Add(ResourcesConsts.RESOURCE_COAL, new Resource("Wêgiel", 0));
                Resources.Add(ResourcesConsts.RESOURCE_GAS, new Resource("Gaz ziemny", 0));
                Resources.Add(ResourcesConsts.RESOURCE_POLLUTION, new Resource("Zanieczyszczenie œrodowiska", 0));
            }
        }

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
