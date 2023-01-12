/// Klasa podstawowa budynku, kazdy budynek musi dziedziczyc po niej

using UnityEngine;

namespace EcoGameCore
{
    public class _BaseBuilding : MonoBehaviour, IBuilding
    {
        private int iCost; // Koszt budowy
        private int iLevel; // Poziom budynku
        private int iAmount; // Iloœæ posiadanych budynkow - technicznie mnoznik
        private int iProduction; // Produkcja surowca Resource(odpowiedni surowiec)
        private int iPollution; // Produkcja surowca Pollution
        private string sName; // Nazwa budynku

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
        public _BaseBuilding()
        {
            this.Cost = 0;
            Level = 0;
            Production = 0;
            Name = "";
            Pollution = 0;
        }
        // Metody
    }
}
