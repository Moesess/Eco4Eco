/// Klasa podstawowa budynku, kazdy budynek musi dziedziczyc po niej

using UnityEngine;

namespace EcoGame
{
    public abstract class _BaseBuilding : MonoBehaviour, IBuilding
    {
        private int iBaseCost; // Podstawowy koszt
        private int iTechLevel; // Poziom technologiczny budynku, budynki podzieli�bym na kategorie technologiczne, kolejne poziomy sa wydajniejsze ale jednoczesnie drozsze
        private int iCost; // Koszt budowy
        private int iLevel; // Poziom budynku
        private int iAmount; // Ilo�� posiadanych budynkow - technicznie mnoznik
        private int iProduction; // Produkcja surowca Resource(odpowiedni surowiec)
        private int iPollution; // Produkcja surowca Pollution
        private string sName; // Nazwa budynku
        private string spanelName; // Nazwa panelu, w jakim budynek ma si� wy�wietla�

        // Gettery settery
        public int Cost
        {
            get { return this.iCost; }
            set { this.iCost = value; }
        }
        public int Level
        {
            get { return this.iLevel; }
            set { this.iLevel = value; }
        }
        public int Amount
        {
            get { return this.iAmount; }
            set { this.iAmount = value; }
        }
        public int Production
        {
            get { return this.iProduction; }
            set { this.iProduction = value; }
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

        public _BaseBuilding()
        {
            this.Cost = 0;
            this.Level = 0;
            this.Production = 0;
            this.TechLevel = 0;
            this.BaseCost = 0;
            this.Amount = 0;
            this.Name = "";
            this.PanelName = "";
            this.Pollution = 0;
        }

        // Abstracts
        public abstract void Tick();
        
        public abstract void RecalculateCost(); 

        public abstract void RecalculateProduction(); 

        // Methods
        public void IncreaseLevel()
        {
            this.iLevel++;
            RecalculateCost();
            RecalculateProduction();
        }

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
